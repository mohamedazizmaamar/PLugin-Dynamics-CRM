using System;

namespace CRM.Shared.PluginBase
{
    public class PluginStep
    {
        public int MessageProcessingStepMode { get; set; }
        public int MessageProcessingStepStage { get; set; }
        public string MessageName { get; set; }
        public string PrimaryEntityName { get; set; }
        public Action<LocalPluginContext> Method { get; set; }

        public PluginStep(int messageProcessingStepMode, int messageProcessingStepStage, string messageName, string primaryEntityName, Action<LocalPluginContext> method)
        {
            MessageProcessingStepMode = messageProcessingStepMode;
            MessageProcessingStepStage = messageProcessingStepStage;
            MessageName = messageName;
            PrimaryEntityName = primaryEntityName;
            Method = method;
        }
    }
}
