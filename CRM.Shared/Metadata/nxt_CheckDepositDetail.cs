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
/// <para>Display Name: Détail Bordereau de chèque</para>
/// </summary>
[EntityLogicalName("nxt_checkdepositdetail")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract()]
public partial class nxt_CheckDepositDetail : ExtendedEntity<nxt_CheckDepositDetailState, nxt_CheckDepositDetail_statuscode> {
    
    public const string EntityLogicalName = "nxt_checkdepositdetail";
    
    public const int EntityTypeCode = 10971;
    
    public nxt_CheckDepositDetail() : 
            base(EntityLogicalName) {
    }
    
    public nxt_CheckDepositDetail(Guid Id) : 
            base(EntityLogicalName, Id) {
    }
    
    private string DebuggerDisplay {
        get {
            return GetDebuggerDisplay("nxt_name");
        }
    }
    
    [AttributeLogicalName("nxt_checkdepositdetailid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("nxt_checkdepositdetailid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique des instances d'entité</para>
    /// <para>Display Name: Détail Bordereau de chèque</para>
    /// </summary>
    [AttributeLogicalName("nxt_checkdepositdetailid")]
    [DisplayName("Détail Bordereau de chèque")]
    public Guid? nxt_CheckDepositDetailId {
        get {
            return GetAttributeValue<Guid?>("nxt_checkdepositdetailid");
        }
        set {
            SetId("nxt_checkdepositdetailid", value);
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
    /// <para>Taux de change pour la devise associée à l'entité, par rapport à la devise de base.</para>
    /// <para>Display Name: Taux de change</para>
    /// </summary>
    [AttributeLogicalName("exchangerate")]
    [DisplayName("Taux de change")]
    public decimal? ExchangeRate {
        get {
            return GetAttributeValue<decimal?>("exchangerate");
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
    /// <para>Display Name: Name</para>
    /// </summary>
    [AttributeLogicalName("nxt_name")]
    [DisplayName("Name")]
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
    /// <para>Identificateur unique de la devise associée à l'entité.</para>
    /// <para>Display Name: Devise</para>
    /// </summary>
    [AttributeLogicalName("transactioncurrencyid")]
    [DisplayName("Devise")]
    public EntityReference TransactionCurrencyId {
        get {
            return GetAttributeValue<EntityReference>("transactioncurrencyid");
        }
        set {
            SetAttributeValue("transactioncurrencyid", value);
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
    /// <para>Display Name: Provenance</para>
    /// </summary>
    [AttributeLogicalName("nxt_bankid")]
    [DisplayName("Provenance")]
    public EntityReference nxt_BankId {
        get {
            return GetAttributeValue<EntityReference>("nxt_bankid");
        }
        set {
            SetAttributeValue("nxt_bankid", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Imputation TMA</para>
    /// </summary>
    [AttributeLogicalName("nxt_buyeralterationcost")]
    [DisplayName("Imputation TMA")]
    public decimal? nxt_BuyerAlterationCost {
        get {
            return GetMoneyValue("nxt_buyeralterationcost");
        }
        set {
            SetMoneyValue("nxt_buyeralterationcost", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Montant Chèque</para>
    /// </summary>
    [AttributeLogicalName("nxt_checkamount")]
    [DisplayName("Montant Chèque")]
    public decimal? nxt_CheckAmount {
        get {
            return GetMoneyValue("nxt_checkamount");
        }
        set {
            SetMoneyValue("nxt_checkamount", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Bordereau de chèque</para>
    /// </summary>
    [AttributeLogicalName("nxt_checkdepositslipid")]
    [DisplayName("Bordereau de chèque")]
    public EntityReference nxt_CheckDepositSlipId {
        get {
            return GetAttributeValue<EntityReference>("nxt_checkdepositslipid");
        }
        set {
            SetAttributeValue("nxt_checkdepositslipid", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: N°Chèque</para>
    /// </summary>
    [AttributeLogicalName("nxt_checknumber")]
    [DisplayName("N°Chèque")]
    [MaxLength(100)]
    public string nxt_CheckNumber {
        get {
            return GetAttributeValue<string>("nxt_checknumber");
        }
        set {
            SetAttributeValue("nxt_checknumber", value);
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
    /// <para>Display Name: Imputation Apf</para>
    /// </summary>
    [AttributeLogicalName("nxt_fundingappealcost")]
    [DisplayName("Imputation Apf")]
    public decimal? nxt_FundingAppealCost {
        get {
            return GetMoneyValue("nxt_fundingappealcost");
        }
    }
    
    /// <summary>
    /// <para>Display Name: Envoyer vers AAV</para>
    /// </summary>
    [AttributeLogicalName("nxt_issenttoaav")]
    [DisplayName("Envoyer vers AAV")]
    public bool? nxt_IsSentToAav {
        get {
            return GetAttributeValue<bool?>("nxt_issenttoaav");
        }
        set {
            SetAttributeValue("nxt_issenttoaav", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Name</para>
    /// </summary>
    [AttributeLogicalName("nxt_name")]
    [DisplayName("Name")]
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
    /// <para>Display Name: Programme</para>
    /// </summary>
    [AttributeLogicalName("nxt_programid")]
    [DisplayName("Programme")]
    public EntityReference nxt_ProgramId {
        get {
            return GetAttributeValue<EntityReference>("nxt_programid");
        }
        set {
            SetAttributeValue("nxt_programid", value);
        }
    }
    
    /// <summary>
    /// <para>Valeur de Imputation TMA dans la devise de base.</para>
    /// <para>Display Name: Imputation TMA (de base)</para>
    /// </summary>
    [AttributeLogicalName("nxt_buyeralterationcost_base")]
    [DisplayName("Imputation TMA (de base)")]
    public decimal? nxt_buyeralterationcost_Base {
        get {
            return GetMoneyValue("nxt_buyeralterationcost_base");
        }
    }
    
    /// <summary>
    /// <para>Valeur de Montant Chèque dans la devise de base.</para>
    /// <para>Display Name: Montant Chèque (de base)</para>
    /// </summary>
    [AttributeLogicalName("nxt_checkamount_base")]
    [DisplayName("Montant Chèque (de base)")]
    public decimal? nxt_checkamount_Base {
        get {
            return GetMoneyValue("nxt_checkamount_base");
        }
    }
    
    /// <summary>
    /// <para>Valeur de Imputation Apf dans la devise de base.</para>
    /// <para>Display Name: Imputation Apf (de base)</para>
    /// </summary>
    [AttributeLogicalName("nxt_fundingappealcost_base")]
    [DisplayName("Imputation Apf (de base)")]
    public decimal? nxt_fundingappealcost_Base {
        get {
            return GetMoneyValue("nxt_fundingappealcost_base");
        }
    }
    
    /// <summary>
    /// <para>Statut de l'élément Détail Bordereau de chèque</para>
    /// <para>Display Name: Statut</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Statut")]
    public nxt_CheckDepositDetailState? statecode {
        get {
            return GetOptionSetValue<nxt_CheckDepositDetailState>("statecode");
        }
        set {
            SetOptionSetValue("statecode", value);
        }
    }
    
    /// <summary>
    /// <para>Raison du statut de l'élément Détail Bordereau de chèque</para>
    /// <para>Display Name: Raison du statut</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Raison du statut")]
    public nxt_CheckDepositDetail_statuscode? statuscode {
        get {
            return GetOptionSetValue<nxt_CheckDepositDetail_statuscode>("statuscode");
        }
        set {
            SetOptionSetValue("statuscode", value);
        }
    }
    
    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_nxt_checkdepositdetail")]
    public BusinessUnit business_unit_nxt_checkdepositdetail {
        get {
            return GetRelatedEntity<BusinessUnit>("business_unit_nxt_checkdepositdetail", null);
        }
        set {
            SetRelatedEntity("business_unit_nxt_checkdepositdetail", null, value);
        }
    }
    
    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_nxt_checkdepositdetail_createdby")]
    public SystemUser lk_nxt_checkdepositdetail_createdby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_checkdepositdetail_createdby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_checkdepositdetail_createdby", null, value);
        }
    }
    
    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_nxt_checkdepositdetail_createdonbehalfby")]
    public SystemUser lk_nxt_checkdepositdetail_createdonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_checkdepositdetail_createdonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_checkdepositdetail_createdonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_nxt_checkdepositdetail_modifiedby")]
    public SystemUser lk_nxt_checkdepositdetail_modifiedby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_checkdepositdetail_modifiedby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_checkdepositdetail_modifiedby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_nxt_checkdepositdetail_modifiedonbehalfby")]
    public SystemUser lk_nxt_checkdepositdetail_modifiedonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_checkdepositdetail_modifiedonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_checkdepositdetail_modifiedonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("nxt_checkdepositslipid")]
    [RelationshipSchemaName("nxt_nxt_checkdepositslip_nxt_checkdepositdetail_CheckDepositSlipId")]
    public nxt_CheckDepositSlip nxt_nxt_checkdepositslip_nxt_checkdepositdetail_CheckDepositSlipId {
        get {
            return GetRelatedEntity<nxt_CheckDepositSlip>("nxt_nxt_checkdepositslip_nxt_checkdepositdetail_CheckDepositSlipId", null);
        }
        set {
            SetRelatedEntity("nxt_nxt_checkdepositslip_nxt_checkdepositdetail_CheckDepositSlipId", null, value);
        }
    }
    
    [AttributeLogicalName("nxt_customerfolderid")]
    [RelationshipSchemaName("nxt_nxt_customerfolder_nxt_checkdepositdetail_CustomerFolderId")]
    public nxt_customerfolder nxt_nxt_customerfolder_nxt_checkdepositdetail_CustomerFolderId {
        get {
            return GetRelatedEntity<nxt_customerfolder>("nxt_nxt_customerfolder_nxt_checkdepositdetail_CustomerFolderId", null);
        }
        set {
            SetRelatedEntity("nxt_nxt_customerfolder_nxt_checkdepositdetail_CustomerFolderId", null, value);
        }
    }
    
    [AttributeLogicalName("nxt_programid")]
    [RelationshipSchemaName("nxt_nxt_program_nxt_checkdepositdetail_ProgramId")]
    public nxt_Program nxt_nxt_program_nxt_checkdepositdetail_ProgramId {
        get {
            return GetRelatedEntity<nxt_Program>("nxt_nxt_program_nxt_checkdepositdetail_ProgramId", null);
        }
        set {
            SetRelatedEntity("nxt_nxt_program_nxt_checkdepositdetail_ProgramId", null, value);
        }
    }
    
    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_nxt_checkdepositdetail")]
    public Team team_nxt_checkdepositdetail {
        get {
            return GetRelatedEntity<Team>("team_nxt_checkdepositdetail", null);
        }
        set {
            SetRelatedEntity("team_nxt_checkdepositdetail", null, value);
        }
    }
    
    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_nxt_checkdepositdetail")]
    public SystemUser user_nxt_checkdepositdetail {
        get {
            return GetRelatedEntity<SystemUser>("user_nxt_checkdepositdetail", null);
        }
        set {
            SetRelatedEntity("user_nxt_checkdepositdetail", null, value);
        }
    }
    
    public static nxt_CheckDepositDetail Retrieve(IOrganizationService service, Guid id, params Expression<Func<nxt_CheckDepositDetail,object>>[] attrs) {
        return service.Retrieve(id, attrs);
    }
}

[DataContract()]
public enum nxt_CheckDepositDetailState {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=0, Lcid=1036)]
    Actif = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=1, Lcid=1036)]
    Inactif = 1,
}

[DataContract()]
public enum nxt_CheckDepositDetail_statuscode {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=0, Lcid=1036)]
    Actif = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=1, Lcid=1036)]
    Inactif = 2,
}
