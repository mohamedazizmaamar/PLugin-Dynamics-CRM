using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRM.Shared.PluginBase.Extensions
{
    public static class TracingExtension
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="tracingservice"></param>
        /// <param name="plugincontext"></param>
        /// <param name="parentcontext">Display Parent Context</param>
        /// <param name="attributetypes">Display type of attributes</param>
        /// <param name="convertqueries"></param>
        /// <param name="service"></param>
        public static void TraceContext(this ITracingService tracingservice, IPluginExecutionContext plugincontext, bool parentcontext, bool attributetypes, bool convertqueries, IOrganizationService service, bool isInput)
        {
            var input = isInput ? "Input" : "Output";

            //if (plugincontext.Stage != 30)
            //{
            tracingservice.Trace($"--- Context Trace {input} ---");
            tracingservice.Trace($"Message : {plugincontext.MessageName}");
            tracingservice.Trace($"Stage   : {plugincontext.Stage}");
            tracingservice.Trace($"Mode    : {plugincontext.Mode}");
            tracingservice.Trace($"Depth   : {plugincontext.Depth}");
            tracingservice.Trace($"Entity  : {plugincontext.PrimaryEntityName}");
            tracingservice.Trace($"UserId  : {plugincontext.UserId}");
            tracingservice.Trace($"InitiatingUserId  : {plugincontext.InitiatingUserId}");
            if (!plugincontext.PrimaryEntityId.Equals(Guid.Empty))
            {
                tracingservice.Trace($"Id      : {plugincontext.PrimaryEntityId}");
            }
            tracingservice.Trace("");

            tracingservice.TraceAndAlign("InputParameters", plugincontext.InputParameters, attributetypes, convertqueries, service);
            tracingservice.TraceAndAlign("OutputParameters", plugincontext.OutputParameters, attributetypes, convertqueries, service);
            tracingservice.TraceAndAlign("SharedVariables", plugincontext.SharedVariables, attributetypes, convertqueries, service);
            tracingservice.TraceAndAlign("PreEntityImages", plugincontext.PreEntityImages, attributetypes, convertqueries, service);
            tracingservice.TraceAndAlign("PostEntityImages", plugincontext.PostEntityImages, attributetypes, convertqueries, service);
            tracingservice.Trace("--- Context Trace End ---");
            //}
            if (parentcontext && plugincontext.ParentContext != null)
            {
                tracingservice.TraceContext(plugincontext.ParentContext, parentcontext, attributetypes, convertqueries, service, isInput);
            }
            tracingservice.Trace("");
        }

        public static void TraceAndAlign<T>(this ITracingService tracingservice, string topic, IEnumerable<KeyValuePair<string, T>> parametercollection, bool attributetypes, bool convertqueries, IOrganizationService service)
        {
            if (parametercollection == null || parametercollection.Count() == 0) { return; }
            tracingservice.Trace(topic);
            var keylen = parametercollection.Max(p => p.Key.Length);
            foreach (var parameter in parametercollection)
            {
                tracingservice.Trace($"  {parameter.Key}{new string(' ', keylen - parameter.Key.Length)} = {ValueToString(parameter.Value, attributetypes, convertqueries, service, 2)}");
            }
        }

        private static string ValueToString(object value, bool attributetypes, bool convertqueries, IOrganizationService service, int indent = 1)
        {
            var indentstring = new string(' ', indent * 2);
            var result = string.Empty;

            if (value == null)
            {
                return $"{indentstring}<null>";
            }
            else if (value is Entity entity)
            {
                var keylen = entity.Attributes.Count > 0
                    ? entity.Attributes.Max(p => p.Key.Length)
                    : 50;
                return $"{entity.LogicalName} {entity.Id}\n{indentstring}" + string.Join($"\n{indentstring}", entity.Attributes.OrderBy(a => a.Key).Select(a => $"{a.Key}{new string(' ', keylen - a.Key.Length)} = {ValueToString(a.Value, attributetypes, convertqueries, service, indent + 1)}"));
            }
            else if (value is ColumnSet columnset)
            {
                var columnlist = new List<string>(columnset.Columns);
                columnlist.Sort();
                return $"\n{indentstring}" + string.Join($"\n{indentstring}", columnlist);
            }
            else if (value is FetchExpression fetchexpression)
            {
                return $"{value}\n{indentstring}{fetchexpression.Query}";
            }
            else if (value is QueryExpression queryexpression && convertqueries && service != null)
            {
                var fetchxml = (service.Execute(new QueryExpressionToFetchXmlRequest { Query = queryexpression }) as QueryExpressionToFetchXmlResponse).FetchXml;
                return $"{queryexpression}\n{indentstring}{fetchxml}";
            }
            else if (value is EntityReference entityreference)
            {
                result = $"{entityreference.LogicalName} {entityreference.Id} {entityreference.Name}";
            }
            else if (value is OptionSetValue optionsetvalue)
            {
                result = optionsetvalue.Value.ToString();
            }
            else if (value is Money money)
            {
                result = money.Value.ToString();
            }
            else
            {
                result = value.ToString().Length > 100
                    ? value.ToString().Replace("\n", $"\n  {indentstring}").Substring(0, 100) + " [...]"
                    : value.ToString().Replace("\n", $"\n  {indentstring}");
            }
            return result + (attributetypes ? $" \t({value.GetType()})" : "");
        }
    }
}
