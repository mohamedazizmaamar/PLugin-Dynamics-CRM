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
/// <para>Display Name: Table Virtuelle Apf</para>
/// </summary>
[EntityLogicalName("nxt_virtualapf")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract()]
public partial class nxt_VirtualApf : ExtendedEntity<EmptyEnum, EmptyEnum> {
    
    public const string EntityLogicalName = "nxt_virtualapf";
    
    public const int EntityTypeCode = 11252;
    
    public nxt_VirtualApf() : 
            base(EntityLogicalName) {
    }
    
    public nxt_VirtualApf(Guid Id) : 
            base(EntityLogicalName, Id) {
    }
    
    private string DebuggerDisplay {
        get {
            return GetDebuggerDisplay("nxt_name");
        }
    }
    
    [AttributeLogicalName("nxt_virtualapfid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("nxt_virtualapfid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique des instances d'entité</para>
    /// <para>Display Name: Table Virtuelle Apf</para>
    /// </summary>
    [AttributeLogicalName("nxt_virtualapfid")]
    [DisplayName("Table Virtuelle Apf")]
    public Guid? nxt_VirtualApfId {
        get {
            return GetAttributeValue<Guid?>("nxt_virtualapfid");
        }
        set {
            SetId("nxt_virtualapfid", value);
        }
    }
    
    /// <summary>
    /// <para>Nom de l'entité personnalisée.</para>
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
    /// <para>Display Name: Exclu</para>
    /// </summary>
    [AttributeLogicalName("nxt_isdisabled")]
    [DisplayName("Exclu")]
    public bool? nxt_IsDisabled {
        get {
            return GetAttributeValue<bool?>("nxt_isdisabled");
        }
        set {
            SetAttributeValue("nxt_isdisabled", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Date d'envoi</para>
    /// </summary>
    [AttributeLogicalName("nxt_mailingdate")]
    [DisplayName("Date d\'envoi")]
    public DateTime? nxt_MailingDate {
        get {
            return GetAttributeValue<DateTime?>("nxt_mailingdate");
        }
        set {
            SetAttributeValue("nxt_mailingdate", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: % par stade</para>
    /// </summary>
    [AttributeLogicalName("nxt_percentageperstep")]
    [DisplayName("% par stade")]
    public double? nxt_PercentagePerStep {
        get {
            return GetAttributeValue<double?>("nxt_percentageperstep");
        }
        set {
            SetAttributeValue("nxt_percentageperstep", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Libellé du stade APF</para>
    /// </summary>
    [AttributeLogicalName("nxt_stepname")]
    [DisplayName("Libellé du stade APF")]
    [MaxLength(100)]
    public string nxt_StepName {
        get {
            return GetAttributeValue<string>("nxt_stepname");
        }
        set {
            SetAttributeValue("nxt_stepname", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: % cumulé</para>
    /// </summary>
    [AttributeLogicalName("nxt_totalpercentage")]
    [DisplayName("% cumulé")]
    public double? nxt_TotalPercentage {
        get {
            return GetAttributeValue<double?>("nxt_totalpercentage");
        }
        set {
            SetAttributeValue("nxt_totalpercentage", value);
        }
    }
    
    /// <summary>
    /// <para>Nom de l'entité personnalisée.</para>
    /// <para>Display Name: Nom</para>
    /// </summary>
    [AttributeLogicalName("nxt_name")]
    [DisplayName("Nom")]
    [MaxLength(100)]
    public string nxt_name {
        get {
            return GetAttributeValue<string>("nxt_name");
        }
        set {
            SetAttributeValue("nxt_name", value);
        }
    }
    
    [AttributeLogicalName("nxt_customerfolderid")]
    [RelationshipSchemaName("nxt_nxt_customerfolder_nxt_virtualapf_nxt_CustomerFolderId")]
    public nxt_customerfolder nxt_nxt_customerfolder_nxt_virtualapf_nxt_CustomerFolderId {
        get {
            return GetRelatedEntity<nxt_customerfolder>("nxt_nxt_customerfolder_nxt_virtualapf_nxt_CustomerFolderId", null);
        }
        set {
            SetRelatedEntity("nxt_nxt_customerfolder_nxt_virtualapf_nxt_CustomerFolderId", null, value);
        }
    }
    
    public static nxt_VirtualApf Retrieve(IOrganizationService service, Guid id, params Expression<Func<nxt_VirtualApf,object>>[] attrs) {
        return service.Retrieve(id, attrs);
    }
}
