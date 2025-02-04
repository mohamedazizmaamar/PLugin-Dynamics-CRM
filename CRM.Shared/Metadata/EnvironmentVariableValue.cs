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
/// <para>Holds the value for the associated EnvironmentVariableDefinition entity.</para>
/// <para>Display Name: Environment Variable Value</para>
/// </summary>
[EntityLogicalName("environmentvariablevalue")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract()]
public partial class EnvironmentVariableValue : ExtendedEntity<EnvironmentVariableValueState, EnvironmentVariableValue_statuscode> {
    
    public const string EntityLogicalName = "environmentvariablevalue";
    
    public const int EntityTypeCode = 381;
    
    public EnvironmentVariableValue() : 
            base(EntityLogicalName) {
    }
    
    public EnvironmentVariableValue(Guid Id) : 
            base(EntityLogicalName, Id) {
    }
    
    private string DebuggerDisplay {
        get {
            return GetDebuggerDisplay("schemaname");
        }
    }
    
    [AttributeLogicalName("environmentvariablevalueid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("environmentvariablevalueid", value);
        }
    }
    
    /// <summary>
    /// <para>Unique identifier for entity instances</para>
    /// <para>Display Name: Environment Variable Value</para>
    /// </summary>
    [AttributeLogicalName("environmentvariablevalueid")]
    [DisplayName("Environment Variable Value")]
    public Guid? EnvironmentVariableValueId {
        get {
            return GetAttributeValue<Guid?>("environmentvariablevalueid");
        }
        set {
            SetId("environmentvariablevalueid", value);
        }
    }
    
    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Component State</para>
    /// </summary>
    [AttributeLogicalName("componentstate")]
    [DisplayName("Component State")]
    public componentstate? ComponentState {
        get {
            return GetOptionSetValue<componentstate>("componentstate");
        }
    }
    
    /// <summary>
    /// <para>Unique identifier of the user who created the record.</para>
    /// <para>Display Name: Created By</para>
    /// </summary>
    [AttributeLogicalName("createdby")]
    [DisplayName("Created By")]
    public EntityReference CreatedBy {
        get {
            return GetAttributeValue<EntityReference>("createdby");
        }
    }
    
    /// <summary>
    /// <para>Date and time when the record was created.</para>
    /// <para>Display Name: Created On</para>
    /// </summary>
    [AttributeLogicalName("createdon")]
    [DisplayName("Created On")]
    public DateTime? CreatedOn {
        get {
            return GetAttributeValue<DateTime?>("createdon");
        }
    }
    
    /// <summary>
    /// <para>Unique identifier of the delegate user who created the record.</para>
    /// <para>Display Name: Created By (Delegate)</para>
    /// </summary>
    [AttributeLogicalName("createdonbehalfby")]
    [DisplayName("Created By (Delegate)")]
    public EntityReference CreatedOnBehalfBy {
        get {
            return GetAttributeValue<EntityReference>("createdonbehalfby");
        }
    }
    
    /// <summary>
    /// <para>Unique identifier for Environment Variable Definition associated with Environment Variable Value.</para>
    /// <para>Display Name: Environment Variable Definition</para>
    /// </summary>
    [AttributeLogicalName("environmentvariabledefinitionid")]
    [DisplayName("Environment Variable Definition")]
    public EntityReference EnvironmentVariableDefinitionId {
        get {
            return GetAttributeValue<EntityReference>("environmentvariabledefinitionid");
        }
        set {
            SetAttributeValue("environmentvariabledefinitionid", value);
        }
    }
    
    /// <summary>
    /// <para>For internal use only.</para>
    /// </summary>
    [AttributeLogicalName("environmentvariablevalueidunique")]
    public Guid? EnvironmentVariableValueIdUnique {
        get {
            return GetAttributeValue<Guid?>("environmentvariablevalueidunique");
        }
    }
    
    /// <summary>
    /// <para>Sequence number of the import that created this record.</para>
    /// <para>Display Name: Import Sequence Number</para>
    /// </summary>
    [AttributeLogicalName("importsequencenumber")]
    [DisplayName("Import Sequence Number")]
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
    /// <para>Version in which the form is introduced.</para>
    /// <para>Display Name: Introduced Version</para>
    /// </summary>
    [AttributeLogicalName("introducedversion")]
    [DisplayName("Introduced Version")]
    [MaxLength(48)]
    public string IntroducedVersion {
        get {
            return GetAttributeValue<string>("introducedversion");
        }
        set {
            SetAttributeValue("introducedversion", value);
        }
    }
    
    /// <summary>
    /// <para>Tells whether the component can be customized.</para>
    /// <para>Display Name: Customizable</para>
    /// </summary>
    [AttributeLogicalName("iscustomizable")]
    [DisplayName("Customizable")]
    public BooleanManagedProperty IsCustomizable {
        get {
            return GetAttributeValue<BooleanManagedProperty>("iscustomizable");
        }
        set {
            SetAttributeValue("iscustomizable", value);
        }
    }
    
