using Azure.Identity;
using CRM.Shared.PluginBase;
using CRM.Shared.PluginBase.Referentials;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace CRM.Plugins
{
    public class ContactPlugin : PluginBase
    {
        #region Constructor
        public ContactPlugin() : base(typeof(ContactPlugin).Name)
        {
            RegisteredEvents.Add(
               new PluginStep
                   (
                       MessageProcessingStepMode.Synchronous, MessageProcessingStepStage.PreOperation,
                       MessageName.Create,
                        Contact.EntityLogicalName, ExecutePreOperationCreateSync)
                   );
            RegisteredEvents.Add(
               new PluginStep
                   (
                       MessageProcessingStepMode.Asynchronous, MessageProcessingStepStage.PostOperation,
                       MessageName.Create,
                        Contact.EntityLogicalName, ExecutePostOperationCreateAsync)
                   );
        }
        #endregion

        #region Plugin Methods
        private void ExecutePreOperationCreateSync(LocalPluginContext localContext)
        {
            localContext.Trace(MethodBase.GetCurrentMethod().Name);
            Contact contact = localContext.TargetEntity.ToEntity<Contact>();
            UpperName(localContext, contact);
        }

        private void ExecutePostOperationCreateAsync(LocalPluginContext localContext)
        {
            localContext.Trace(MethodBase.GetCurrentMethod().Name);
            Contact contact = localContext.TargetEntity.ToEntity<Contact>();
            _ = CallGraphAPI(localContext, contact);
        }
        #endregion

        #region BusinessLogic
        /// <summary>
        /// Method that processes the rgr notification service call
        /// </summary>
        /// <param name="localContext"></param>
        /// <param name="postImage"></param>
        private void UpperName(LocalPluginContext localContext, Contact target)
        {
            localContext.Trace(MethodBase.GetCurrentMethod().Name);
            //Get the contact's last name from target entity
            string lastName = target.GetAttributeValue<string>("lastname");

            //Set last Name in pascal case
            target["lastname"] = lastName.ToUpper();

            string firstName = target.GetAttributeValue<string>("firstname");

            //Set last Name in pascal case
            target["firstname"] = firstName.ToUpper();
        }

        private async Task CallGraphAPI(LocalPluginContext localContext, Contact target)
        {
            localContext.Trace(MethodBase.GetCurrentMethod().Name);

            List<MSGraphUser> msGraphUsers = new List<MSGraphUser>();
            try
            {
                // Create the Graph service client with a ChainedTokenCredential which gets an access
                // token using the available Managed Identity or environment variables if running
                // in development.
                var credential = new ChainedTokenCredential(
                new ManagedIdentityCredential(),
                new EnvironmentCredential());

                string[] scopes = new[] { "https://graph.microsoft.com/.default" };

                var graphServiceClient = new GraphServiceClient(
                    credential, scopes);

                localContext.Trace("graph");

                       
                var users = await graphServiceClient.Users.Request().GetAsync();
                //var users = await graphServiceClient.Users.GetAsync();
                foreach (var u in users)
                {
                    MSGraphUser user = new MSGraphUser();
                    user.userPrincipalName = u.UserPrincipalName;
                    user.displayName = u.DisplayName;
                    user.mail = u.Mail;
                    user.jobTitle = u.JobTitle;

                    localContext.Trace("User :"+user.userPrincipalName);

                    msGraphUsers.Add(user);

                    Contact contact = new Contact(target.Id);
                    contact.EMailAddress1 = u.UserPrincipalName;
                    localContext.Service.Update(contact);
                }
                
            }
            catch (Exception ex)
            {
                localContext.Trace($"Error: {ex.Message}");  // Log errors if something goes wrong
            }
        }

        #endregion
    }

    internal class MSGraphUser
    {
        public object userPrincipalName { get; internal set; }
        public object displayName { get; internal set; }
        public object mail { get; internal set; }
        public object jobTitle { get; internal set; }
    }
}