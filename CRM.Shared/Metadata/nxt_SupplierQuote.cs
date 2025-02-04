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
/// <para>Display Name: Devis Fournisseur</para>
/// </summary>
[EntityLogicalName("nxt_supplierquote")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract()]
public partial class nxt_SupplierQuote : ExtendedEntity<nxt_SupplierQuoteState, nxt_SupplierQuote_statuscode> {
    
    public const string EntityLogicalName = "nxt_supplierquote";
    
    public const int EntityTypeCode = 10681;
    
    public nxt_SupplierQuote() : 
            base(EntityLogicalName) {
    }
    
    public nxt_SupplierQuote(Guid Id) : 
            base(EntityLogicalName, Id) {
    }
    
    private string DebuggerDisplay {
        get {
            return GetDebuggerDisplay("nxt_name");
        }
    }
    
    [AttributeLogicalName("nxt_supplierquoteid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("nxt_supplierquoteid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique des instances d'entité</para>
    /// <para>Display Name: Devis Fournisseur</para>
    /// </summary>
    [AttributeLogicalName("nxt_supplierquoteid")]
    [DisplayName("Devis Fournisseur")]
    public Guid? nxt_SupplierQuoteId {
        get {
            return GetAttributeValue<Guid?>("nxt_supplierquoteid");
        }
        set {
            SetId("nxt_supplierquoteid", value);
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
        set {
            SetAttributeValue("createdby", value);
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
        set {
            SetAttributeValue("createdon", value);
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
        set {
            SetAttributeValue("createdonbehalfby", value);
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
        set {
            SetAttributeValue("modifiedby", value);
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
        set {
            SetAttributeValue("modifiedon", value);
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
        set {
            SetAttributeValue("modifiedonbehalfby", value);
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
    /// <para>Display Name: Nom</para>
    /// </summary>
    [AttributeLogicalName("nxt_name")]
    [DisplayName("Nom")]
    [MaxLength(100)]
    public string PrimaryNameField {
        get {
            return GetAttributeValue<string>("nxt_name");
        }
        set {
            SetAttributeValue("nxt_name", value);
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
    /// <para>Display Name: Fournisseur</para>
    /// </summary>
    [AttributeLogicalName("nxt_accountid")]
    [DisplayName("Fournisseur")]
    public EntityReference nxt_AccountId {
        get {
            return GetAttributeValue<EntityReference>("nxt_accountid");
        }
        set {
            SetAttributeValue("nxt_accountid", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Demande liée</para>
    /// </summary>
    [AttributeLogicalName("nxt_incidentid")]
    [DisplayName("Demande liée")]
    public EntityReference nxt_IncidentId {
        get {
            return GetAttributeValue<EntityReference>("nxt_incidentid");
        }
        set {
            SetAttributeValue("nxt_incidentid", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Date limite de réponse dépassée</para>
    /// </summary>
    [AttributeLogicalName("nxt_isresponselimitdatepassed")]
    [DisplayName("Date limite de réponse dépassée")]
    public bool? nxt_IsResponseLimitDatePassed {
        get {
            return GetAttributeValue<bool?>("nxt_isresponselimitdatepassed");
        }
        set {
            SetAttributeValue("nxt_isresponselimitdatepassed", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Date de dernière relance</para>
    /// </summary>
    [AttributeLogicalName("nxt_lastresubmissiondate")]
    [DisplayName("Date de dernière relance")]
    public DateTime? nxt_LastResubmissionDate {
        get {
            return GetAttributeValue<DateTime?>("nxt_lastresubmissiondate");
        }
        set {
            SetAttributeValue("nxt_lastresubmissiondate", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Nom</para>
    /// </summary>
    [AttributeLogicalName("nxt_name")]
    [DisplayName("Nom")]
    [MaxLength(100)]
    public string nxt_Name {
        get {
            return GetAttributeValue<string>("nxt_name");
        }
        set {
            SetAttributeValue("nxt_name", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Date limite de réponse</para>
    /// </summary>
    [AttributeLogicalName("nxt_responselimitdate")]
    [DisplayName("Date limite de réponse")]
    public DateTime? nxt_ResponseLimitDate {
        get {
            return GetAttributeValue<DateTime?>("nxt_responselimitdate");
        }
        set {
            SetAttributeValue("nxt_responselimitdate", value);
        }
    }
    
    /// <summary>
    /// <para>Statut de l'élément Devis Fournisseur</para>
    /// <para>Display Name: Statut</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Statut")]
    public nxt_SupplierQuoteState? statecode {
        get {
            return GetOptionSetValue<nxt_SupplierQuoteState>("statecode");
        }
        set {
            SetOptionSetValue("statecode", value);
        }
    }
    
    /// <summary>
    /// <para>Raison du statut de l'élément Devis Fournisseur</para>
    /// <para>Display Name: Statut</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Statut")]
    public nxt_SupplierQuote_statuscode? statuscode {
        get {
            return GetOptionSetValue<nxt_SupplierQuote_statuscode>("statuscode");
        }
        set {
            SetOptionSetValue("statuscode", value);
        }
    }
    
    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_nxt_supplierquote")]
    public BusinessUnit business_unit_nxt_supplierquote {
        get {
            return GetRelatedEntity<BusinessUnit>("business_unit_nxt_supplierquote", null);
        }
        set {
            SetRelatedEntity("business_unit_nxt_supplierquote", null, value);
        }
    }
    
    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_nxt_supplierquote_createdby")]
    public SystemUser lk_nxt_supplierquote_createdby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_supplierquote_createdby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_supplierquote_createdby", null, value);
        }
    }
    
    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_nxt_supplierquote_createdonbehalfby")]
    public SystemUser lk_nxt_supplierquote_createdonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_supplierquote_createdonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_supplierquote_createdonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_nxt_supplierquote_modifiedby")]
    public SystemUser lk_nxt_supplierquote_modifiedby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_supplierquote_modifiedby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_supplierquote_modifiedby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_nxt_supplierquote_modifiedonbehalfby")]
    public SystemUser lk_nxt_supplierquote_modifiedonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_supplierquote_modifiedonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_supplierquote_modifiedonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("nxt_accountid")]
    [RelationshipSchemaName("nxt_nxt_supplierquote_AccountId_account")]
    public Account nxt_nxt_supplierquote_AccountId_account {
        get {
            return GetRelatedEntity<Account>("nxt_nxt_supplierquote_AccountId_account", null);
        }
        set {
            SetRelatedEntity("nxt_nxt_supplierquote_AccountId_account", null, value);
        }
    }
    
    [AttributeLogicalName("nxt_incidentid")]
    [RelationshipSchemaName("nxt_nxt_supplierquote_IncidentId_incident")]
    public Incident nxt_nxt_supplierquote_IncidentId_incident {
        get {
            return GetRelatedEntity<Incident>("nxt_nxt_supplierquote_IncidentId_incident", null);
        }
        set {
            SetRelatedEntity("nxt_nxt_supplierquote_IncidentId_incident", null, value);
        }
    }
    
    [RelationshipSchemaName("nxt_supplierquote_Emails")]
    public IEnumerable<Email> nxt_supplierquote_Emails {
        get {
            return GetRelatedEntities<Email>("nxt_supplierquote_Emails", null);
        }
        set {
            SetRelatedEntities("nxt_supplierquote_Emails", null, value);
        }
    }
    
    [RelationshipSchemaName("nxt_supplierquote_PhoneCalls")]
    public IEnumerable<PhoneCall> nxt_supplierquote_PhoneCalls {
        get {
            return GetRelatedEntities<PhoneCall>("nxt_supplierquote_PhoneCalls", null);
        }
        set {
            SetRelatedEntities("nxt_supplierquote_PhoneCalls", null, value);
        }
    }
    
    [RelationshipSchemaName("nxt_supplierquote_nxt_Messages")]
    public IEnumerable<nxt_Message> nxt_supplierquote_nxt_Messages {
        get {
            return GetRelatedEntities<nxt_Message>("nxt_supplierquote_nxt_Messages", null);
        }
        set {
            SetRelatedEntities("nxt_supplierquote_nxt_Messages", null, value);
        }
    }
    
    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_nxt_supplierquote")]
    public Team team_nxt_supplierquote {
        get {
            return GetRelatedEntity<Team>("team_nxt_supplierquote", null);
        }
        set {
            SetRelatedEntity("team_nxt_supplierquote", null, value);
        }
    }
    
    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_nxt_supplierquote")]
    public SystemUser user_nxt_supplierquote {
        get {
            return GetRelatedEntity<SystemUser>("user_nxt_supplierquote", null);
        }
        set {
            SetRelatedEntity("user_nxt_supplierquote", null, value);
        }
    }
    
    public static nxt_SupplierQuote Retrieve(IOrganizationService service, Guid id, params Expression<Func<nxt_SupplierQuote,object>>[] attrs) {
        return service.Retrieve(id, attrs);
    }
}

[DataContract()]
public enum nxt_SupplierQuoteState {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=0, Lcid=1036)]
    Actif = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=1, Lcid=1036)]
    Inactif = 1,
}

[DataContract()]
public enum nxt_SupplierQuote_statuscode {
    
    [EnumMember()]
    [OptionSetMetadata("Devis envoyé", Index=0, Lcid=1036, Description="")]
    Devisenvoyé = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=1, Lcid=1036)]
    Inactif = 2,
    
    [EnumMember()]
    [OptionSetMetadata("En attente nouveau devis", Index=2, Lcid=1036, Description="")]
    Enattentenouveaudevis = 3,
    
    [EnumMember()]
    [OptionSetMetadata("En validation", Index=3, Lcid=1036, Description="")]
    Envalidation = 4,
    
    [EnumMember()]
    [OptionSetMetadata("Devis validé", Index=4, Lcid=1036, Description="")]
    Devisvalidé = 5,
    
    [EnumMember()]
    [OptionSetMetadata("Devis annulé", Index=5, Lcid=1036, Description="")]
    Devisannulé = 6,
    
    [EnumMember()]
    [OptionSetMetadata("Devis refusé", Index=6, Lcid=1036, Description="")]
    Devisrefusé = 7,
}
