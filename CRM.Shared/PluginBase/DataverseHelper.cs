using CRM.Shared.PluginBase.Referentials;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;

namespace CRM.Shared.PluginBase
{
    public class DataverseHelper
    {
        //public static object GetEnvironmentVariable(IOrganizationService service, string key)
        //{
        //}

        /// <summary>
        /// Get user language
        /// </summary>
        /// <param name="service">IOrganizationServices</param>
        /// <param name="userId">User Guid </param>
        /// <returns></returns>
        public static int GetUserLCID(IOrganizationService service, Guid userId)
        {
            EntityCollection userSettings = service.RetrieveMultiple(
                new QueryExpression("usersettings")
                {
                    ColumnSet = new ColumnSet("uilanguageid"),
                    Criteria = new FilterExpression
                    {
                        Conditions =
                        {
                            new ConditionExpression("systemuserid", ConditionOperator.Equal, userId)
                        }
                    }
                });

            if (userSettings.Entities.Count == 0 || userSettings.Entities.Count > 1)
            {
                return LCID.English;
            }

            return userSettings.Entities[0].GetAttributeValue<int>("uilanguageid");
        }
    }
}
