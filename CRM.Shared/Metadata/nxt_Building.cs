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
/// <para>Display Name: Bâtiment</para>
/// </summary>
[EntityLogicalName("nxt_building")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract()]
public partial class nxt_Building : ExtendedEntity<nxt_BuildingState, nxt_Building_statuscode> {
    
    public const string EntityLogicalName = "nxt_building";
    
    public const int EntityTypeCode = 10677;
    
    public nxt_Building() : 
            base(EntityLogicalName) {
    }
    
    public nxt_Building(Guid Id) : 
            base(EntityLogicalName, Id) {
    }
    
    private string DebuggerDisplay {
        get {
            return GetDebuggerDisplay("nxt_reference");
        }
    }
    
    [AttributeLogicalName("nxt_buildingid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("nxt_buildingid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique des instances d'entité</para>
    /// <para>Display Name: Bâtiment</para>
    /// </summary>
    [AttributeLogicalName("nxt_buildingid")]
    [DisplayName("Bâtiment")]
    public Guid? nxt_BuildingId {
        get {
            return GetAttributeValue<Guid?>("nxt_buildingid");
        }
        set {
            SetId("nxt_buildingid", value);
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
    /// <para>Display Name: Référence</para>
    /// </summary>
    [AttributeLogicalName("nxt_reference")]
    [DisplayName("Référence")]
    [MaxLength(100)]
    public string PrimaryNameField {
        get {
            return GetAttributeValue<string>("nxt_reference");
        }
        set {
            SetAttributeValue("nxt_reference", value);
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
    /// <para>Display Name: Adresse : Typologie</para>
    /// </summary>
    [AttributeLogicalName("nxt_addresstypecode")]
    [DisplayName("Adresse : Typologie")]
    public nxt_addresstype? nxt_AddressTypeCode {
        get {
            return GetOptionSetValue<nxt_addresstype>("nxt_addresstypecode");
        }
        set {
            SetOptionSetValue("nxt_addresstypecode", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Adresse : Ville</para>
    /// </summary>
    [AttributeLogicalName("nxt_address_city")]
    [DisplayName("Adresse : Ville")]
    [MaxLength(100)]
    public string nxt_Address_City {
        get {
            return GetAttributeValue<string>("nxt_address_city");
        }
        set {
            SetAttributeValue("nxt_address_city", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Adresse : Pays</para>
    /// </summary>
    [AttributeLogicalName("nxt_address_country")]
    [DisplayName("Adresse : Pays")]
    [MaxLength(100)]
    public string nxt_Address_Country {
        get {
            return GetAttributeValue<string>("nxt_address_country");
        }
        set {
            SetAttributeValue("nxt_address_country", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Adresse : Numéro</para>
    /// </summary>
    [AttributeLogicalName("nxt_address_line1")]
    [DisplayName("Adresse : Numéro")]
    [MaxLength(100)]
    public string nxt_Address_Line1 {
        get {
            return GetAttributeValue<string>("nxt_address_line1");
        }
        set {
            SetAttributeValue("nxt_address_line1", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Adresse : Complément</para>
    /// </summary>
    [AttributeLogicalName("nxt_address_line2")]
    [DisplayName("Adresse : Complément")]
    [MaxLength(100)]
    public string nxt_Address_Line2 {
        get {
            return GetAttributeValue<string>("nxt_address_line2");
        }
        set {
            SetAttributeValue("nxt_address_line2", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Adresse : Rue</para>
    /// </summary>
    [AttributeLogicalName("nxt_address_line3")]
    [DisplayName("Adresse : Rue")]
    [MaxLength(100)]
    public string nxt_Address_Line3 {
        get {
            return GetAttributeValue<string>("nxt_address_line3");
        }
        set {
            SetAttributeValue("nxt_address_line3", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Adresse : Complément de nom</para>
    /// </summary>
    [AttributeLogicalName("nxt_address_name")]
    [DisplayName("Adresse : Complément de nom")]
    [MaxLength(100)]
    public string nxt_Address_Name {
        get {
            return GetAttributeValue<string>("nxt_address_name");
        }
        set {
            SetAttributeValue("nxt_address_name", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Adresse : Boite postale</para>
    /// </summary>
    [AttributeLogicalName("nxt_address_postofficebox")]
    [DisplayName("Adresse : Boite postale")]
    [MaxLength(100)]
    public string nxt_Address_PostOfficeBox {
        get {
            return GetAttributeValue<string>("nxt_address_postofficebox");
        }
        set {
            SetAttributeValue("nxt_address_postofficebox", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Adresse : Code postal</para>
    /// </summary>
    [AttributeLogicalName("nxt_address_postalcode")]
    [DisplayName("Adresse : Code postal")]
    [MaxLength(100)]
    public string nxt_Address_PostalCode {
        get {
            return GetAttributeValue<string>("nxt_address_postalcode");
        }
        set {
            SetAttributeValue("nxt_address_postalcode", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: N° Bâtiment</para>
    /// </summary>
    [AttributeLogicalName("nxt_buildingnumber")]
    [DisplayName("N° Bâtiment")]
    [MaxLength(100)]
    public string nxt_BuildingNumber {
        get {
            return GetAttributeValue<string>("nxt_buildingnumber");
        }
        set {
            SetAttributeValue("nxt_buildingnumber", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Ensemble Immobilier</para>
    /// </summary>
    [AttributeLogicalName("nxt_housingcomplexid")]
    [DisplayName("Ensemble Immobilier")]
    public EntityReference nxt_HousingComplexId {
        get {
            return GetAttributeValue<EntityReference>("nxt_housingcomplexid");
        }
        set {
            SetAttributeValue("nxt_housingcomplexid", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Id Sigeo</para>
    /// </summary>
    [AttributeLogicalName("nxt_idsigeo")]
    [DisplayName("Id Sigeo")]
    [MaxLength(100)]
    public string nxt_IdSigeo {
        get {
            return GetAttributeValue<string>("nxt_idsigeo");
        }
        set {
            SetAttributeValue("nxt_idsigeo", value);
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
    /// <para>Statut de l'élément Bâtiment</para>
    /// <para>Display Name: Statut</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Statut")]
    public nxt_BuildingState? statecode {
        get {
            return GetOptionSetValue<nxt_BuildingState>("statecode");
        }
        set {
            SetOptionSetValue("statecode", value);
        }
    }
    
    /// <summary>
    /// <para>Raison du statut de l'élément Bâtiment</para>
    /// <para>Display Name: Raison du statut</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Raison du statut")]
    public nxt_Building_statuscode? statuscode {
        get {
            return GetOptionSetValue<nxt_Building_statuscode>("statuscode");
        }
        set {
            SetOptionSetValue("statuscode", value);
        }
    }
    
    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_nxt_building")]
    public BusinessUnit business_unit_nxt_building {
        get {
            return GetRelatedEntity<BusinessUnit>("business_unit_nxt_building", null);
        }
        set {
            SetRelatedEntity("business_unit_nxt_building", null, value);
        }
    }
    
    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_nxt_building_createdby")]
    public SystemUser lk_nxt_building_createdby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_building_createdby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_building_createdby", null, value);
        }
    }
    
    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_nxt_building_createdonbehalfby")]
    public SystemUser lk_nxt_building_createdonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_building_createdonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_building_createdonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_nxt_building_modifiedby")]
    public SystemUser lk_nxt_building_modifiedby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_building_modifiedby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_building_modifiedby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_nxt_building_modifiedonbehalfby")]
    public SystemUser lk_nxt_building_modifiedonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_nxt_building_modifiedonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_nxt_building_modifiedonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("nxt_housingcomplexid")]
    [RelationshipSchemaName("nxt_nxt_building_HousingComplexId_nxt_housing")]
    public nxt_HousingComplex nxt_nxt_building_HousingComplexId_nxt_housing {
        get {
            return GetRelatedEntity<nxt_HousingComplex>("nxt_nxt_building_HousingComplexId_nxt_housing", null);
        }
        set {
            SetRelatedEntity("nxt_nxt_building_HousingComplexId_nxt_housing", null, value);
        }
    }
    
    [RelationshipSchemaName("nxt_nxt_lot_BuildingId_nxt_building")]
    public IEnumerable<nxt_Lot> nxt_nxt_lot_BuildingId_nxt_building {
        get {
            return GetRelatedEntities<nxt_Lot>("nxt_nxt_lot_BuildingId_nxt_building", null);
        }
        set {
            SetRelatedEntities("nxt_nxt_lot_BuildingId_nxt_building", null, value);
        }
    }
    
    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_nxt_building")]
    public Team team_nxt_building {
        get {
            return GetRelatedEntity<Team>("team_nxt_building", null);
        }
        set {
            SetRelatedEntity("team_nxt_building", null, value);
        }
    }
    
    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_nxt_building")]
    public SystemUser user_nxt_building {
        get {
            return GetRelatedEntity<SystemUser>("user_nxt_building", null);
        }
        set {
            SetRelatedEntity("user_nxt_building", null, value);
        }
    }
    
    public static nxt_Building Retrieve(IOrganizationService service, Guid id, params Expression<Func<nxt_Building,object>>[] attrs) {
        return service.Retrieve(id, attrs);
    }
}

[DataContract()]
public enum nxt_BuildingState {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=0, Lcid=1036)]
    Actif = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=1, Lcid=1036)]
    Inactif = 1,
}

[DataContract()]
public enum nxt_Building_statuscode {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=0, Lcid=1036)]
    Actif = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=1, Lcid=1036)]
    Inactif = 2,
}
