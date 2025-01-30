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
/// <para>Display Name: ContactOrders</para>
/// </summary>
[EntityLogicalName("contactorders")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract()]
public partial class ContactOrders : ExtendedEntity<EmptyEnum, EmptyEnum> {
    
    public const string EntityLogicalName = "contactorders";
    
    public const string RelationshipSchemaName = "ContactOrders";
    
    public const int EntityTypeCode = 19;
    
    public ContactOrders() : 
            base(EntityLogicalName) {
    }
    
    public ContactOrders(Guid Id) : 
            base(EntityLogicalName, Id) {
    }
    
    private string DebuggerDisplay {
        get {
            return GetDebuggerDisplay("name");
        }
    }
    
    [AttributeLogicalName("contactorderid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("contactorderid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique des commandes du contact.</para>
    /// </summary>
    [AttributeLogicalName("contactorderid")]
    public Guid? ContactOrderId {
        get {
            return GetAttributeValue<Guid?>("contactorderid");
        }
        set {
            SetId("contactorderid", value);
        }
    }
    
    [AttributeLogicalName("contactid")]
    public Guid? ContactId {
        get {
            return GetAttributeValue<Guid?>("contactid");
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
    /// <para>nom</para>
    /// <para>Display Name: nom</para>
    /// </summary>
    [AttributeLogicalName("name")]
    [DisplayName("nom")]
    [MaxLength(100)]
    public string Name {
        get {
            return GetAttributeValue<string>("name");
        }
        set {
            SetAttributeValue("name", value);
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
    /// <para>nom</para>
    /// <para>Display Name: nom</para>
    /// </summary>
    [AttributeLogicalName("name")]
    [DisplayName("nom")]
    [MaxLength(100)]
    public string PrimaryNameField {
        get {
            return GetAttributeValue<string>("name");
        }
        set {
            SetAttributeValue("name", value);
        }
    }
    
    [AttributeLogicalName("salesorderid")]
    public Guid? SalesOrderId {
        get {
            return GetAttributeValue<Guid?>("salesorderid");
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
    
    public static ContactOrders Retrieve(IOrganizationService service, Guid id, params Expression<Func<ContactOrders,object>>[] attrs) {
        return service.Retrieve(id, attrs);
    }
}
