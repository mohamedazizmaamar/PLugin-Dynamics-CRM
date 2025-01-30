using CRM.Shared.PluginBase.Extensions;
using CRM.Shared.PluginBase.Referentials;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.ServiceModel;

namespace CRM.Shared.PluginBase
{
    public class PluginBase : IPlugin
    {
        protected string EntitySchemaName { get; }
        public string EntityTechnicalName { get { return EntitySchemaName.ToLower(); } }

        internal PluginBase(string entitySchemaName)
        {
            EntitySchemaName = entitySchemaName;
        }

        private Collection<PluginStep> registeredEvents;

        internal Collection<PluginStep> RegisteredEvents
        {
            get
            {
                if (registeredEvents == null)
                {
                    registeredEvents = new Collection<PluginStep>();
                }
                return registeredEvents;
            }
        }

        /// <summary>
        ///     Executes the plug-in.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <remarks>
        ///     For improved performance, Microsoft Dynamics CRM caches plug-in instances.
        ///     The plug-in's Execute method should be written to be stateless as the constructor
        ///     is not called for every invocation of the plug-in. Also, multiple system threads
        ///     could execute the plug-in at the same time. All per invocation state information
        ///     is stored in the context. This means that you should not use global variables in plug-ins.
        /// </remarks>
        public void Execute(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
                throw new ArgumentNullException(nameof(serviceProvider));

            var localcontext = new LocalPluginContext(serviceProvider);

            localcontext.Trace(string.Format(CultureInfo.InvariantCulture, $"Entered {EntitySchemaName}.Execute()"));
            try
            {
                localcontext.TracingService.TraceContext(localcontext.PluginExecutionContext, false, true, true, localcontext.Service, true);

                var entityAction = RegisteredEvents.FirstOrDefault(r =>
                r.MessageProcessingStepMode == localcontext.PluginExecutionContext.Mode &&
                r.MessageProcessingStepStage == localcontext.PluginExecutionContext.Stage &&
                r.MessageName == localcontext.PluginExecutionContext.MessageName &&
                (string.IsNullOrWhiteSpace(r.PrimaryEntityName) ||
                r.PrimaryEntityName == localcontext.PluginExecutionContext.PrimaryEntityName
                ))?.Method ?? throw new InvalidPluginExecutionException("PluginStep doesn't exist ");
                entityAction.Invoke(localcontext);

                localcontext.TracingService.TraceContext(localcontext.PluginExecutionContext, false, true, true, localcontext.Service, false);

                // now exit - if the derived plug-in has incorrectly registered overlapping event registrations,
                // guard against multiple executions.
            }
            catch (FunctionalErrorException e)
            {
                e.MessageController = localcontext.MessageController;
                throw new InvalidPluginExecutionException(e.Message);
            }
            catch (InvalidPluginExecutionException e)
            {
                localcontext.Trace(string.Format(CultureInfo.InvariantCulture, $"InvalidPluginExecutionException: {e}"));

                throw new InvalidPluginExecutionException(e.Message);
            }
            catch (FaultException<OrganizationServiceFault> e)
            {
                localcontext.Trace(string.Format(CultureInfo.InvariantCulture, $"FaultException: {e}"));
                localcontext.Trace($"Detail.Message: {e.Detail.Message}");
                var innerFault = e.Detail.InnerFault;
                if (innerFault != null)
                    localcontext.Trace($"Detail.InnerFault: {innerFault}\n{innerFault.Message}\n{innerFault.TraceText}");
                throw new InvalidPluginExecutionException($"{localcontext.MessageController.GetMessage(ErrorMessage.TechnicalError)} \n\n {e.Detail.Message}");
            }
            catch (Exception e)
            {
                localcontext.Trace(string.Format(CultureInfo.InvariantCulture, $"Exception: {e}"));

                throw new InvalidPluginExecutionException($"{localcontext.MessageController.GetMessage(ErrorMessage.TechnicalError)} \n\n {e.Message}");
            }
            finally
            {
                localcontext.Trace(string.Format(CultureInfo.InvariantCulture, $"Exiting {EntitySchemaName}.Execute()"));
            }
        }
    }
}
