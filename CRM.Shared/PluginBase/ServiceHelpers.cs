using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CRM.Shared.PluginBase
{
    public static class ServiceHelpers
    {
        /// <summary>
        /// Gets a record of Environment parameter table
        /// </summary>
        /// <param name="service"></param>
        /// <param name="name">name of the parameter/param>
        public static string GetEnvironmentParameterValue(ServiceProxy service, string name)
        {
            XrmContextService xrm = new XrmContextService(service);
            string retrievedEnvParam = xrm.nxt_EnvironmentParameterSet
                .Where(p => p.nxt_Name == name)
                .Select(x => x.nxt_Value)
                .AsEnumerable().FirstOrDefault();
            return retrievedEnvParam;
        }

        /// <summary>
		/// Gets a list of records from the Environment variable table
		/// </summary>
		/// <param name="service"></param>
        /// <param name="schemaNames"></param>
        public static Dictionary<string, Entity> GetEnvironmentVariables(ServiceProxy service, string[] schemaNames)
        {
            QueryExpression query = new QueryExpression(EnvironmentVariableValue.EntityLogicalName)
            {
                ColumnSet = new ColumnSet("value")
            };
            LinkEntity linkToDefinition = new LinkEntity(
                EnvironmentVariableValue.EntityLogicalName,
                EnvironmentVariableDefinition.EntityLogicalName,
                "environmentvariabledefinitionid",
                "environmentvariabledefinitionid", JoinOperator.Inner)
            {
                Columns = new ColumnSet("schemaname", "type"),
                EntityAlias = "definition"
            };
            FilterExpression filter = new FilterExpression(LogicalOperator.Or);
            foreach (var schemaName in schemaNames)
            {
                filter.AddCondition("schemaname", ConditionOperator.Equal, schemaName);
            }
            linkToDefinition.LinkCriteria = filter;
            query.LinkEntities.Add(linkToDefinition);

            Dictionary<string, Entity> retrievedValues = service.RetrieveMultiple(query).Entities.Select(x =>
               new KeyValuePair<string, Entity>((string)x.GetAttributeValue<AliasedValue>("definition.schemaname")?.Value, x)).ToDictionary(v => v.Key, v => v.Value);

            foreach (var schemaName in schemaNames)
            {
                if (!retrievedValues.ContainsKey(schemaName))
                    throw new InvalidOperationException("No value retrieved for Environment Variable Definition with Name=" + schemaName);
            }
            return retrievedValues;
        }

        /// <summary>
        /// Gets the Access token for AAD.
        /// </summary>
        /// <param name="appClientId">App Registration Client Id</param>
        /// <param name="appClientSecret">App Registration Client Secret</param> 
        /// <returns></returns>
        public async static Task<string> GetToken(string appClientId, string appClientSecret, string scope = null)
        {
            string token;
            HttpClient httpClient = new HttpClient();
            if (!httpClient.DefaultRequestHeaders.Contains("Accept"))
            {
                httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            }
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type",  "client_credentials"),
                new KeyValuePair<string, string>("client_id", appClientId),
                new KeyValuePair<string, string>("client_secret", appClientSecret),
                new KeyValuePair<string, string>("scope", scope != null ? scope : $"api://{appClientId}/.default")
            });
            string tenantId = "a3c8d0af-358c-4fed-b0bf-73679c851aa0";
            string path = $"https://login.microsoftonline.com/{tenantId}/oauth2/v2.0/token";

            HttpResponseMessage response = await httpClient.PostAsync(path, formContent);

            if (response.IsSuccessStatusCode)
            {
                var tokenResponse = await response.Content.ReadAsStringAsync();

                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                string[] items = tokenResponse.TrimEnd(',').Split(',');

                foreach (string item in items)
                {
                    string[] keyValue = item.Split(new[] { ':' }, 2);
                    dictionary.Add(keyValue[0].TrimStart('{').Trim('"'), keyValue[1].TrimEnd('}').Trim('"'));
                }
                token = dictionary["access_token"].ToString().Trim();
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new InvalidOperationException(errorResponse);
            }
            return token;
        }

        public async static Task<string> GetTokenFromAccessCode(LocalPluginContext localPluginContext, string tenantId, string appClientId, string appClientSecret, string redirectUrl, string accessCode, string scope = null)
        {

            string token;
            HttpClient httpClient = new HttpClient();
            var formContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type",  "authorization_code"),
                new KeyValuePair<string, string>("client_id", appClientId),
                new KeyValuePair<string, string>("client_secret", appClientSecret),
                new KeyValuePair<string, string>("scope", scope ?? $"api://{appClientId}/.default"),
                new KeyValuePair<string, string>("code", accessCode),
                new KeyValuePair<string, string>("redirect_uri", redirectUrl),
            });
            string path = $"https://login.microsoftonline.com/{tenantId}/oauth2/v2.0/token";
            HttpResponseMessage response = await httpClient.PostAsync(path, formContent);

            if (response.IsSuccessStatusCode)
            {
                var tokenResponse = await response.Content.ReadAsStringAsync();

                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                string[] items = tokenResponse.TrimEnd(',').Split(',');

                foreach (string item in items)
                {
                    string[] keyValue = item.Split(new[] { ':' }, 2);
                    dictionary.Add(keyValue[0].TrimStart('{').Trim('"'), keyValue[1].TrimEnd('}').Trim('"'));
                }
                token = dictionary["access_token"].ToString().Trim();
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                localPluginContext.Trace(errorResponse);
                throw new InvalidPluginExecutionException(errorResponse);
            }
            return token;
        }
        /// <summary>
        /// Initialize HttpClient calls for API AAV
        /// </summary>
        /// <returns></returns>
        public static HttpClient InitHttpBearerAuth(string accessToken,
            string userUpn = null,
            string customerId = null,
            string customerKey = null)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
            httpClient.DefaultRequestHeaders.Add("User-Agent", "CRM");
            if (!string.IsNullOrEmpty(userUpn))
            {
                httpClient.DefaultRequestHeaders.Add("X-Trusted-User", userUpn);
            }

            if (!string.IsNullOrEmpty(customerId) && !string.IsNullOrEmpty(customerKey))
            {
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("x-customer-id", customerId);
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("x-customer-key", customerKey);
            }

            httpClient.DefaultRequestHeaders.Add("Connection", "keep-alive");

            return httpClient;
        }

        public async static Task<string> GetSecretFromKeyVault(ServiceProxy service, string keyName)
        {
            //Get environment variables
            Dictionary<string, Entity> environmentVariables = GetEnvironmentVariables(service, new string[] { EnvironmentVariable.nxt_KeyVaultAppId, EnvironmentVariable.nxt_KeyVaultEndpoint, EnvironmentVariable.nxt_KeyVaultApiVersion, EnvironmentVariable.nxt_KeyVaultScope });

            //Retrieve the KeyVault endpoint
            string endpoint = environmentVariables[EnvironmentVariable.nxt_KeyVaultEndpoint].ToEntity<EnvironmentVariableValue>().Value;

            //Retrieve the KeyVault endpoint
            string version = environmentVariables[EnvironmentVariable.nxt_KeyVaultApiVersion].ToEntity<EnvironmentVariableValue>().Value;

            //Retrieve the app id for KeyVault connexion
            string appId = environmentVariables[EnvironmentVariable.nxt_KeyVaultAppId].ToEntity<EnvironmentVariableValue>().Value;

            //Retrieve the app id for KeyVault connexion
            string scope = environmentVariables[EnvironmentVariable.nxt_KeyVaultScope].ToEntity<EnvironmentVariableValue>().Value;

            //Get the client secret for KeyVault connexion
            var appSecret = GetEnvironmentParameterValue(service, EnvironmentVariable.nxt_KeyVaultAppSecret)
                ?? throw new InvalidOperationException("The client secret was not found !");

            string accessToken = GetToken(appId, appSecret, scope).GetAwaiter().GetResult();

            // Initialize request
            HttpClient httpClient = InitHttpBearerAuth(accessToken);
            // Initialize link request
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(endpoint + $"/secrets/{keyName}?api-version={version}")
            };
            var response = httpClient.SendAsync(request).GetAwaiter().GetResult();
            var respContent = await response.Content.ReadAsStringAsync();
            var json = JsonConvert.DeserializeObject<Dictionary<string, object>>(respContent);

            json.TryGetValue("value", out object jsonValue);

            return jsonValue != null ? jsonValue.ToString() : null;
        }

        public static string GetSecret(ServiceProxy service, string keyName)
        {
            string secretFromKeyvault = GetSecretFromKeyVault(service, keyName).GetAwaiter().GetResult();
            if (string.IsNullOrEmpty(secretFromKeyvault))
            {
                secretFromKeyvault = GetEnvironmentParameterValue(service, keyName)
                ?? throw new InvalidOperationException("The client secret was not found !");
            }
            return secretFromKeyvault;
        }

        public static bool TryParseJson<T>(string errorContent, out T apiErrorResponse)
        {
            try
            {
                apiErrorResponse = JsonConvert.DeserializeObject<T>(errorContent);
                return true;
            }
            catch
            {
                apiErrorResponse = default(T);
                return false;
            }
        }
    }


}
