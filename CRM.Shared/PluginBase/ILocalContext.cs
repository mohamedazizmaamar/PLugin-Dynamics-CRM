using Microsoft.Xrm.Sdk;

namespace CRM.Shared.PluginBase
{
    public interface ILocalContext
    {
        ServiceProxy AdminService { get; }
        IPluginExecutionContext PluginExecutionContext { get; }
        IOrganizationServiceFactory OrganizationServiceFactory { get; }

        Entity TargetEntity { get; set; }
        Entity PreImage { get; set; }
        Entity PostImage { get; set; }
        Entity CompleteEntity { get; }

        ServiceProxy Service { get; set; }
        ITracingService TracingService { get; }
        MessageController MessageController { get; }
        void Trace(string message);
    }
}
