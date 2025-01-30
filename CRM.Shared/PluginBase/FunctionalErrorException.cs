using Microsoft.Xrm.Sdk;
using System;

namespace CRM.Shared.PluginBase
{
    public class FunctionalErrorException : Exception
    {
        public string MessageKey;
        public string[] Parameters;
        public new string Message { get { return GetMessage(); } }
        public MessageController MessageController;
        protected string GetMessage()
        {
            if (MessageController == null)
            {
                throw new InvalidPluginExecutionException("Message Controller is null");
            }
            string message = MessageController.GetMessage(MessageKey);

            if (Parameters == null)
                return message;

            return String.Format(message, Parameters);
        }
        public FunctionalErrorException(string messageKey)
        {
            MessageKey = messageKey;
        }
        public FunctionalErrorException(string messageKey, params string[] param)
        {
            MessageKey = messageKey;
            Parameters = param;
        }
    }
}