    /// <summary>
    /// <para>Indicates whether the solution component is part of a managed solution.</para>
    /// <para>Display Name: Is Managed</para>
    /// </summary>
    [AttributeLogicalName("ismanaged")]
    [DisplayName("Is Managed")]
    public bool? IsManaged {
        get {
            return GetAttributeValue<bool?>("ismanaged");
        }
    }
    
    /// <summary>
    /// <para>Unique identifier of the user who modified the record.</para>
    /// <para>Display Name: Modified By</para>
    /// </summary>
    [AttributeLogicalName("modifiedby")]
    [DisplayName("Modified By")]
    public EntityReference ModifiedBy {
        get {
            return GetAttributeValue<EntityReference>("modifiedby");
        }
    }
    
    /// <summary>
    /// <para>Date and time when the record was modified.</para>
    /// <para>Display Name: Modified On</para>
    /// </summary>
    [AttributeLogicalName("modifiedon")]
    [DisplayName("Modified On")]
    public DateTime? ModifiedOn {
        get {
            return GetAttributeValue<DateTime?>("modifiedon");
        }
    }
    
    /// <summary>
    /// <para>Unique identifier of the delegate user who modified the record.</para>
    /// <para>Display Name: Modified By (Delegate)</para>
    /// </summary>
    [AttributeLogicalName("modifiedonbehalfby")]
    [DisplayName("Modified By (Delegate)")]
    public EntityReference ModifiedOnBehalfBy {
        get {
            return GetAttributeValue<EntityReference>("modifiedonbehalfby");
        }
    }
    
    /// <summary>
    /// <para>Date and time that the record was migrated.</para>
    /// <para>Display Name: Record Created On</para>
    /// </summary>
    [AttributeLogicalName("overriddencreatedon")]
    [DisplayName("Record Created On")]
    public DateTime? OverriddenCreatedOn {
        get {
            return GetAttributeValue<DateTime?>("overriddencreatedon");
        }
        set {
            SetAttributeValue("overriddencreatedon", value);
        }
    }
    
    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Record Overwrite Time</para>
    /// </summary>
    [AttributeLogicalName("overwritetime")]
    [DisplayName("Record Overwrite Time")]
    public DateTime? OverwriteTime {
        get {
            return GetAttributeValue<DateTime?>("overwritetime");
        }
    }
    
    /// <summary>
    /// <para>Owner Id</para>
    /// <para>Display Name: Owner</para>
    /// </summary>
    [AttributeLogicalName("ownerid")]
    [DisplayName("Owner")]
    public EntityReference OwnerId {
        get {
            return GetAttributeValue<EntityReference>("ownerid");
        }
        set {
            SetAttributeValue("ownerid", value);
        }
    }
    
    /// <summary>
    /// <para>Unique identifier for the business unit that owns the record</para>
    /// <para>Display Name: Owning Business Unit</para>
    /// </summary>
    [AttributeLogicalName("owningbusinessunit")]
    [DisplayName("Owning Business Unit")]
    public EntityReference OwningBusinessUnit {
        get {
            return GetAttributeValue<EntityReference>("owningbusinessunit");
        }
    }
    
    /// <summary>
    /// <para>Unique identifier for the team that owns the record.</para>
    /// <para>Display Name: Owning Team</para>
    /// </summary>
    [AttributeLogicalName("owningteam")]
    [DisplayName("Owning Team")]
    public EntityReference OwningTeam {
        get {
            return GetAttributeValue<EntityReference>("owningteam");
        }
    }
    
    /// <summary>
    /// <para>Unique identifier for the user that owns the record.</para>
    /// <para>Display Name: Owning User</para>
    /// </summary>
    [AttributeLogicalName("owninguser")]
    [DisplayName("Owning User")]
    public EntityReference OwningUser {
        get {
            return GetAttributeValue<EntityReference>("owninguser");
        }
    }
    
    /// <summary>
    /// <para>Unique entity name.</para>
    /// <para>Display Name: Schema Name</para>
    /// </summary>
    [AttributeLogicalName("schemaname")]
    [DisplayName("Schema Name")]
    [MaxLength(100)]
    public string PrimaryNameField {
        get {
            return GetAttributeValue<string>("schemaname");
        }
        set {
            SetAttributeValue("schemaname", value);
        }
    }
    
    /// <summary>
    /// <para>Unique entity name.</para>
    /// <para>Display Name: Schema Name</para>
    /// </summary>
    [AttributeLogicalName("schemaname")]
    [DisplayName("Schema Name")]
    [MaxLength(100)]
    public string SchemaName {
        get {
            return GetAttributeValue<string>("schemaname");
        }
        set {
            SetAttributeValue("schemaname", value);
        }
    }
    
    /// <summary>
    /// <para>Unique identifier of the associated solution.</para>
    /// <para>Display Name: Solution</para>
    /// </summary>
    [AttributeLogicalName("solutionid")]
    [DisplayName("Solution")]
    public Guid? SolutionId {
        get {
            return GetAttributeValue<Guid?>("solutionid");
        }
    }
    
