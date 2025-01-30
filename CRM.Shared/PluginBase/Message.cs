using CRM.Shared.PluginBase.Referentials;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;

namespace CRM.Shared.PluginBase
{
    public class MessageController
    {
        public int? CurrentUserLCID;
        public Dictionary<string, string> MessageDic { get; set; }

        public MessageController(IOrganizationService service, Guid userId)
        {
            CurrentUserLCID = DataverseHelper.GetUserLCID(service, userId);
            switch (CurrentUserLCID)
            {
                case 1036: MessageDic = ErrorMessage._1036; break;
                default: MessageDic = ErrorMessage._1033; break;
            }
        }

        public string GetMessage(string key)
        {
            if (!MessageDic.TryGetValue(key, out string value))
            {
                throw new InvalidPluginExecutionException("Error: Provided translation key could not be resolved in the current context. Please contact your administrator.");
            }
            return value;
        }
    }
}
