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
/// <para>Display Name: SLA Dossier</para>
/// </summary>
[EntityLogicalName("nxt_slacustomerfolder")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract()]
public partial class nxt_SLACustomerFolder : ExtendedEntity<nxt_SLACustomerFolderState, nxt_SLACustomerFolder_statuscode> {
    
    public const string EntityLogicalName = "nxt_slacustomerfolder";
    
    public const int EntityTypeCode = 10949;
    
    public nxt_SLACustomerFolder() : 
            base(EntityLogicalName) {
    }
    
    public nxt_SLACustomerFolder(Guid Id) : 
            base(EntityLogicalName, Id) {
    }
    
    private string DebuggerDisplay {
        get {
            return GetDebuggerDisplay("nxt_name");
        }
    }
    
    [AttributeLogicalName("nxt_slacustomerfolderid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("nxt_slacustomerfolderid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique des instances d'entité</para>
    /// <para>Display Name: SLA Dossier</para>
    /// </summary>
    [AttributeLogicalName("nxt_slacustomerfolderid")]
    [DisplayName("SLA Dossier")]
    public Guid? nxt_SLACustomerFolderId {
        get {
            return GetAttributeValue<Guid?>("nxt_slacustomerfolderid");
        }
        set {
            SetId("nxt_slacustomerfolderid", value);
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
    /// <para>Display Name: Nom de la règle</para>
    /// </summary>
    [AttributeLogicalName("nxt_name")]
    [DisplayName("Nom de la règle")]
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
    /// <para>Display Name: Statut Dossier Client</para>
    /// </summary>
    [AttributeLogicalName("nxt_customerfolderstatuscode")]
    [DisplayName("Statut Dossier Client")]
    public nxt_customerfolderstatus? nxt_CustomerFolderStatusCode {
        get {
            return GetOptionSetValue<nxt_customerfolderstatus>("nxt_customerfolderstatuscode");
        }
        set {
            SetOptionSetValue("nxt_customerfolderstatuscode", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Délai (en J)</para>
    /// </summary>
    [AttributeLogicalName("nxt_deadline")]
    [DisplayName("Délai (en J)")]
    [Range(-2147483648, 2147483647)]
    public int? nxt_Deadline {
        get {
            return GetAttributeValue<int?>("nxt_deadline");
        }
        set {
            SetAttributeValue("nxt_deadline", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Nom de la règle</para>
    /// </summary>
    [AttributeLogicalName("nxt_name")]
    [DisplayName("Nom de la règle")]
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
    /// <para>Display Name: Priorité</para>
    /// </summary>
    [AttributeLogicalName("nxt_prioritycode")]
    [DisplayName("Priorité")]
    public nxt_prioritycode? nxt_PriorityCode {
        get {
            return GetOptionSetValue<nxt_prioritycode>("nxt_prioritycode");
        }
        set {
            SetOptionSetValue("nxt_prioritycode", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Etat dossier</para>
    /// </summary>
    [AttributeLogicalName("nxt_stateid")]
    [DisplayName("Etat dossier")]
    public EntityReference nxt_StateId {
        get {
            return GetAttributeValue<EntityReference>("nxt_stateid");
        }
        set {
            SetAttributeValue("nxt_stateid", value);
        }
    }
    
    /// <summary>
    /// <para>Statut de l'élément SLA Dossier</para>
    /// <para>Display Name: Statut</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Statut")]
    public nxt_SLACustomerFolderState? statecode {
        get {
            return GetOptionSetValue<nxt_SLACustomerFolderState>("statecode");
        }
        set {
            SetOptionSetValue("statecode", value);
        }
    }
    
    /// <summary>
    /// <para>Raison du statut de l'élément SLA Dossier</para>
    /// <para>Display Name: Raison du statut</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Raison du statut")]
    public nxt_SLACustomerFolder_statuscode? statuscode {
        get {
            return GetOptionSetValue<nxt_SLACustomerFolder_statuscode>("statuscode");
        }
        set {
            SetOptionSetValue("statuscode", value);
        }
    }
    
    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_nxt_slacustomerfolder")]
    public BusinessUnit business_unit_nxt_slacustomerfolder {
        get {
            return GetRelatedEntity<BusinessUnit>("business_unit_nxt_slacustomerfolder", null);
        }
        set {
            SetRelatedEntity("business_unit_nxt_slacustomerfolder", null, value);
        }
    }
    
    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_nxt_slacustomerfolder_createdby")]
    public SystemUser lk_nxt_slacustomerfolder_createdby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_slacustomerfolder_createdby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_slacustomerfolder_createdby", null, value);
        }
    }
    
    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_nxt_slacustomerfolder_createdonbehalfby")]
    public SystemUser lk_nxt_slacustomerfolder_createdonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_slacustomerfolder_createdonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_slacustomerfolder_createdonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_nxt_slacustomerfolder_modifiedby")]
    public SystemUser lk_nxt_slacustomerfolder_modifiedby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_slacustomerfolder_modifiedby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_slacustomerfolder_modifiedby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_nxt_slacustomerfolder_modifiedonbehalfby")]
    public SystemUser lk_nxt_slacustomerfolder_modifiedonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_slacustomerfolder_modifiedonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_slacustomerfolder_modifiedonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_nxt_slacustomerfolder")]
    public Team team_nxt_slacustomerfolder {
        get {
            return GetRelatedEntity<Team>("team_nxt_slacustomerfolder", null);
        }
        set {
            SetRelatedEntity("team_nxt_slacustomerfolder", null, value);
        }
    }
    
    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_nxt_slacustomerfolder")]
    public SystemUser user_nxt_slacustomerfolder {
        get {
            return GetRelatedEntity<SystemUser>("user_nxt_slacustomerfolder", null);
        }
        set {
            SetRelatedEntity("user_nxt_slacustomerfolder", null, value);
        }
    }
    
    public static nxt_SLACustomerFolder Retrieve(IOrganizationService service, Guid id, params Expression<Func<nxt_SLACustomerFolder,object>>[] attrs) {
        return service.Retrieve(id, attrs);
    }
}

[DataContract()]
public enum nxt_SLACustomerFolderState {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=0, Lcid=1036)]
    Actif = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=1, Lcid=1036)]
    Inactif = 1,
}

[DataContract()]
public enum nxt_SLACustomerFolder_statuscode {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=0, Lcid=1036)]
    Actif = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=1, Lcid=1036)]
    Inactif = 2,
}