    /// <summary>
    /// <para>For internal use only.</para>
    /// <para>Display Name: Time Zone Rule Version Number</para>
    /// </summary>
    [AttributeLogicalName("timezoneruleversionnumber")]
    [DisplayName("Time Zone Rule Version Number")]
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
    /// <para>Time zone code that was in use when the record was created.</para>
    /// <para>Display Name: UTC Conversion Time Zone Code</para>
    /// </summary>
    [AttributeLogicalName("utcconversiontimezonecode")]
    [DisplayName("UTC Conversion Time Zone Code")]
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
    /// <para>Contains the actual variable data.</para>
    /// <para>Display Name: Value</para>
    /// </summary>
    [AttributeLogicalName("value")]
    [DisplayName("Value")]
    public string Value {
        get {
            return GetAttributeValue<string>("value");
        }
        set {
            SetAttributeValue("value", value);
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
    /// <para>Status of the Environment Variable Value</para>
    /// <para>Display Name: Status</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Status")]
    public EnvironmentVariableValueState? statecode {
        get {
            return GetOptionSetValue<EnvironmentVariableValueState>("statecode");
        }
        set {
            SetOptionSetValue("statecode", value);
        }
    }
    
    /// <summary>
    /// <para>Reason for the status of the Environment Variable Value</para>
    /// <para>Display Name: Status Reason</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Status Reason")]
    public EnvironmentVariableValue_statuscode? statuscode {
        get {
            return GetOptionSetValue<EnvironmentVariableValue_statuscode>("statuscode");
        }
        set {
            SetOptionSetValue("statuscode", value);
        }
    }
    
    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_environmentvariablevalue")]
    public BusinessUnit business_unit_environmentvariablevalue {
        get {
            return GetRelatedEntity<BusinessUnit>("business_unit_environmentvariablevalue", null);
        }
        set {
            SetRelatedEntity("business_unit_environmentvariablevalue", null, value);
        }
    }
    
    [AttributeLogicalName("environmentvariabledefinitionid")]
    [RelationshipSchemaName("environmentvariabledefinition_environmentvariablevalue")]
    public EnvironmentVariableDefinition environmentvariabledefinition_environmentvariablevalue {
        get {
            return GetRelatedEntity<EnvironmentVariableDefinition>("environmentvariabledefinition_environmentvariablevalue", null);
        }
        set {
            SetRelatedEntity("environmentvariabledefinition_environmentvariablevalue", null, value);
        }
    }
    
    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_environmentvariablevalue_createdby")]
    public SystemUser lk_environmentvariablevalue_createdby {
        get {
            return GetRelatedEntity<SystemUser>("lk_environmentvariablevalue_createdby", null);
        }
        set {
            SetRelatedEntity("lk_environmentvariablevalue_createdby", null, value);
        }
    }
    
    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_environmentvariablevalue_createdonbehalfby")]
    public SystemUser lk_environmentvariablevalue_createdonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_environmentvariablevalue_createdonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_environmentvariablevalue_createdonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_environmentvariablevalue_modifiedby")]
    public SystemUser lk_environmentvariablevalue_modifiedby {
        get {
            return GetRelatedEntity<SystemUser>("lk_environmentvariablevalue_modifiedby", null);
        }
        set {
            SetRelatedEntity("lk_environmentvariablevalue_modifiedby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_environmentvariablevalue_modifiedonbehalfby")]
    public SystemUser lk_environmentvariablevalue_modifiedonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_environmentvariablevalue_modifiedonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_environmentvariablevalue_modifiedonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_environmentvariablevalue")]
    public Team team_environmentvariablevalue {
        get {
            return GetRelatedEntity<Team>("team_environmentvariablevalue", null);
        }
        set {
            SetRelatedEntity("team_environmentvariablevalue", null, value);
        }
    }
    
    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_environmentvariablevalue")]
    public SystemUser user_environmentvariablevalue {
        get {
            return GetRelatedEntity<SystemUser>("user_environmentvariablevalue", null);
        }
        set {
            SetRelatedEntity("user_environmentvariablevalue", null, value);
        }
    }
    
    public static EnvironmentVariableValue Retrieve(IOrganizationService service, Guid id, params Expression<Func<EnvironmentVariableValue,object>>[] attrs) {
        return service.Retrieve(id, attrs);
    }
}

[DataContract()]
public enum EnvironmentVariableValueState {
    
    [EnumMember()]
    [OptionSetMetadata("Active", Index=0, Lcid=1036)]
    Active = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Inactive", Index=1, Lcid=1036)]
    Inactive = 1,
}

[DataContract()]
public enum EnvironmentVariableValue_statuscode {
    
    [EnumMember()]
    [OptionSetMetadata("Active", Index=0, Lcid=1036)]
    Active = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Inactive", Index=1, Lcid=1036)]
    Inactive = 2,
}
