//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
/// <para>Activité qui assure le suivi de la livraison d'une lettre. L'activité peut contenir la copie électronique de la lettre.</para>
/// <para>Display Name: Courrier</para>
/// </summary>
[EntityLogicalName("letter")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract()]
public partial class Letter : ExtendedEntity<LetterState, Letter_StatusCode> {
    
    public const string EntityLogicalName = "letter";
    
    public const int EntityTypeCode = 4207;
    
    public Letter() : 
            base(EntityLogicalName) {
    }
    
    public Letter(Guid Id) : 
            base(EntityLogicalName, Id) {
    }
    
    private string DebuggerDisplay {
        get {
            return GetDebuggerDisplay("subject");
        }
    }
    
    [AttributeLogicalName("activityid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("activityid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'activité de lettre.</para>
    /// <para>Display Name: Lettre</para>
    /// </summary>
    [AttributeLogicalName("activityid")]
    [DisplayName("Lettre")]
    public Guid? ActivityId {
        get {
            return GetAttributeValue<Guid?>("activityid");
        }
        set {
            SetId("activityid", value);
        }
    }
    
    /// <summary>
    /// <para>Affiche le type de l'activité.</para>
    /// <para>Display Name: Type d'activité</para>
    /// </summary>
    [AttributeLogicalName("activitytypecode")]
    [DisplayName("Type d\'activité")]
    public string ActivityTypeCode {
        get {
            return GetAttributeValue<string>("activitytypecode");
        }
    }
    
    /// <summary>
    /// <para>Tapez le nombre de minutes passées à la création et à l'envoi de la lettre. La durée est utilisée dans les rapports.</para>
    /// <para>Display Name: Durée</para>
    /// </summary>
    [AttributeLogicalName("actualdurationminutes")]
    [DisplayName("Durée")]
    [Range(0, 2147483647)]
    public int? ActualDurationMinutes {
        get {
            return GetAttributeValue<int?>("actualdurationminutes");
        }
        set {
            SetAttributeValue("actualdurationminutes", value);
        }
    }
    
    /// <summary>
    /// <para>Entrez la date et l'heure de fin réelles de la lettre. Par défaut, la date et l'heure auxquelles l'activité est terminée ou annulée sont affichées, mais elles peuvent être modifiées pour tenir compte de la durée réelle de la création et de l'envoi de la lettre.</para>
    /// <para>Display Name: Fin réelle</para>
    /// </summary>
    [AttributeLogicalName("actualend")]
    [DisplayName("Fin réelle")]
    public DateTime? ActualEnd {
        get {
            return GetAttributeValue<DateTime?>("actualend");
        }
        set {
            SetAttributeValue("actualend", value);
        }
    }
    
    /// <summary>
    /// <para>Tapez la date et l'heure de début réelles de la lettre. Par défaut, la date et l'heure auxquelles l'activité est créée sont affichées, mais elles peuvent être modifiées pour tenir compte de la durée réelle de la création et de l'envoi de la lettre.</para>
    /// <para>Display Name: Début réel</para>
    /// </summary>
    [AttributeLogicalName("actualstart")]
    [DisplayName("Début réel")]
    public DateTime? ActualStart {
        get {
            return GetAttributeValue<DateTime?>("actualstart");
        }
        set {
            SetAttributeValue("actualstart", value);
        }
    }
    
    /// <summary>
    /// <para>Tapez l'adresse complète du destinataire de la lettre pour assurer la livraison en temps voulu.</para>
    /// <para>Display Name: Adresse</para>
    /// </summary>
    [AttributeLogicalName("address")]
    [DisplayName("Adresse")]
    [MaxLength(200)]
    public string Address {
        get {
            return GetAttributeValue<string>("address");
        }
        set {
            SetAttributeValue("address", value);
        }
    }
    
    /// <summary>
    /// <para>Entrez les destinataires qui sont inclus dans la distribution de la lettre, mais ne sont pas affichés pour les autres.</para>
    /// <para>Display Name: Cci</para>
    /// </summary>
    [AttributeLogicalName("bcc")]
    [DisplayName("Cci")]
    public IEnumerable<ActivityParty> Bcc {
        get {
            return GetEntityCollection<ActivityParty>("bcc");
        }
        set {
            SetEntityCollection("bcc", value);
        }
    }
    
    /// <summary>
    /// <para>Tapez une catégorie pour identifier le type de lettre, comme une offre de vente ou un avertissement de retard, pour lier la lettre à un groupe professionnel ou à une fonction.</para>
    /// <para>Display Name: Catégorie</para>
    /// </summary>
    [AttributeLogicalName("category")]
    [DisplayName("Catégorie")]
    [MaxLength(250)]
    public string Category {
        get {
            return GetAttributeValue<string>("category");
        }
        set {
            SetAttributeValue("category", value);
        }
    }
    
    /// <summary>
    /// <para>Entrez les destinataires qui doivent être en copie de la lettre.</para>
    /// <para>Display Name: Cc</para>
    /// </summary>
    [AttributeLogicalName("cc")]
    [DisplayName("Cc")]
    public IEnumerable<ActivityParty> Cc {
        get {
            return GetEntityCollection<ActivityParty>("cc");
        }
        set {
            SetEntityCollection("cc", value);
        }
    }
    
    /// <summary>
    /// <para>Affiche le créateur de l'enregistrement.</para>
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
    /// <para>Affiche la date et l'heure de la création de l'enregistrement. Celles-ci sont affichées dans le fuseau horaire sélectionné dans les options de Microsoft Dynamics 365.</para>
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
    /// <para>Affiche l'utilisateur qui a créé l'enregistrement pour un autre utilisateur.</para>
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
    /// <para>Entrez le corps de la lettre ou des informations supplémentaires pour décrire la lettre, comme le message principal ou les produits et les services dont il a été question.</para>
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
    /// <para>Sélectionnez la direction de la lettre, entrante ou sortante.</para>
    /// <para>Display Name: Direction</para>
    /// </summary>
    [AttributeLogicalName("directioncode")]
    [DisplayName("Direction")]
    public bool? DirectionCode {
        get {
            return GetAttributeValue<bool?>("directioncode");
        }
        set {
            SetAttributeValue("directioncode", value);
        }
    }
    
    /// <summary>
    /// <para>Affiche le taux de conversion de la devise de l'enregistrement. Le taux de change permet de convertir tous les champs d'argent de l'enregistrement de la devise locale en devise par défaut du système.</para>
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
    /// <para>Entrez le compte, le contact, le prospect ou l'utilisateur qui a envoyé la lettre.</para>
    /// <para>Display Name: De</para>
    /// </summary>
    [AttributeLogicalName("from")]
    [DisplayName("De")]
    public IEnumerable<ActivityParty> From {
        get {
            return GetEntityCollection<ActivityParty>("from");
        }
        set {
            SetEntityCollection("from", value);
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
    /// <para>Indique si l'activité de lettre a été facturée dans le cadre de la résolution d'un incident.</para>
    /// <para>Display Name: Est facturé</para>
    /// </summary>
    [AttributeLogicalName("isbilled")]
    [DisplayName("Est facturé")]
    public bool? IsBilled {
        get {
            return GetAttributeValue<bool?>("isbilled");
        }
        set {
            SetAttributeValue("isbilled", value);
        }
    }
    
    /// <summary>
    /// <para>Indique si l’activité est régulière ou de type événement.</para>
    /// <para>Display Name: Est une activité régulière</para>
    /// </summary>
    [AttributeLogicalName("isregularactivity")]
    [DisplayName("Est une activité régulière")]
    public bool? IsRegularActivity {
        get {
            return GetAttributeValue<bool?>("isregularactivity");
        }
    }
    
    /// <summary>
    /// <para>Indique si l'activité de lettre a été créée à partir d'une règle de workflow.</para>
    /// <para>Display Name: Est créé(e) par le workflow</para>
    /// </summary>
    [AttributeLogicalName("isworkflowcreated")]
    [DisplayName("Est créé(e) par le workflow")]
    public bool? IsWorkflowCreated {
        get {
            return GetAttributeValue<bool?>("isworkflowcreated");
        }
        set {
            SetAttributeValue("isworkflowcreated", value);
        }
    }
    
    /// <summary>
    /// <para>Contient l'horodatage de la dernière durée de suspension.</para>
    /// <para>Display Name: Dernière durée de suspension</para>
    /// </summary>
    [AttributeLogicalName("lastonholdtime")]
    [DisplayName("Dernière durée de suspension")]
    public DateTime? LastOnHoldTime {
        get {
            return GetAttributeValue<DateTime?>("lastonholdtime");
        }
        set {
            SetAttributeValue("lastonholdtime", value);
        }
    }
    
    /// <summary>
    /// <para>Affiche la personne à l'origine de la dernière mise à jour de l'enregistrement.</para>
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
    /// <para>Affiche la date et l'heure de la dernière mise à jour de l'enregistrement. La date et l'heure sont affichées selon le fuseau horaire sélectionné dans les options de Microsoft Dynamics 365.</para>
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
    /// <para>Affiche la personne à l'origine de la dernière mise à jour de l'enregistrement à la place d'un autre utilisateur.</para>
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
    /// <para>Affiche la durée, en minutes, de la suspension de l'enregistrement.</para>
    /// <para>Display Name: Durée de la suspension (minutes)</para>
    /// </summary>
    [AttributeLogicalName("onholdtime")]
    [DisplayName("Durée de la suspension (minutes)")]
    [Range(-2147483648, 2147483647)]
    public int? OnHoldTime {
        get {
            return GetAttributeValue<int?>("onholdtime");
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
    /// <para>Entrez l'utilisateur ou l'équipe affectée à la gestion de l'enregistrement. Ce champ est mis à jour à chaque fois que l'enregistrement est attribué à un utilisateur différent.</para>
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
    /// <para>Identificateur unique de la division propriétaire de l'activité de lettre.</para>
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
    /// <para>Identificateur unique de l’équipe propriétaire de l’activité de lettre.</para>
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
    /// <para>Identificateur unique de l’utilisateur propriétaire de l’activité de lettre.</para>
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
    /// <para>Tapez une courte description de l'objectif ou du sujet principal de la lettre.</para>
    /// <para>Display Name: Objet</para>
    /// </summary>
    [AttributeLogicalName("subject")]
    [DisplayName("Objet")]
    [MaxLength(200)]
    public string PrimaryNameField {
        get {
            return GetAttributeValue<string>("subject");
        }
        set {
            SetAttributeValue("subject", value);
        }
    }
    
    /// <summary>
    /// <para>Sélectionnez la priorité afin que les clients préférés ou les problèmes critiques soient traités rapidement.</para>
    /// <para>Display Name: Priorité</para>
    /// </summary>
    [AttributeLogicalName("prioritycode")]
    [DisplayName("Priorité")]
    public Letter_PriorityCode? PriorityCode {
        get {
            return GetOptionSetValue<Letter_PriorityCode>("prioritycode");
        }
        set {
            SetOptionSetValue("prioritycode", value);
        }
    }
    
    /// <summary>
    /// <para>Affiche l'ID du processus.</para>
    /// <para>Display Name: Processus</para>
    /// </summary>
    [AttributeLogicalName("processid")]
    [DisplayName("Processus")]
    public Guid? ProcessId {
        get {
            return GetAttributeValue<Guid?>("processid");
        }
        set {
            SetAttributeValue("processid", value);
        }
    }
    
    /// <summary>
    /// <para>Choisissez l'enregistrement concerné par la lettre.</para>
    /// <para>Display Name: Concernant</para>
    /// </summary>
    [AttributeLogicalName("regardingobjectid")]
    [DisplayName("Concernant")]
    public EntityReference RegardingObjectId {
        get {
            return GetAttributeValue<EntityReference>("regardingobjectid");
        }
        set {
            SetAttributeValue("regardingobjectid", value);
        }
    }
    
    /// <summary>
    /// <para>Choisissez le contrat de niveau de service (contrat SLA) que vous voulez appliquer à l'enregistrement de lettre.</para>
    /// <para>Display Name: Contrat SLA</para>
    /// </summary>
    [AttributeLogicalName("slaid")]
    [DisplayName("Contrat SLA")]
    public EntityReference SLAId {
        get {
            return GetAttributeValue<EntityReference>("slaid");
        }
        set {
            SetAttributeValue("slaid", value);
        }
    }
    
    /// <summary>
    /// <para>Dernier contrat SLA ayant été appliqué à cette lettre. Ce champ est destiné à une utilisation interne uniquement.</para>
    /// <para>Display Name: Dernier contrat SLA appliqué</para>
    /// </summary>
    [AttributeLogicalName("slainvokedid")]
    [DisplayName("Dernier contrat SLA appliqué")]
    public EntityReference SLAInvokedId {
        get {
            return GetAttributeValue<EntityReference>("slainvokedid");
        }
    }
    
    /// <summary>
    /// <para>Durée planifiée de l'activité de lettre, spécifiée en minutes.</para>
    /// <para>Display Name: Durée planifiée</para>
    /// </summary>
    [AttributeLogicalName("scheduleddurationminutes")]
    [DisplayName("Durée planifiée")]
    [Range(0, 2147483647)]
    public int? ScheduledDurationMinutes {
        get {
            return GetAttributeValue<int?>("scheduleddurationminutes");
        }
    }
    
    /// <summary>
    /// <para>Entrez la date et l'heure d'échéance prévues.</para>
    /// <para>Display Name: Date d’échéance</para>
    /// </summary>
    [AttributeLogicalName("scheduledend")]
    [DisplayName("Date d’échéance")]
    public DateTime? ScheduledEnd {
        get {
            return GetAttributeValue<DateTime?>("scheduledend");
        }
        set {
            SetAttributeValue("scheduledend", value);
        }
    }
    
    /// <summary>
    /// <para>Entrez la date et l'heure d'échéance prévues.</para>
    /// <para>Display Name: Date de début</para>
    /// </summary>
    [AttributeLogicalName("scheduledstart")]
    [DisplayName("Date de début")]
    public DateTime? ScheduledStart {
        get {
            return GetAttributeValue<DateTime?>("scheduledstart");
        }
        set {
            SetAttributeValue("scheduledstart", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique d'un service associé.</para>
    /// <para>Display Name: Service</para>
    /// </summary>
    [AttributeLogicalName("serviceid")]
    [DisplayName("Service")]
    public EntityReference ServiceId {
        get {
            return GetAttributeValue<EntityReference>("serviceid");
        }
        set {
            SetAttributeValue("serviceid", value);
        }
    }
    
    /// <summary>
    /// <para>Affiche la date et l'heure de tri des activités.</para>
    /// <para>Display Name: Date de tri</para>
    /// </summary>
    [AttributeLogicalName("sortdate")]
    [DisplayName("Date de tri")]
    public DateTime? SortDate {
        get {
            return GetAttributeValue<DateTime?>("sortdate");
        }
        set {
            SetAttributeValue("sortdate", value);
        }
    }
    
    /// <summary>
    /// <para>Affiche l'ID de la phase.</para>
    /// <para>Display Name: (Déconseillé) Phase du processus</para>
    /// </summary>
    [AttributeLogicalName("stageid")]
    [DisplayName("(Déconseillé) Phase du processus")]
    public Guid? StageId {
        get {
            return GetAttributeValue<Guid?>("stageid");
        }
        set {
            SetAttributeValue("stageid", value);
        }
    }
    
    /// <summary>
    /// <para>Indique si la lettre est ouverte, terminée ou annulée. Les lettres terminées et annulées sont en lecture seule et ne peuvent pas être modifiées.</para>
    /// <para>Display Name: Statut d'activité</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Statut d\'activité")]
    public LetterState? StateCode {
        get {
            return GetOptionSetValue<LetterState>("statecode");
        }
        set {
            SetOptionSetValue("statecode", value);
        }
    }
    
    /// <summary>
    /// <para>Sélectionnez le statut de la lettre.</para>
    /// <para>Display Name: Raison du statut</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Raison du statut")]
    public Letter_StatusCode? StatusCode {
        get {
            return GetOptionSetValue<Letter_StatusCode>("statuscode");
        }
        set {
            SetOptionSetValue("statuscode", value);
        }
    }
    
    /// <summary>
    /// <para>Tapez une sous-catégorie pour identifier le type de lettre et associer l'activité à un produit, une région de vente, un groupe professionnel ou une fonction spécifique.</para>
    /// <para>Display Name: Sous-catégorie</para>
    /// </summary>
    [AttributeLogicalName("subcategory")]
    [DisplayName("Sous-catégorie")]
    [MaxLength(250)]
    public string Subcategory {
        get {
            return GetAttributeValue<string>("subcategory");
        }
        set {
            SetAttributeValue("subcategory", value);
        }
    }
    
    /// <summary>
    /// <para>Tapez une courte description de l'objectif ou du sujet principal de la lettre.</para>
    /// <para>Display Name: Objet</para>
    /// </summary>
    [AttributeLogicalName("subject")]
    [DisplayName("Objet")]
    [MaxLength(200)]
    public string Subject {
        get {
            return GetAttributeValue<string>("subject");
        }
        set {
            SetAttributeValue("subject", value);
        }
    }
    
    /// <summary>
    /// <para>Utilisation interne uniquement.</para>
    /// <para>Display Name: Abonnement</para>
    /// </summary>
    [AttributeLogicalName("subscriptionid")]
    [DisplayName("Abonnement")]
    public Guid? SubscriptionId {
        get {
            return GetAttributeValue<Guid?>("subscriptionid");
        }
        set {
            SetAttributeValue("subscriptionid", value);
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
    /// <para>Entrez le compte, le contact, le prospect ou les destinataires de la lettre.</para>
    /// <para>Display Name: À</para>
    /// </summary>
    [AttributeLogicalName("to")]
    [DisplayName("À")]
    public IEnumerable<ActivityParty> To {
        get {
            return GetEntityCollection<ActivityParty>("to");
        }
        set {
            SetEntityCollection("to", value);
        }
    }
    
    /// <summary>
    /// <para>Choisissez la devise locale pour l'enregistrement pour vous assurer que les budgets sont validés dans la devise correcte.</para>
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
    /// <para>Utilisation interne uniquement.</para>
    /// <para>Display Name: (Déconseillé) Chemin d’accès traversé</para>
    /// </summary>
    [AttributeLogicalName("traversedpath")]
    [DisplayName("(Déconseillé) Chemin d’accès traversé")]
    [MaxLength(1250)]
    public string TraversedPath {
        get {
            return GetAttributeValue<string>("traversedpath");
        }
        set {
            SetAttributeValue("traversedpath", value);
        }
    }
    
    /// <summary>
    /// <para>Code de fuseau horaire utilisé à la création de l’enregistrement.</para>
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
    /// <para>Numéro de version de la lettre.</para>
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
    /// <para>Display Name: Date de réception</para>
    /// </summary>
    [AttributeLogicalName("nxt_deliverydate")]
    [DisplayName("Date de réception")]
    public DateTime? nxt_DeliveryDate {
        get {
            return GetAttributeValue<DateTime?>("nxt_deliverydate");
        }
        set {
            SetAttributeValue("nxt_deliverydate", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Code HTTP</para>
    /// </summary>
    [AttributeLogicalName("nxt_httpcode")]
    [DisplayName("Code HTTP")]
    [MaxLength(100)]
    public string nxt_HttpCode {
        get {
            return GetAttributeValue<string>("nxt_httpcode");
        }
        set {
            SetAttributeValue("nxt_httpcode", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Message HTTP</para>
    /// </summary>
    [AttributeLogicalName("nxt_httpmessage")]
    [DisplayName("Message HTTP")]
    public string nxt_HttpMessage {
        get {
            return GetAttributeValue<string>("nxt_httpmessage");
        }
        set {
            SetAttributeValue("nxt_httpmessage", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: Id de suivi</para>
    /// </summary>
    [AttributeLogicalName("nxt_trackingnumber")]
    [DisplayName("Id de suivi")]
    [MaxLength(100)]
    public string nxt_TrackingNumber {
        get {
            return GetAttributeValue<string>("nxt_trackingnumber");
        }
        set {
            SetAttributeValue("nxt_trackingnumber", value);
        }
    }
    
    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Account_Letters")]
    public Account Account_Letters {
        get {
            return GetRelatedEntity<Account>("Account_Letters", null);
        }
        set {
            SetRelatedEntity("Account_Letters", null, value);
        }
    }
    
    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Contact_Letters")]
    public Contact Contact_Letters {
        get {
            return GetRelatedEntity<Contact>("Contact_Letters", null);
        }
        set {
            SetRelatedEntity("Contact_Letters", null, value);
        }
    }
    
    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("Incident_Letters")]
    public Incident Incident_Letters {
        get {
            return GetRelatedEntity<Incident>("Incident_Letters", null);
        }
        set {
            SetRelatedEntity("Incident_Letters", null, value);
        }
    }
    
    [AttributeLogicalName("owningbusinessunit")]
    [RelationshipSchemaName("business_unit_letter_activities")]
    public BusinessUnit business_unit_letter_activities {
        get {
            return GetRelatedEntity<BusinessUnit>("business_unit_letter_activities", null);
        }
        set {
            SetRelatedEntity("business_unit_letter_activities", null, value);
        }
    }
    
    [RelationshipSchemaName("letter_activity_parties")]
    public IEnumerable<ActivityParty> letter_activity_parties {
        get {
            return GetRelatedEntities<ActivityParty>("letter_activity_parties", null);
        }
        set {
            SetRelatedEntities("letter_activity_parties", null, value);
        }
    }
    
    [RelationshipSchemaName("letter_connections1")]
    public IEnumerable<Connection> letter_connections1 {
        get {
            return GetRelatedEntities<Connection>("letter_connections1", null);
        }
        set {
            SetRelatedEntities("letter_connections1", null, value);
        }
    }
    
    [RelationshipSchemaName("letter_connections2")]
    public IEnumerable<Connection> letter_connections2 {
        get {
            return GetRelatedEntities<Connection>("letter_connections2", null);
        }
        set {
            SetRelatedEntities("letter_connections2", null, value);
        }
    }
    
    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_letter_createdby")]
    public SystemUser lk_letter_createdby {
        get {
            return GetRelatedEntity<SystemUser>("lk_letter_createdby", null);
        }
        set {
            SetRelatedEntity("lk_letter_createdby", null, value);
        }
    }
    
    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_letter_createdonbehalfby")]
    public SystemUser lk_letter_createdonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_letter_createdonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_letter_createdonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_letter_modifiedby")]
    public SystemUser lk_letter_modifiedby {
        get {
            return GetRelatedEntity<SystemUser>("lk_letter_modifiedby", null);
        }
        set {
            SetRelatedEntity("lk_letter_modifiedby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_letter_modifiedonbehalfby")]
    public SystemUser lk_letter_modifiedonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_letter_modifiedonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_letter_modifiedonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("nxt_customerfolder_Letters")]
    public nxt_customerfolder nxt_customerfolder_Letters {
        get {
            return GetRelatedEntity<nxt_customerfolder>("nxt_customerfolder_Letters", null);
        }
        set {
            SetRelatedEntity("nxt_customerfolder_Letters", null, value);
        }
    }
    
    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("nxt_supplierintervention_Letters")]
    public nxt_SupplierIntervention nxt_supplierintervention_Letters {
        get {
            return GetRelatedEntity<nxt_SupplierIntervention>("nxt_supplierintervention_Letters", null);
        }
        set {
            SetRelatedEntity("nxt_supplierintervention_Letters", null, value);
        }
    }
    
    [AttributeLogicalName("regardingobjectid")]
    [RelationshipSchemaName("nxt_supplierquote_Letters")]
    public nxt_SupplierQuote nxt_supplierquote_Letters {
        get {
            return GetRelatedEntity<nxt_SupplierQuote>("nxt_supplierquote_Letters", null);
        }
        set {
            SetRelatedEntity("nxt_supplierquote_Letters", null, value);
        }
    }
    
    [AttributeLogicalName("owningteam")]
    [RelationshipSchemaName("team_letter")]
    public Team team_letter {
        get {
            return GetRelatedEntity<Team>("team_letter", null);
        }
        set {
            SetRelatedEntity("team_letter", null, value);
        }
    }
    
    [AttributeLogicalName("owninguser")]
    [RelationshipSchemaName("user_letter")]
    public SystemUser user_letter {
        get {
            return GetRelatedEntity<SystemUser>("user_letter", null);
        }
        set {
            SetRelatedEntity("user_letter", null, value);
        }
    }
    
    public static Letter Retrieve(IOrganizationService service, Guid id, params Expression<Func<Letter,object>>[] attrs) {
        return service.Retrieve(id, attrs);
    }
    
    /// <summary>
    /// <para>Retrieves the record using the alternate key called 'AlternateKeyTrackingNumber'</para>
    /// </summary>
    public static Letter Retrieve_nxt_AlternateKeyTrackingNumber(IOrganizationService service, string nxt_TrackingNumber, params Expression<Func<Letter,object>>[] attrs) {
        KeyAttributeCollection keys = new KeyAttributeCollection();
        keys.Add("nxt_trackingnumber", nxt_TrackingNumber);
        return Retrieve_AltKey(service, keys, attrs);
    }
    
    /// <summary>
    /// <para>Set values for the alternate key called 'AlternateKeyTrackingNumber'</para>
    /// </summary>
    public void AltKey_nxt_AlternateKeyTrackingNumber(string nxt_TrackingNumber) {
        KeyAttributes.Clear();
        KeyAttributes.Add("nxt_trackingnumber", nxt_TrackingNumber);
    }
}

[DataContract()]
public enum LetterState {
    
    [EnumMember()]
    [OptionSetMetadata("Ouvert", Index=0, Lcid=1036)]
    Ouvert = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Terminé", Index=1, Lcid=1036)]
    Terminé = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Annulé", Index=2, Lcid=1036)]
    Annulé = 2,
}

[DataContract()]
public enum Letter_PriorityCode {
    
    [EnumMember()]
    [OptionSetMetadata("Faible", Index=0, Lcid=1036)]
    Faible = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Normale", Index=1, Lcid=1036)]
    Normale = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Haute", Index=2, Lcid=1036)]
    Haute = 2,
}

[DataContract()]
public enum Letter_StatusCode {
    
    [EnumMember()]
    [OptionSetMetadata("Envoi en cours", Index=0, Lcid=1036, Description="")]
    Envoiencours = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Reçu", Index=2, Lcid=1036)]
    Reçu = 2,
    
    [EnumMember()]
    [OptionSetMetadata("Echec de réception", Index=4, Lcid=1036)]
    Echecderéception = 3,
    
    [EnumMember()]
    [OptionSetMetadata("Envoyé", Index=3, Lcid=1036)]
    Envoyé = 4,
    
    [EnumMember()]
    [OptionSetMetadata("Brouillon", Index=1, Lcid=1036)]
    Brouillon = 5,
}
