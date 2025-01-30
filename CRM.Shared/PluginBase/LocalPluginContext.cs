using CRM.Shared.PluginBase.Extensions;
using Microsoft.Xrm.Sdk;
using System;
using System.Linq;

namespace CRM.Shared.PluginBase
{
    public class LocalPluginContext : ILocalContext
    {
        public MessageController MessageController { get; }

        public IPluginExecutionContext PluginExecutionContext { get; }

        public IOrganizationServiceFactory OrganizationServiceFactory { get; }
        public ServiceProxy Service { get; set; }

        public ServiceProxy AdminService { get; }

        public ITracingService TracingService { get; }

        internal LocalPluginContext(IServiceProvider serviceProvider)
        {
            if (serviceProvider == null)
                throw new ArgumentNullException(nameof(serviceProvider));

            PluginExecutionContext = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            TracingService = (ITracingService)serviceProvider.GetService(typeof(ITracingService));

            OrganizationServiceFactory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            var service = OrganizationServiceFactory.CreateOrganizationService(PluginExecutionContext.UserId);
            Service = new ServiceProxy(service, this);

            var adminService = OrganizationServiceFactory.CreateOrganizationService(null);
            AdminService = new ServiceProxy(adminService, this);

            MessageController = new MessageController(Service, PluginExecutionContext.UserId);
        }
        public Entity TargetEntity
        {
            get
            {
                if (PluginExecutionContext != null &&
                PluginExecutionContext.InputParameters.Contains("Target") &&
                                    PluginExecutionContext.InputParameters["Target"] is Entity entity)
                {
                    return entity;
                }
                else if (PluginExecutionContext != null &&
                    PluginExecutionContext.InputParameters.Contains("Target") &&
                    PluginExecutionContext.InputParameters["Target"] is EntityReference entityRef)
                {
                    return new Entity(entityRef.LogicalName, entityRef.Id);
                }
                return null;
            }
            set
            {
                PluginExecutionContext.InputParameters["Target"] = value;
            }
        }

        public Entity PreImage
        {
            get
            {
                if (PluginExecutionContext != null &&
                    PluginExecutionContext.PreEntityImages != null &&
                    PluginExecutionContext.PreEntityImages.Count > 0)
                {
                    return PluginExecutionContext.PreEntityImages.Values.FirstOrDefault();
                }
                return null;
            }
            set
            {
                PluginExecutionContext.PreEntityImages.Values.Add(value);

            }
        }

        public Entity PostImage
        {
            get
            {
                if (PluginExecutionContext != null &&
                    PluginExecutionContext.PostEntityImages != null &&
                    PluginExecutionContext.PostEntityImages.Count > 0)
                {
                    return PluginExecutionContext.PostEntityImages.Values.FirstOrDefault();
                }
                return null;
            }
            set
            {
                PluginExecutionContext.PostEntityImages.Values.Add(value);

            }
        }

        private Entity _completeEntity;
        public Entity CompleteEntity
        {
            get
            {
                if (_completeEntity == null)
                {
                    _completeEntity = TargetEntity.Clone().Merge(PostImage).Merge(PreImage);
                }
                return _completeEntity;
            }
        }

        /// <summary>
        /// Add a message in CRM tracing service
        /// </summary>
        /// <param name="message">Message to be traced</param>
        public void Trace(string message)
        {
            if (string.IsNullOrWhiteSpace(message) || (TracingService == null))
                return;

            TracingService.Trace(message);
        }

        /// <summary>
        /// Create an object from a plugin input parameter
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="inputParameter">parameter name</param>
        /// <returns></returns>
        public T GetObjectFromInputParameter<T>(string inputParameter)
        {
            TracingService.Trace("Getting object from input parameters");
            var parametersCollection = PluginExecutionContext.InputParameters;
            return GetObjectFromParameters<T>(inputParameter, parametersCollection);
        }

        /// <summary>
        /// Create an object from a plugin output parameter
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="outputParameter">parameter name</param>
        /// <returns></returns>
        public T GetObjectFromOutputParameter<T>(string outputParameter)
        {
            TracingService.Trace("Getting object from output parameters");
            var parametersCollection = PluginExecutionContext.OutputParameters;
            return GetObjectFromParameters<T>(outputParameter, parametersCollection);
        }

        /// <summary>
        /// Check if the plugin input or  output parameters contains the required parameters. if exists, return an object containing this parameter.
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="parameter">parameter name</param>
        /// <param name="parametersCollection">parameters collection</param>
        /// <returns></returns>
        private static T GetObjectFromParameters<T>(string parameter, ParameterCollection parametersCollection)
        {
            return (parametersCollection.Contains(parameter) ? (T)parametersCollection[parameter] : default);
        }
    }
}
