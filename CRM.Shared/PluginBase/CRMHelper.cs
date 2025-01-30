using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;


namespace CRM.Shared.PluginBase
{
    public static class CRMHelper
    {
        //Methods cross plugins
        //Example :
        public static QueryExpression GetRecordByAttribute(string name)
        {
            QueryExpression query = new QueryExpression("TABLE_NAME")
            {
                ColumnSet = new ColumnSet(false),

                Criteria = {
                    FilterOperator = LogicalOperator.And,
                    Filters = {
                        new FilterExpression{
                            FilterOperator = LogicalOperator.And,
                            Conditions = {
                                new ConditionExpression("ATTRIBUTE", ConditionOperator.Equal, name)
                            }
                        },
                    }
                }
            };
            return query;
        }
        public static QueryExpression GetUserByDomainName(string domaineName, string[] columns)
        {
            QueryExpression qe = new QueryExpression("systemuser")
            {
                ColumnSet = new ColumnSet(columns),
                Criteria = new FilterExpression
                {
                    Conditions =
                    {
                        new ConditionExpression("domainname", ConditionOperator.Equal, domaineName),
                        new ConditionExpression("isdisabled", ConditionOperator.Equal, false)
                    }
                },
            };
            return qe;
        }

        public static EntityReference GetOwnerOfRecord(ServiceProxy service, string entityName, Guid Id)
        {
            Entity retrieved = service.Retrieve(entityName, Id, new ColumnSet("ownerid"));
            return retrieved.GetAttributeValue<EntityReference>("ownerid");
        }
        public static EntityReference GetOwningBusinessUnitOfRecord(ServiceProxy service, string entityName, Guid Id)
        {
            Entity retrieved = service.Retrieve(entityName, Id, new ColumnSet("owningbusinessunit"));
            return retrieved.GetAttributeValue<EntityReference>("owningbusinessunit");
        }
    }
}
