//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using DG.XrmContext;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;




/// <summary>
/// <para>Display Name: Tranche Commerciale</para>
/// </summary>
[EntityLogicalName("nxt_commercialphase")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract()]
public partial class nxt_CommercialPhase : ExtendedEntity<nxt_CommercialPhaseState, nxt_CommercialPhase_statuscode> {
    
    public const string EntityLogicalName = "nxt_commercialphase";
    
    public const int EntityTypeCode = 11270;
    
    public nxt_CommercialPhase() : 
            base(EntityLogicalName) {
    }
    
    public nxt_CommercialPhase(Guid Id) : 
            base(EntityLogicalName, Id) {
    }
    
    private string DebuggerDisplay {
        get {
            return GetDebuggerDisplay("nxt_commercialphaselabel");
        }
    }
    
    [AttributeLogicalName("nxt_commercialphaseid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("nxt_commercialphaseid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique des instances d'entité</para>
    /// <para>Display Name: Tranches Commerciales</para>
    /// </summary>
    [AttributeLogicalName("nxt_commercialphaseid")]
    [DisplayName("Tranches Commerciales")]
    public Guid? nxt_CommercialPhaseId {
        get {
            return GetAttributeValue<Guid?>("nxt_commercialphaseid");
        }
        set {
            SetId("nxt_commercialphaseid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'utilisateur ayant créé l'enregistrement.</para>
    /// <para>Display Name: Créé par</para>
    /// </summary>
    [AttributeLogicalName("createdby")]
    [DisplayName("Créé par")]
    public EntityReference CreatedBy {
        get {
            return GetAttributeValue<EntityReference>("createdby");
        }
    }
    
    /// <summary>
    /// <para>Date et heure de création de l'enregistrement.</para>
    /// <para>Display Name: Créé le</para>
    /// </summary>
    [AttributeLogicalName("createdon")]
    [DisplayName("Créé le")]
    public DateTime? CreatedOn {
        get {
            return GetAttributeValue<DateTime?>("createdon");
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'utilisateur délégué ayant créé l'enregistrement.</para>
    /// <para>Display Name: Créé par (délégué)</para>
    /// </summary>
    [AttributeLogicalName("createdonbehalfby")]
    [DisplayName("Créé par (délégué)")]
    public EntityReference CreatedOnBehalfBy {
        get {
            return GetAttributeValue<EntityReference>("createdonbehalfby");
        }
    }
    
    /// <summary>
    /// <para>Numéro séquentiel de l'importation ayant créé cet enregistrement.</para>
    /// <para>Display Name: Numéro séquentiel d’importation</para>
    /// </summary>
    [AttributeLogicalName("importsequencenumber")]
    [DisplayName("Numéro séquentiel d’importation")]
    [Range(-2147483648, 2147483647)]
    public int? ImportSequenceNumber {
        get {
            return GetAttributeValue<int?>("importsequencenumber");
        }
        set {
            SetAttributeValue("importsequencenumber", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'utilisateur ayant modifié l'enregistrement.</para>
    /// <para>Display Name: Modifié par</para>
    /// </summary>
    [AttributeLogicalName("modifiedby")]
    [DisplayName("Modifié par")]
    public EntityReference ModifiedBy {
        get {
            return GetAttributeValue<EntityReference>("modifiedby");
        }
    }
    
    /// <summary>
    /// <para>Date et heure de modification de l'enregistrement.</para>
    /// <para>Display Name: Modifié le</para>
    /// </summary>
    [AttributeLogicalName("modifiedon")]
    [DisplayName("Modifié le")]
    public DateTime? ModifiedOn {
        get {
            return GetAttributeValue<DateTime?>("modifiedon");
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'utilisateur délégué ayant modifié l'enregistrement.</para>
    /// <para>Display Name: Modifié par (délégué)</para>
    /// </summary>
    [AttributeLogicalName("modifiedonbehalfby")]
    [DisplayName("Modifié par (délégué)")]
    public EntityReference ModifiedOnBehalfBy {
        get {
            return GetAttributeValue<EntityReference>("modifiedonbehalfby");
        }
    }
    
    /// <summary>
    /// <para>Date et heure de migration de l'enregistrement.</para>
    /// <para>Display Name: Enregistrement créé le</para>
    /// </summary>
    [AttributeLogicalName("overriddencreatedon")]
    [DisplayName("Enregistrement créé le")]
    public DateTime? OverriddenCreatedOn {
        get {
            return GetAttributeValue<DateTime?>("overriddencreatedon");
        }
        set {
            SetAttributeValue("overriddencreatedon", value);
        }
    }
    
    /// <summary>
    /// <para>ID du propriétaire</para>
    /// <para>Display Name: Propriétaire</para>
    /// </summary>
    [AttributeLogicalName("ownerid")]
    [DisplayName("Propriétaire")]
    public EntityReference OwnerId {
        get {
            return GetAttributeValue<EntityReference>("ownerid");
        }
        set {
            SetAttributeValue("ownerid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de la division propriétaire de l'enregistrement</para>
    /// <para>Display Name: Division propriétaire</para>
    /// </summary>
    [AttributeLogicalName("owningbusinessunit")]
    [DisplayName("Division propriétaire")]
    public EntityReference OwningBusinessUnit {
        get {
            return GetAttributeValue<EntityReference>("owningbusinessunit");
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'équipe propriétaire de l'enregistrement.</para>
    /// <para>Display Name: Équipe propriétaire</para>
    /// </summary>
    [AttributeLogicalName("owningteam")]
    [DisplayName("Équipe propriétaire")]
    public EntityReference OwningTeam {
        get {
            return GetAttributeValue<EntityReference>("owningteam");
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'utilisateur propriétaire de l'enregistrement.</para>
    /// <para>Display Name: Utilisateur propriétaire</para>
    /// </summary>
    [AttributeLogicalName("owninguser")]
    [DisplayName("Utilisateur propriétaire")]
    public EntityReference OwningUser {
        get {
            return GetAttributeValue<EntityReference>("owninguser");
        }
    }
    
    /// <summary>
    /// <para>Display Name: Libellé Tranche commerciale</para>
    /// </summary>
    [AttributeLogicalName("nxt_commercialphaselabel")]
    [DisplayName("Libellé Tranche commerciale")]
    [MaxLength(100)]
    public string PrimaryNameField {
        get {
            return GetAttributeValue<string>("nxt_commercialphaselabel");
        }
        set {
            SetAttributeValue("nxt_commercialphaselabel", value);
        }
    }
    
    /// <summary>
    /// <para>Utilisation interne uniquement.</para>
    /// <para>Display Name: Numéro de version de la règle du fuseau horaire</para>
    /// </summary>
    [AttributeLogicalName("timezoneruleversionnumber")]
    [DisplayName("Numéro de version de la règle du fuseau horaire")]
    [Range(-1, 2147483647)]
    public int? TimeZoneRuleVersionNumber {
        get {
            return GetAttributeValue<int?>("timezoneruleversionnumber");
        }
        set {
            SetAttributeValue("timezoneruleversionnumber", value);
        }
    }
    
    /// <summary>
    /// <para>Code du fuseau horaire utilisé à la création de l'enregistrement.</para>
    /// <para>Display Name: Code de fuseau horaire pour la conversion UTC</para>
    /// </summary>
    [AttributeLogicalName("utcconversiontimezonecode")]
    [DisplayName("Code de fuseau horaire pour la conversion UTC")]
    [Range(-1, 2147483647)]
    public int? UTCConversionTimeZoneCode {
        get {
            return GetAttributeValue<int?>("utcconversiontimezonecode");
        }
        set {
            SetAttributeValue("utcconversiontimezonecode", value);
        }
    }
    
    /// <summary>
    /// <para>Numéro de version</para>
    /// <para>Display Name: Numéro de version</para>
    /// </summary>
    [AttributeLogicalName("versionnumber")]
    [DisplayName("Numéro de version")]
    public long? VersionNumber {
        get {
            return GetAttributeValue<long?>("versionnumber");
        }
    }
    
    /// <summary>
    /// <para>Display Name: Identifiant bloc</para>
    /// </summary>
    [AttributeLogicalName("nxt_blockid")]
    [DisplayName("Identifiant bloc")]
    [MaxLength(100)]
    public string nxt_BlockId {
        get {
            return GetAttributeValue<string>("nxt_blockid");
        }
        set {
            SetAttributeValue("nxt_blockid", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Code</para>
    /// </summary>
    [AttributeLogicalName("nxt_code")]
    [DisplayName("Code")]
    [MaxLength(100)]
    public string nxt_Code {
        get {
            return GetAttributeValue<string>("nxt_code");
        }
        set {
            SetAttributeValue("nxt_code", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Libellé Tranche commerciale</para>
    /// </summary>
    [AttributeLogicalName("nxt_commercialphaselabel")]
    [DisplayName("Libellé Tranche commerciale")]
    [MaxLength(100)]
    public string nxt_CommercialPhaseLabel {
        get {
            return GetAttributeValue<string>("nxt_commercialphaselabel");
        }
        set {
            SetAttributeValue("nxt_commercialphaselabel", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Dossier Client</para>
    /// </summary>
    [AttributeLogicalName("nxt_customerfolderid")]
    [DisplayName("Dossier Client")]
    public EntityReference nxt_CustomerFolderId {
        get {
            return GetAttributeValue<EntityReference>("nxt_customerfolderid");
        }
        set {
            SetAttributeValue("nxt_customerfolderid", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Date de livraison prévisionnelle</para>
    /// </summary>
    [AttributeLogicalName("nxt_expecteddeliverydate")]
    [DisplayName("Date de livraison prévisionnelle")]
    public DateTime? nxt_ExpectedDeliveryDate {
        get {
            return GetAttributeValue<DateTime?>("nxt_expecteddeliverydate");
        }
        set {
            SetAttributeValue("nxt_expecteddeliverydate", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Date de dernière visite chantier</para>
    /// </summary>
    [AttributeLogicalName("nxt_lastsitevisitdate")]
    [DisplayName("Date de dernière visite chantier")]
    public DateTime? nxt_LastSiteVisitDate {
        get {
            return GetAttributeValue<DateTime?>("nxt_lastsitevisitdate");
        }
        set {
            SetAttributeValue("nxt_lastsitevisitdate", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Date de pré-livraison</para>
    /// </summary>
    [AttributeLogicalName("nxt_predeliverydate")]
    [DisplayName("Date de pré-livraison")]
    public DateTime? nxt_PreDeliveryDate {
        get {
            return GetAttributeValue<DateTime?>("nxt_predeliverydate");
        }
        set {
            SetAttributeValue("nxt_predeliverydate", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Date de livraison réelle</para>
    /// </summary>
    [AttributeLogicalName("nxt_realdeliverydate")]
    [DisplayName("Date de livraison réelle")]
    public DateTime? nxt_RealDeliveryDate {
        get {
            return GetAttributeValue<DateTime?>("nxt_realdeliverydate");
        }
        set {
            SetAttributeValue("nxt_realdeliverydate", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Référence</para>
    /// </summary>
    [AttributeLogicalName("nxt_reference")]
    [DisplayName("Référence")]
    [MaxLength(100)]
    public string nxt_Reference {
        get {
            return GetAttributeValue<string>("nxt_reference");
        }
        set {
            SetAttributeValue("nxt_reference", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Date de levée totale de réserves</para>
    /// </summary>
    [AttributeLogicalName("nxt_totalreservationsliftingdate")]
    [DisplayName("Date de levée totale de réserves")]
    public DateTime? nxt_TotalReservationsLiftingDate {
        get {
            return GetAttributeValue<DateTime?>("nxt_totalreservationsliftingdate");
        }
        set {
            SetAttributeValue("nxt_totalreservationsliftingdate", value);
        }
    }
    
    /// <summary>
    /// <para>Statut de l'élément Tranches Commerciales</para>
    /// <para>Display Name: Statut</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Statut")]
    public nxt_CommercialPhaseState? statecode {
        get {
            return GetOptionSetValue<nxt_CommercialPhaseState>("statecode");
        }
        set {
            SetOptionSetValue("statecode", value);
        }
    }
    
    /// <summary>
    /// <para>Raison du statut de l'élément Tranches Commerciales</para>
    /// <para>Display Name: Raison du statut</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Raison du statut")]
    public nxt_CommercialPhase_statuscode? statuscode {
        get {
            return GetOptionSetValue<nxt_CommercialPhase_statuscode>("statuscode");
        }
        set {
            SetOptionSetValue("statuscode", value);
        }
    }
    
    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_nxt_commercialphase")]
    public BusinessUnit business_unit_nxt_commercialphase {
        get {
            return GetRelatedEntity<BusinessUnit>("business_unit_nxt_commercialphase", null);
        }
        set {
            SetRelatedEntity("business_unit_nxt_commercialphase", null, value);
        }
    }
    
    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_nxt_commercialphase_createdby")]
    public SystemUser lk_nxt_commercialphase_createdby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_commercialphase_createdby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_commercialphase_createdby", null, value);
        }
    }
    
    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_nxt_commercialphase_createdonbehalfby")]
    public SystemUser lk_nxt_commercialphase_createdonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_commercialphase_createdonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_commercialphase_createdonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_nxt_commercialphase_modifiedby")]
    public SystemUser lk_nxt_commercialphase_modifiedby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_commercialphase_modifiedby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_commercialphase_modifiedby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_nxt_commercialphase_modifiedonbehalfby")]
    public SystemUser lk_nxt_commercialphase_modifiedonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_commercialphase_modifiedonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_commercialphase_modifiedonbehalfby", null, value);
        }
    }
    
    [RelationshipSchemaName("nxt_commercialphase_connections1")]
    public IEnumerable<Connection> nxt_commercialphase_connections1 {
        get {
            return GetRelatedEntities<Connection>("nxt_commercialphase_connections1", null);
        }
        set {
            SetRelatedEntities("nxt_commercialphase_connections1", null, value);
        }
    }
    
    [RelationshipSchemaName("nxt_commercialphase_connections2")]
    public IEnumerable<Connection> nxt_commercialphase_connections2 {
        get {
            return GetRelatedEntities<Connection>("nxt_commercialphase_connections2", null);
        }
        set {
            SetRelatedEntities("nxt_commercialphase_connections2", null, value);
        }
    }
    
    [RelationshipSchemaName("nxt_incident_CommercialPhaseId_nxt_commercial")]
    public IEnumerable<Incident> nxt_incident_CommercialPhaseId_nxt_commercial {
        get {
            return GetRelatedEntities<Incident>("nxt_incident_CommercialPhaseId_nxt_commercial", null);
        }
        set {
            SetRelatedEntities("nxt_incident_CommercialPhaseId_nxt_commercial", null, value);
        }
    }
    
    [RelationshipSchemaName("nxt_invoice_CommercialPhaseId_nxt_commercialp")]
    public IEnumerable<Invoice> nxt_invoice_CommercialPhaseId_nxt_commercialp {
        get {
            return GetRelatedEntities<Invoice>("nxt_invoice_CommercialPhaseId_nxt_commercialp", null);
        }
        set {
            SetRelatedEntities("nxt_invoice_CommercialPhaseId_nxt_commercialp", null, value);
        }
    }
    
    [AttributeLogicalName("nxt_customerfolderid")]
    [RelationshipSchemaName("nxt_nxt_commercialphase_CustomerFolderId_nxt_")]
    public nxt_customerfolder nxt_nxt_commercialphase_CustomerFolderId_nxt_ {
        get {
            return GetRelatedEntity<nxt_customerfolder>("nxt_nxt_commercialphase_CustomerFolderId_nxt_", null);
        }
        set {
            SetRelatedEntity("nxt_nxt_commercialphase_CustomerFolderId_nxt_", null, value);
        }
    }
    
    [RelationshipSchemaName("nxt_quote_CommercialPhaseId_nxt_commercialpha")]
    public IEnumerable<Quote> nxt_quote_CommercialPhaseId_nxt_commercialpha {
        get {
            return GetRelatedEntities<Quote>("nxt_quote_CommercialPhaseId_nxt_commercialpha", null);
        }
        set {
            SetRelatedEntities("nxt_quote_CommercialPhaseId_nxt_commercialpha", null, value);
        }
    }
    
    [RelationshipSchemaName("nxt_salesorder_CommercialPhaseId_nxt_commerci")]
    public IEnumerable<SalesOrder> nxt_salesorder_CommercialPhaseId_nxt_commerci {
        get {
            return GetRelatedEntities<SalesOrder>("nxt_salesorder_CommercialPhaseId_nxt_commerci", null);
        }
        set {
            SetRelatedEntities("nxt_salesorder_CommercialPhaseId_nxt_commerci", null, value);
        }
    }
    
    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_nxt_commercialphase")]
    public Team team_nxt_commercialphase {
        get {
            return GetRelatedEntity<Team>("team_nxt_commercialphase", null);
        }
        set {
            SetRelatedEntity("team_nxt_commercialphase", null, value);
        }
    }
    
    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_nxt_commercialphase")]
    public SystemUser user_nxt_commercialphase {
        get {
            return GetRelatedEntity<SystemUser>("user_nxt_commercialphase", null);
        }
        set {
            SetRelatedEntity("user_nxt_commercialphase", null, value);
        }
    }
    
    public static nxt_CommercialPhase Retrieve(IOrganizationService service, Guid id, params Expression<Func<nxt_CommercialPhase,object>>[] attrs) {
        return service.Retrieve(id, attrs);
    }
    
    /// <summary>
    /// <para>Retrieves the record using the alternate key called 'AlternateKeyCodeCustomerFile'</para>
    /// </summary>
    public static nxt_CommercialPhase Retrieve_nxt_AlternateKeyCodeCustomerFile(IOrganizationService service, string nxt_Code, EntityReference nxt_CustomerFolderId, params Expression<Func<nxt_CommercialPhase,object>>[] attrs) {
        KeyAttributeCollection keys = new KeyAttributeCollection();
        keys.Add("nxt_code", nxt_Code);
        keys.Add("nxt_customerfolderid", nxt_CustomerFolderId);
        return Retrieve_AltKey(service, keys, attrs);
    }
    
    /// <summary>
    /// <para>Set values for the alternate key called 'AlternateKeyCodeCustomerFile'</para>
    /// </summary>
    public void AltKey_nxt_AlternateKeyCodeCustomerFile(string nxt_Code, EntityReference nxt_CustomerFolderId) {
        KeyAttributes.Clear();
        KeyAttributes.Add("nxt_code", nxt_Code);
        KeyAttributes.Add("nxt_customerfolderid", nxt_CustomerFolderId);
    }
}

[DataContract()]
public enum nxt_CommercialPhaseState {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=0, Lcid=1036)]
    Actif = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=1, Lcid=1036)]
    Inactif = 1,
}

[DataContract()]
public enum nxt_CommercialPhase_statuscode {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=0, Lcid=1036)]
    Actif = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=1, Lcid=1036)]
    Inactif = 2,
}
