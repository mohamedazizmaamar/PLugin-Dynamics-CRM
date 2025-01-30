using CRM.Shared.PluginBase.Extensions;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CRM.Shared.PluginBase
{
    public class ServiceProxy : IOrganizationService
    {
        public readonly IOrganizationService OrganizationService;
        private readonly ILocalContext LocalContext;
        public bool Verbose;

        public ServiceProxy(IOrganizationService service, ILocalContext localContext, bool verbose = false)
        {
            this.OrganizationService = service;
            this.LocalContext = localContext;
            this.Verbose = verbose;
        }

        public void Associate(string entityName, Guid entityId, Relationship relationship, EntityReferenceCollection relatedEntities)
        {
            LocalContext.Trace($"Associate({entityName}, {entityId}, {relationship.SchemaName}, {relatedEntities.Count})");
            if (Verbose)
            {
                LocalContext.Trace($"Associated record(s):{relatedEntities.Select(r => $"\n  {r.LogicalName} {r.Id} {r.Name}")}");
            }
            var watch = Stopwatch.StartNew();
            OrganizationService.Associate(entityName, entityId, relationship, relatedEntities);
            watch.Stop();
            LocalContext.Trace($"Associated in: {watch.ElapsedMilliseconds} ms");
        }

        public Guid Create(Entity entity)
        {
            LocalContext.Trace($"Create({entity.LogicalName}) {entity.Id} ({entity.Attributes.Count} attributes)");
            if (Verbose)
            {
                LocalContext.Trace($"\n{entity.ExtractAttributes(null)}");
            }
            var watch = Stopwatch.StartNew();
            var result = OrganizationService.Create(entity);
            watch.Stop();
            LocalContext.Trace($"Created in: {watch.ElapsedMilliseconds} ms");
            return result;
        }

        public void Delete(string entityName, Guid id)
        {
            LocalContext.Trace($"Delete({entityName}, {id})");
            var watch = Stopwatch.StartNew();
            OrganizationService.Delete(entityName, id);
            watch.Stop();
            LocalContext.Trace($"Deleted in: {watch.ElapsedMilliseconds} ms");
        }

        public void Disassociate(string entityName, Guid entityId, Relationship relationship, EntityReferenceCollection relatedEntities)
        {
            LocalContext.Trace($"Disassociate({entityName}, {entityId}, {relationship.SchemaName}, {relatedEntities.Count})");
            if (Verbose)
            {
                LocalContext.Trace($"Disassociated record(s):{relatedEntities.Select(r => $"\n  {r.LogicalName} {r.Id} {r.Name}")}");
            }
            var watch = Stopwatch.StartNew();
            OrganizationService.Disassociate(entityName, entityId, relationship, relatedEntities);
            watch.Stop();
            LocalContext.Trace($"Disassociated in: {watch.ElapsedMilliseconds} ms");
        }

        public OrganizationResponse Execute(OrganizationRequest request)
        {
            LocalContext.Trace($"Execute({request.RequestName})");
            if (Verbose && request is ExecuteFetchRequest)
            {
                LocalContext.Trace($"FetchXML: {((ExecuteFetchRequest)request).FetchXml}");
            }
            var watch = Stopwatch.StartNew();
            var result = OrganizationService.Execute(request);
            watch.Stop();
            LocalContext.Trace($"Executed in: {watch.ElapsedMilliseconds} ms");
            return result;
        }

        public Entity Retrieve(string entityName, Guid id, ColumnSet columnSet)
        {
            LocalContext.Trace($"Retrieve({entityName}, {id}, {columnSet.Columns.Count})");
            if (Verbose)
            {
                LocalContext.Trace($"Columns:{columnSet.Columns.Select(c => "\n  " + c)}");
            }
            var watch = Stopwatch.StartNew();
            var result = OrganizationService.Retrieve(entityName, id, columnSet);
            watch.Stop();
            LocalContext.Trace($"Retrieved in: {watch.ElapsedMilliseconds} ms");
            if (Verbose)
            {
                LocalContext.Trace($"Retrieved\n{result.ExtractAttributes(null)}");
            }
            return result;
        }

        public EntityCollection RetrieveMultiple(QueryBase query)
        {
            var fetchExpression = query is FetchExpression ? "fetchxml" : "unkstartn";
            var queryByAttribute = query is QueryByAttribute attribute ? attribute.EntityName : fetchExpression;
            var queryExpression = query is QueryExpression expression ? expression.EntityName : queryByAttribute;
            LocalContext.Trace($"RetrieveMultiple({queryExpression})");
            if (Verbose)
            {
                var fetch = ((QueryExpressionToFetchXmlResponse)LocalContext.Service.Execute(new QueryExpressionToFetchXmlRequest() { Query = query })).FetchXml;
                LocalContext.Trace($"Query: {fetch}");
            }
            var watch = Stopwatch.StartNew();
            var result = OrganizationService.RetrieveMultiple(query);
            watch.Stop();
            LocalContext.Trace($"Retrieved {result.Entities.Count} records in: {watch.ElapsedMilliseconds} ms");
            return result;
        }

        public List<Entity> RetrieveMultipleWithPaging(QueryExpression query)
        {
            query.PageInfo = new PagingInfo
            {
                PageNumber = 1
            };

            bool moreRecords = true;
            EntityCollection entityCollection;

            List<Entity> listOfEntities = new List<Entity>();

            while (moreRecords)
            {
                entityCollection = OrganizationService.RetrieveMultiple(query);
                foreach (Entity entity in entityCollection.Entities)
                {
                    listOfEntities.Add(entity);
                }
                moreRecords = entityCollection.MoreRecords;
                if (moreRecords)
                {
                    query.PageInfo.PageNumber++;
                }
            }
            LocalContext.Trace($"Number of records with paging : {listOfEntities.Count}");
            return listOfEntities;
        }

        public void Update(Entity entity)
        {
            LocalContext.Trace($"Update({entity.LogicalName}) {entity.Id} ({entity.Attributes.Count} attributes)");
            if (Verbose)
            {
                LocalContext.Trace($"\n{entity.ExtractAttributes(null)}");
            }
            var watch = Stopwatch.StartNew();
            OrganizationService.Update(entity);
            watch.Stop();
            LocalContext.Trace($"Updated in: {watch.ElapsedMilliseconds} ms");
        }
    }
}
