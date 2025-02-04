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
/// <para>Liste d’enregistrements nécessitant une action, tels que des comptes, des activités et des incidents.</para>
/// <para>Display Name: File d’attente</para>
/// </summary>
[EntityLogicalName("queue")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract()]
public partial class Queue : ExtendedEntity<QueueState, Queue_StatusCode> {
    
    public const string EntityLogicalName = "queue";
    
    public const int EntityTypeCode = 2020;
    
    public Queue() : 
            base(EntityLogicalName) {
    }
    
    public Queue(Guid Id) : 
            base(EntityLogicalName, Id) {
    }
    
    private string DebuggerDisplay {
        get {
            return GetDebuggerDisplay("name");
        }
    }
    
    [AttributeLogicalName("queueid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("queueid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de la file d'attente.</para>
    /// <para>Display Name: File d’attente</para>
    /// </summary>
    [AttributeLogicalName("queueid")]
    [DisplayName("File d’attente")]
    public Guid? QueueId {
        get {
            return GetAttributeValue<Guid?>("queueid");
        }
        set {
            SetId("queueid", value);
        }
    }
    
    /// <summary>
    /// <para>Cet attribut n'est plus utilisé. Les données sont désormais dans l'attribut Mailbox.AllowEmailConnectorToUseCredentials.</para>
    /// <para>Display Name: Autoriser l'utilisation d'informations d'identification pour le traitement du courrier électronique (obsolète)</para>
    /// </summary>
    [AttributeLogicalName("allowemailcredentials")]
    [DisplayName("Autoriser l\'utilisation d\'informations d\'identification pour le traitement du cou" +
        "rrier électronique (obsolète)")]
    public bool? AllowEmailCredentials {
        get {
            return GetAttributeValue<bool?>("allowemailcredentials");
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de la division à laquelle la file d'attente est associée.</para>
    /// <para>Display Name: Division</para>
    /// </summary>
    [AttributeLogicalName("businessunitid")]
    [DisplayName("Division")]
    public EntityReference BusinessUnitId {
        get {
            return GetAttributeValue<EntityReference>("businessunitid");
        }
        set {
            SetAttributeValue("businessunitid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'utilisateur qui a créé la file d'attente.</para>
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
    /// <para>Date et heure de la création de la file d'attente.</para>
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
    /// <para>Identificateur unique de l’utilisateur délégué qui a créé la file d’attente.</para>
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
    /// <para>Sélectionnez la boîte aux lettres associée à cette file d'attente.</para>
    /// <para>Display Name: Boîte aux lettres</para>
    /// </summary>
    [AttributeLogicalName("defaultmailbox")]
    [DisplayName("Boîte aux lettres")]
    public EntityReference DefaultMailbox {
        get {
            return GetAttributeValue<EntityReference>("defaultmailbox");
        }
    }
    
    /// <summary>
    /// <para>Description de la file d'attente.</para>
    /// <para>Display Name: Description</para>
    /// </summary>
    [AttributeLogicalName("description")]
    [DisplayName("Description")]
    public string Description {
        get {
            return GetAttributeValue<string>("description");
        }
        set {
            SetAttributeValue("description", value);
        }
    }
    
    /// <summary>
    /// <para>Adresse de messagerie associée à la file d'attente.</para>
    /// <para>Display Name: Courrier électronique entrant</para>
    /// </summary>
    [AttributeLogicalName("emailaddress")]
    [DisplayName("Courrier électronique entrant")]
    [MaxLength(100)]
    public string EMailAddress {
        get {
            return GetAttributeValue<string>("emailaddress");
        }
        set {
            SetAttributeValue("emailaddress", value);
        }
    }
    
    /// <summary>
    /// <para>Cet attribut n'est plus utilisé. Les données sont désormais dans l'attribut Mailbox.Password.</para>
    /// <para>Display Name: Mot de passe (obsolète)</para>
    /// </summary>
    [AttributeLogicalName("emailpassword")]
    [DisplayName("Mot de passe (obsolète)")]
    [MaxLength(200)]
    public string EmailPassword {
        get {
            return GetAttributeValue<string>("emailpassword");
        }
    }
    
    /// <summary>
    /// <para>Affiche le statut de l’adresse de messagerie principale.</para>
    /// <para>Display Name: Statut de l’adresse de messagerie principale</para>
    /// </summary>
    [AttributeLogicalName("emailrouteraccessapproval")]
    [DisplayName("Statut de l’adresse de messagerie principale")]
    public Queue_EmailRouterAccessApproval? EmailRouterAccessApproval {
        get {
            return GetOptionSetValue<Queue_EmailRouterAccessApproval>("emailrouteraccessapproval");
        }
        set {
            SetOptionSetValue("emailrouteraccessapproval", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Signature du courrier électronique</para>
    /// </summary>
    [AttributeLogicalName("emailsignature")]
    [DisplayName("Signature du courrier électronique")]
    public EntityReference EmailSignature {
        get {
            return GetAttributeValue<EntityReference>("emailsignature");
        }
        set {
            SetAttributeValue("emailsignature", value);
        }
    }
    
    /// <summary>
    /// <para>Cet attribut n'est plus utilisé. Les données sont désormais dans l'attribut Mailbox.UserName.</para>
    /// <para>Display Name: Nom d'utilisateur (obsolète)</para>
    /// </summary>
    [AttributeLogicalName("emailusername")]
    [DisplayName("Nom d\'utilisateur (obsolète)")]
    [MaxLength(200)]
    public string EmailUsername {
        get {
            return GetAttributeValue<string>("emailusername");
        }
    }
    
    /// <summary>
    /// <para>Utilisation interne uniquement.</para>
    /// <para>Display Name: Code d'image de l'entité</para>
    /// </summary>
    [AttributeLogicalName("entityimageid")]
    [DisplayName("Code d\'image de l\'entité")]
    public Guid? EntityImageId {
        get {
            return GetAttributeValue<Guid?>("entityimageid");
        }
    }
    
    /// <summary>
    /// <para>Taux de change de la devise associée à la file d’attente par rapport à la devise de base.</para>
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
    /// <para>Information indiquant si une file d'attente doit ou non ignorer les messages électroniques non sollicités (déconseillés).</para>
    /// <para>Display Name: Convertir les messages </para>
    /// </summary>
    [AttributeLogicalName("ignoreunsolicitedemail")]
    [DisplayName("Convertir les messages ")]
    public bool? IgnoreUnsolicitedEmail {
        get {
            return GetAttributeValue<bool?>("ignoreunsolicitedemail");
        }
        set {
            SetAttributeValue("ignoreunsolicitedemail", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'importation ou de la migration de données ayant généré cet enregistrement.</para>
    /// <para>Display Name: Numéro séquentiel d'importation</para>
    /// </summary>
    [AttributeLogicalName("importsequencenumber")]
    [DisplayName("Numéro séquentiel d\'importation")]
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
    /// <para>Mode de distribution des courriers électroniques entrants pour la file d'attente.</para>
    /// <para>Display Name: Mode de distribution des courriers électroniques entrants</para>
    /// </summary>
    [AttributeLogicalName("incomingemaildeliverymethod")]
    [DisplayName("Mode de distribution des courriers électroniques entrants")]
    public Queue_IncomingEmailDeliveryMethod? IncomingEmailDeliveryMethod {
        get {
            return GetOptionSetValue<Queue_IncomingEmailDeliveryMethod>("incomingemaildeliverymethod");
        }
        set {
            SetOptionSetValue("incomingemaildeliverymethod", value);
        }
    }
    
    /// <summary>
    /// <para>Convertir les messages entrants en activités</para>
    /// <para>Display Name: Convertir les messages entrants en activités</para>
    /// </summary>
    [AttributeLogicalName("incomingemailfilteringmethod")]
    [DisplayName("Convertir les messages entrants en activités")]
    public Queue_IncomingEmailFilteringMethod? IncomingEmailFilteringMethod {
        get {
            return GetOptionSetValue<Queue_IncomingEmailFilteringMethod>("incomingemailfilteringmethod");
        }
        set {
            SetOptionSetValue("incomingemailfilteringmethod", value);
        }
    }
    
    /// <summary>
    /// <para>Affiche le statut de l'approbation de l'adresse de messagerie par l'administrateur d'O365.</para>
    /// <para>Display Name: Statut de l'approbation de l'adresse de messagerie par l'administrateur d'O365</para>
    /// </summary>
    [AttributeLogicalName("isemailaddressapprovedbyo365admin")]
    [DisplayName("Statut de l\'approbation de l\'adresse de messagerie par l\'administrateur d\'O365")]
    public bool? IsEmailAddressApprovedByO365Admin {
        get {
            return GetAttributeValue<bool?>("isemailaddressapprovedbyo365admin");
        }
    }
    
    /// <summary>
    /// <para>Information indiquant si la file d'attente est une file d'attente de livraison de télécopies.</para>
    /// <para>Display Name: File d'attente de télécopie</para>
    /// </summary>
    [AttributeLogicalName("isfaxqueue")]
    [DisplayName("File d\'attente de télécopie")]
    public bool? IsFaxQueue {
        get {
            return GetAttributeValue<bool?>("isfaxqueue");
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'utilisateur qui a modifié la file d'attente pour la dernière fois.</para>
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
    /// <para>Date et heure de la dernière modification de la file d'attente.</para>
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
    /// <para>Identificateur unique de l’utilisateur délégué qui a modifié la file d’attente pour la dernière fois.</para>
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
    /// <para>Nom de la file d'attente.</para>
    /// <para>Display Name: Nom</para>
    /// </summary>
    [AttributeLogicalName("name")]
    [DisplayName("Nom")]
    [MaxLength(200)]
    public string Name {
        get {
            return GetAttributeValue<string>("name");
        }
        set {
            SetAttributeValue("name", value);
        }
    }
    
    /// <summary>
    /// <para>Nombre d'éléments de file d'attente associés à la file d'attente.</para>
    /// <para>Display Name: Éléments de file d'attente</para>
    /// </summary>
    [AttributeLogicalName("numberofitems")]
    [DisplayName("Éléments de file d\'attente")]
    [Range(-2147483648, 2147483647)]
    public int? NumberOfItems {
        get {
            return GetAttributeValue<int?>("numberofitems");
        }
    }
    
    /// <summary>
    /// <para>Nombre de membres associés à la file d'attente.</para>
    /// <para>Display Name: Nombre de membres</para>
    /// </summary>
    [AttributeLogicalName("numberofmembers")]
    [DisplayName("Nombre de membres")]
    [Range(-2147483648, 2147483647)]
    public int? NumberOfMembers {
        get {
            return GetAttributeValue<int?>("numberofmembers");
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'organisation associée à la file d'attente.</para>
    /// <para>Display Name: Organisation</para>
    /// </summary>
    [AttributeLogicalName("organizationid")]
    [DisplayName("Organisation")]
    public EntityReference OrganizationId {
        get {
            return GetAttributeValue<EntityReference>("organizationid");
        }
    }
    
    /// <summary>
    /// <para>Mode de distribution des courriers électroniques sortants pour la file d'attente.</para>
    /// <para>Display Name: Mode de livraison des courriers électroniques sortants</para>
    /// </summary>
    [AttributeLogicalName("outgoingemaildeliverymethod")]
    [DisplayName("Mode de livraison des courriers électroniques sortants")]
    public Queue_OutgoingEmailDeliveryMethod? OutgoingEmailDeliveryMethod {
        get {
            return GetOptionSetValue<Queue_OutgoingEmailDeliveryMethod>("outgoingemaildeliverymethod");
        }
        set {
            SetOptionSetValue("outgoingemaildeliverymethod", value);
        }
    }
    
    /// <summary>
    /// <para>Date et heure de la migration de l'enregistrement.</para>
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
    /// <para>Identificateur unique de l’utilisateur ou de l’équipe propriétaire de la file d’attente.</para>
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
    /// <para>Identificateur unique de la division propriétaire de la file d’attente.</para>
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
    /// <para>Identificateur unique de l’équipe propriétaire de la file d’attente.</para>
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
    /// <para>Identificateur unique de l’utilisateur propriétaire de la file d’attente.</para>
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
    /// <para>Nom de la file d'attente.</para>
    /// <para>Display Name: Nom</para>
    /// </summary>
    [AttributeLogicalName("name")]
    [DisplayName("Nom")]
    [MaxLength(200)]
    public string PrimaryNameField {
        get {
            return GetAttributeValue<string>("name");
        }
        set {
            SetAttributeValue("name", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique du propriétaire de la file d'attente.</para>
    /// <para>Display Name: Propriétaire (déconseillé)</para>
    /// </summary>
    [AttributeLogicalName("primaryuserid")]
    [DisplayName("Propriétaire (déconseillé)")]
    public EntityReference PrimaryUserId {
        get {
            return GetAttributeValue<EntityReference>("primaryuserid");
        }
        set {
            SetAttributeValue("primaryuserid", value);
        }
    }
    
    /// <summary>
    /// <para>Type de file d'attente automatiquement attribué lors de la création d'un utilisateur ou d'une file d'attente, tel que publique, privé ou de travail.</para>
    /// <para>Display Name: Type de file d'attente</para>
    /// </summary>
    [AttributeLogicalName("queuetypecode")]
    [DisplayName("Type de file d\'attente")]
    public Queue_QueueTypeCode? QueueTypeCode {
        get {
            return GetOptionSetValue<Queue_QueueTypeCode>("queuetypecode");
        }
    }
    
    /// <summary>
    /// <para>Indiquez si la file d'attente est privée ou publique. Une file d'attente publique peut être affichée par tous les utilisateurs, et une file d'attente privée uniquement par les membres qui y ont été ajoutés.</para>
    /// <para>Display Name: Type</para>
    /// </summary>
    [AttributeLogicalName("queueviewtype")]
    [DisplayName("Type")]
    public Queue_QueueViewType? QueueViewType {
        get {
            return GetOptionSetValue<Queue_QueueViewType>("queueviewtype");
        }
        set {
            SetOptionSetValue("queueviewtype", value);
        }
    }
    
    /// <summary>
    /// <para>Statut de la file d’attente.</para>
    /// <para>Display Name: Statut</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Statut")]
    public QueueState? StateCode {
        get {
            return GetOptionSetValue<QueueState>("statecode");
        }
        set {
            SetOptionSetValue("statecode", value);
        }
    }
    
    /// <summary>
    /// <para>Raison du statut de la file d’attente.</para>
    /// <para>Display Name: Raison du statut</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Raison du statut")]
    public Queue_StatusCode? StatusCode {
        get {
            return GetOptionSetValue<Queue_StatusCode>("statuscode");
        }
        set {
            SetOptionSetValue("statuscode", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de la devise associée à la file d’attente.</para>
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
    /// <para>Numéro de version de la file d’attente.</para>
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
    /// <para>Liez le contrat d’entrée d’affectation à la file d’attente.</para>
    /// <para>Display Name: ID de contrat d’entrée d’affectation</para>
    /// </summary>
    [AttributeLogicalName("msdyn_assignmentinputcontractid")]
    [DisplayName("ID de contrat d’entrée d’affectation")]
    public EntityReference msdyn_assignmentinputcontractid {
        get {
            return GetAttributeValue<EntityReference>("msdyn_assignmentinputcontractid");
        }
        set {
            SetAttributeValue("msdyn_assignmentinputcontractid", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Stratégie d’affectation</para>
    /// </summary>
    [AttributeLogicalName("msdyn_assignmentstrategy")]
    [DisplayName("Stratégie d’affectation")]
    public msdyn_queueassignmentstrategy? msdyn_assignmentstrategy {
        get {
            return GetOptionSetValue<msdyn_queueassignmentstrategy>("msdyn_assignmentstrategy");
        }
        set {
            SetOptionSetValue("msdyn_assignmentstrategy", value);
        }
    }
    
    /// <summary>
    /// <para>Définir les règles de dépassement pour les éléments de travail après leur entrée dans la file d’attente</para>
    /// <para>Display Name: Ensemble de règles de dépassement dans la file d’attente</para>
    /// </summary>
    [AttributeLogicalName("msdyn_inqueueoverflowrulesetid")]
    [DisplayName("Ensemble de règles de dépassement dans la file d’attente")]
    public EntityReference msdyn_inqueueoverflowrulesetid {
        get {
            return GetAttributeValue<EntityReference>("msdyn_inqueueoverflowrulesetid");
        }
        set {
            SetAttributeValue("msdyn_inqueueoverflowrulesetid", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: intentfamilyid</para>
    /// </summary>
    [AttributeLogicalName("msdyn_intentfamilyid")]
    [DisplayName("intentfamilyid")]
    public EntityReference msdyn_intentfamilyid {
        get {
            return GetAttributeValue<EntityReference>("msdyn_intentfamilyid");
        }
        set {
            SetAttributeValue("msdyn_intentfamilyid", value);
        }
    }
    
    /// <summary>
    /// <para>Indique si la file d’attente est définie ou non comme valeur par défaut.</para>
    /// <para>Display Name: Est la file d’attente par défaut</para>
    /// </summary>
    [AttributeLogicalName("msdyn_isdefaultqueue")]
    [DisplayName("Est la file d’attente par défaut")]
    public bool? msdyn_isdefaultqueue {
        get {
            return GetAttributeValue<bool?>("msdyn_isdefaultqueue");
        }
        set {
            SetAttributeValue("msdyn_isdefaultqueue", value);
        }
    }
    
    /// <summary>
    /// <para>Indique si la file d’attente est utilisée comme file d’attente Omnicanal pour la répartition du travail.</para>
    /// <para>Display Name: Est une file d’attente Omnicanal</para>
    /// </summary>
    [AttributeLogicalName("msdyn_isomnichannelqueue")]
    [DisplayName("Est une file d’attente Omnicanal")]
    public bool? msdyn_isomnichannelqueue {
        get {
            return GetAttributeValue<bool?>("msdyn_isomnichannelqueue");
        }
        set {
            SetAttributeValue("msdyn_isomnichannelqueue", value);
        }
    }
    
    /// <summary>
    /// <para>Taille maximale de la file d’attente</para>
    /// <para>Display Name: Taille maximale de la file d’attente</para>
    /// </summary>
    [AttributeLogicalName("msdyn_maxqueuesize")]
    [DisplayName("Taille maximale de la file d’attente")]
    [Range(0, 2147483647)]
    public int? msdyn_maxqueuesize {
        get {
            return GetAttributeValue<int?>("msdyn_maxqueuesize");
        }
        set {
            SetAttributeValue("msdyn_maxqueuesize", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l’heure de travail associée à la file d’attente.</para>
    /// <para>Display Name: Heures de travail</para>
    /// </summary>
    [AttributeLogicalName("msdyn_operatinghourid")]
    [DisplayName("Heures de travail")]
    public EntityReference msdyn_operatinghourid {
        get {
            return GetAttributeValue<EntityReference>("msdyn_operatinghourid");
        }
        set {
            SetAttributeValue("msdyn_operatinghourid", value);
        }
    }
    
    /// <summary>
    /// <para>Paramètre permettant d’activer/de désactiver l’attribution basée sur les heures de travail pour la file d’attente</para>
    /// <para>Display Name: Activer l’affectation basée sur les heures de travail pour la file d’attente</para>
    /// </summary>
    [AttributeLogicalName("msdyn_operatinghoursbasedassignment")]
    [DisplayName("Activer l’affectation basée sur les heures de travail pour la file d’attente")]
    public bool? msdyn_operatinghoursbasedassignment {
        get {
            return GetAttributeValue<bool?>("msdyn_operatinghoursbasedassignment");
        }
        set {
            SetAttributeValue("msdyn_operatinghoursbasedassignment", value);
        }
    }
    
    /// <summary>
    /// <para>Définir les règles de dépassement de capacité pour les éléments de travail avant leur entrée dans la file d’attente</para>
    /// <para>Display Name: Ensemble de règles de dépassement de capacité avant la mise en file d’attente</para>
    /// </summary>
    [AttributeLogicalName("msdyn_prequeueoverflowrulesetid")]
    [DisplayName("Ensemble de règles de dépassement de capacité avant la mise en file d’attente")]
    public EntityReference msdyn_prequeueoverflowrulesetid {
        get {
            return GetAttributeValue<EntityReference>("msdyn_prequeueoverflowrulesetid");
        }
        set {
            SetAttributeValue("msdyn_prequeueoverflowrulesetid", value);
        }
    }
    
    /// <summary>
    /// <para>Priorité de la file d’attente pour indiquer l’ordre d’affectation des conversations à l’agent.</para>
    /// <para>Display Name: Priorité</para>
    /// </summary>
    [AttributeLogicalName("msdyn_priority")]
    [DisplayName("Priorité")]
    [Range(1, 2147483647)]
    public int? msdyn_priority {
        get {
            return GetAttributeValue<int?>("msdyn_priority");
        }
        set {
            SetAttributeValue("msdyn_priority", value);
        }
    }
    
    /// <summary>
    /// <para>Paramètre permettant d’activer/de désactiver le traitement périodique d’une file d’attente</para>
    /// <para>Display Name: Activer le traitement périodique de la file d’attente</para>
    /// </summary>
    [AttributeLogicalName("msdyn_processqueueperiodically")]
    [DisplayName("Activer le traitement périodique de la file d’attente")]
    public bool? msdyn_processqueueperiodically {
        get {
            return GetAttributeValue<bool?>("msdyn_processqueueperiodically");
        }
        set {
            SetAttributeValue("msdyn_processqueueperiodically", value);
        }
    }
    
    /// <summary>
    /// <para>Définit le type de canaux gérés par cette file d’attente</para>
    /// <para>Display Name: Type de file d’attente</para>
    /// </summary>
    [AttributeLogicalName("msdyn_queuetype")]
    [DisplayName("Type de file d’attente")]
    public msdyn_queuetype? msdyn_queuetype {
        get {
            return GetOptionSetValue<msdyn_queuetype>("msdyn_queuetype");
        }
        set {
            SetOptionSetValue("msdyn_queuetype", value);
        }
    }
    
    /// <summary>
    /// <para>Nom unique de l’entité.</para>
    /// <para>Display Name: Nom unique</para>
    /// </summary>
    [AttributeLogicalName("msdyn_uniquename")]
    [DisplayName("Nom unique")]
    [MaxLength(128)]
    public string msdyn_uniquename {
        get {
            return GetAttributeValue<string>("msdyn_uniquename");
        }
        set {
            SetAttributeValue("msdyn_uniquename", value);
        }
    }
    
    [RelationshipSchemaName("Queue_Email_EmailSender")]
    public IEnumerable<Email> Queue_Email_EmailSender {
        get {
            return GetRelatedEntities<Email>("Queue_Email_EmailSender", null);
        }
        set {
            SetRelatedEntities("Queue_Email_EmailSender", null, value);
        }
    }
    
    [AttributeLogicalName("businessunitid")]
    [RelationshipSchemaName("business_unit_queues")]
    public BusinessUnit business_unit_queues {
        get {
            return GetRelatedEntity<BusinessUnit>("business_unit_queues", null);
        }
        set {
            SetRelatedEntity("business_unit_queues", null, value);
        }
    }
    
    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_queues2")]
    public BusinessUnit business_unit_queues2 {
        get {
            return GetRelatedEntity<BusinessUnit>("business_unit_queues2", null);
        }
        set {
            SetRelatedEntity("business_unit_queues2", null, value);
        }
    }
    
    [RelationshipSchemaName("email_acceptingentity_queue")]
    public IEnumerable<Email> email_acceptingentity_queue {
        get {
            return GetRelatedEntities<Email>("email_acceptingentity_queue", null);
        }
        set {
            SetRelatedEntities("email_acceptingentity_queue", null, value);
        }
    }
    
    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_queue_createdonbehalfby")]
    public SystemUser lk_queue_createdonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_queue_createdonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_queue_createdonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_queue_modifiedonbehalfby")]
    public SystemUser lk_queue_modifiedonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_queue_modifiedonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_queue_modifiedonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_queuebase_createdby")]
    public SystemUser lk_queuebase_createdby {
        get {
            return GetRelatedEntity<SystemUser>("lk_queuebase_createdby", null);
        }
        set {
            SetRelatedEntity("lk_queuebase_createdby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_queuebase_modifiedby")]
    public SystemUser lk_queuebase_modifiedby {
        get {
            return GetRelatedEntity<SystemUser>("lk_queuebase_modifiedby", null);
        }
        set {
            SetRelatedEntity("lk_queuebase_modifiedby", null, value);
        }
    }
    
    [RelationshipSchemaName("queue_activity_parties")]
    public IEnumerable<ActivityParty> queue_activity_parties {
        get {
            return GetRelatedEntities<ActivityParty>("queue_activity_parties", null);
        }
        set {
            SetRelatedEntities("queue_activity_parties", null, value);
        }
    }
    
    [RelationshipSchemaName("queue_entries")]
    public IEnumerable<QueueItem> queue_entries {
        get {
            return GetRelatedEntities<QueueItem>("queue_entries", null);
        }
        set {
            SetRelatedEntities("queue_entries", null, value);
        }
    }
    
    [AttributeLogicalName("primaryuserid")]
    [RelationshipSchemaName("queue_primary_user")]
    public SystemUser queue_primary_user {
        get {
            return GetRelatedEntity<SystemUser>("queue_primary_user", null);
        }
        set {
            SetRelatedEntity("queue_primary_user", null, value);
        }
    }
    
    [RelationshipSchemaName("queue_system_user")]
    public IEnumerable<SystemUser> queue_system_user {
        get {
            return GetRelatedEntities<SystemUser>("queue_system_user", null);
        }
        set {
            SetRelatedEntities("queue_system_user", null, value);
        }
    }
    
    [RelationshipSchemaName("queue_team")]
    public IEnumerable<Team> queue_team {
        get {
            return GetRelatedEntities<Team>("queue_team", null);
        }
        set {
            SetRelatedEntities("queue_team", null, value);
        }
    }
    
    [RelationshipSchemaName("queuemembership_association")]
    public IEnumerable<SystemUser> queuemembership_association {
        get {
            return GetRelatedEntities<SystemUser>("queuemembership_association", null);
        }
        set {
            SetRelatedEntities("queuemembership_association", null, value);
        }
    }
    
    public static Queue Retrieve(IOrganizationService service, Guid id, params Expression<Func<Queue,object>>[] attrs) {
        return service.Retrieve(id, attrs);
    }
}

[DataContract()]
public enum QueueState {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=0, Lcid=1036)]
    Actif = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=1, Lcid=1036)]
    Inactif = 1,
}

[DataContract()]
public enum Queue_EmailRouterAccessApproval {
    
    [EnumMember()]
    [OptionSetMetadata("Vide", Index=0, Lcid=1036)]
    Vide = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Approuvé", Index=1, Lcid=1036)]
    Approuvé = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Approbation en attente", Index=2, Lcid=1036)]
    Approbationenattente = 2,
    
    [EnumMember()]
    [OptionSetMetadata("Rejeté", Index=3, Lcid=1036)]
    Rejeté = 3,
}

[DataContract()]
public enum Queue_IncomingEmailDeliveryMethod {
    
    [EnumMember()]
    [OptionSetMetadata("Aucun(e)", Index=0, Lcid=1036)]
    Aucune = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Synchronisation côté serveur ou E-mail Router", Index=1, Lcid=1036)]
    SynchronisationcôtéserveurouEmailRouter = 2,
    
    [EnumMember()]
    [OptionSetMetadata("Boîte aux lettres de transfert", Index=2, Lcid=1036)]
    Boîteauxlettresdetransfert = 3,
}

[DataContract()]
public enum Queue_IncomingEmailFilteringMethod {
    
    [EnumMember()]
    [OptionSetMetadata("Tous les messages électroniques", Index=0, Lcid=1036)]
    Touslesmessagesélectroniques = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Courriers électroniques en réponse à un courrier électronique Dynamics 365", Index=1, Lcid=1036)]
    CourriersélectroniquesenréponseàuncourrierélectroniqueDynamics365 = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Messages électroniques des prospects, contacts et comptes Dynamics 365", Index=2, Lcid=1036)]
    MessagesélectroniquesdesprospectscontactsetcomptesDynamics365 = 2,
    
    [EnumMember()]
    [OptionSetMetadata("Messages électroniques des enregistrements Dynamics 365 activés pour le courrier " +
        "électronique", Index=3, Lcid=1036)]
    MessagesélectroniquesdesenregistrementsDynamics365activéspourlecourrierélectronique = 3,
    
    [EnumMember()]
    [OptionSetMetadata("Aucun message électronique", Index=4, Lcid=1036)]
    Aucunmessageélectronique = 4,
}

[DataContract()]
public enum Queue_OutgoingEmailDeliveryMethod {
    
    [EnumMember()]
    [OptionSetMetadata("Aucun(e)", Index=0, Lcid=1036)]
    Aucune = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Synchronisation côté serveur ou E-mail Router", Index=1, Lcid=1036)]
    SynchronisationcôtéserveurouEmailRouter = 2,
}

[DataContract()]
public enum Queue_QueueTypeCode {
    
    [EnumMember()]
    [OptionSetMetadata("Valeur par défaut", Index=0, Lcid=1036)]
    Valeurpardéfaut = 1,
}

[DataContract()]
public enum Queue_QueueViewType {
    
    [EnumMember()]
    [OptionSetMetadata("Public", Index=0, Lcid=1036)]
    Public = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Privé", Index=1, Lcid=1036)]
    Privé = 1,
}

[DataContract()]
public enum Queue_StatusCode {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=1, Lcid=1036)]
    Actif = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=0, Lcid=1036)]
    Inactif = 2,
}
