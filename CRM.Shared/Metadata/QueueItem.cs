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
/// <para>Élément d’une file d’attente indiquant un incident ou une activité.</para>
/// <para>Display Name: Élément de file d’attente</para>
/// </summary>
[EntityLogicalName("queueitem")]
[DebuggerDisplay("{DebuggerDisplay,nq}")]
[DataContract()]
public partial class QueueItem : ExtendedEntity<QueueItemState, QueueItem_StatusCode> {
    
    public const string EntityLogicalName = "queueitem";
    
    public const int EntityTypeCode = 2029;
    
    public QueueItem() : 
            base(EntityLogicalName) {
    }
    
    public QueueItem(Guid Id) : 
            base(EntityLogicalName, Id) {
    }
    
    private string DebuggerDisplay {
        get {
            return GetDebuggerDisplay("title");
        }
    }
    
    [AttributeLogicalName("queueitemid")]
    public override Guid Id {
        get {
            return base.Id;
        }
        set {
            SetId("queueitemid", value);
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'élément de file d'attente.</para>
    /// <para>Display Name: Élément de file d’attente</para>
    /// </summary>
    [AttributeLogicalName("queueitemid")]
    [DisplayName("Élément de file d’attente")]
    public Guid? QueueItemId {
        get {
            return GetAttributeValue<Guid?>("queueitemid");
        }
        set {
            SetId("queueitemid", value);
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
    /// <para>Affiche la date à laquelle l'enregistrement a été attribué à la file d'attente.</para>
    /// <para>Display Name: Inséré dans la file d'attente</para>
    /// </summary>
    [AttributeLogicalName("enteredon")]
    [DisplayName("Inséré dans la file d\'attente")]
    public DateTime? EnteredOn {
        get {
            return GetAttributeValue<DateTime?>("enteredon");
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
    /// <para>Identificateur unique de l’utilisateur délégué qui a modifié l’élément de file d’attente pour la dernière fois.</para>
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
    /// <para>Choisissez l'activité, l'incident ou l'article attribué à la file d'attente.</para>
    /// <para>Display Name: Objet</para>
    /// </summary>
    [AttributeLogicalName("objectid")]
    [DisplayName("Objet")]
    public EntityReference ObjectId {
        get {
            return GetAttributeValue<EntityReference>("objectid");
        }
        set {
            SetAttributeValue("objectid", value);
        }
    }
    
    /// <summary>
    /// <para>Sélectionnez le type d'élément de file d'attente, tel que activité, incident ou rendez-vous.</para>
    /// <para>Display Name: Type</para>
    /// </summary>
    [AttributeLogicalName("objecttypecode")]
    [DisplayName("Type")]
    public QueueItem_ObjectTypeCode? ObjectTypeCode {
        get {
            return GetOptionSetValue<QueueItem_ObjectTypeCode>("objecttypecode");
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de l'organisation à laquelle l'élément de file d'attente est associé.</para>
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
    /// <para>Identificateur unique de l’utilisateur ou de l’équipe propriétaire de l’élément de file d’attente.</para>
    /// <para>Display Name: Propriétaire</para>
    /// </summary>
    [AttributeLogicalName("ownerid")]
    [DisplayName("Propriétaire")]
    public EntityReference OwnerId {
        get {
            return GetAttributeValue<EntityReference>("ownerid");
        }
    }
    
    /// <summary>
    /// <para>Identificateur unique de la division propriétaire de l’élément de file d’attente.</para>
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
    /// <para>Identificateur unique de l’utilisateur propriétaire de l’élément de file d’attente.</para>
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
    /// <para>Affiche le titre ou le nom qui décrit l’enregistrement de la file d’attente. Cette valeur est copiée à partir de l’enregistrement qui a été attribué à la file d’attente.</para>
    /// <para>Display Name: Titre</para>
    /// </summary>
    [AttributeLogicalName("title")]
    [DisplayName("Titre")]
    [MaxLength(850)]
    public string PrimaryNameField {
        get {
            return GetAttributeValue<string>("title");
        }
        set {
            SetAttributeValue("title", value);
        }
    }
    
    /// <summary>
    /// <para>Priorité de l'élément de file d'attente.</para>
    /// <para>Display Name: Priorité</para>
    /// </summary>
    [AttributeLogicalName("priority")]
    [DisplayName("Priorité")]
    [Range(0, 1000000000)]
    public int? Priority {
        get {
            return GetAttributeValue<int?>("priority");
        }
        set {
            SetAttributeValue("priority", value);
        }
    }
    
    /// <summary>
    /// <para>Choisissez la file d'attente à laquelle l'élément est attribué.</para>
    /// <para>Display Name: File d’attente</para>
    /// </summary>
    [AttributeLogicalName("queueid")]
    [DisplayName("File d’attente")]
    public EntityReference QueueId {
        get {
            return GetAttributeValue<EntityReference>("queueid");
        }
        set {
            SetAttributeValue("queueid", value);
        }
    }
    
    /// <summary>
    /// <para>Expéditeur qui a créé l'élément de file d'attente.</para>
    /// <para>Display Name: De</para>
    /// </summary>
    [AttributeLogicalName("sender")]
    [DisplayName("De")]
    [MaxLength(250)]
    public string Sender {
        get {
            return GetAttributeValue<string>("sender");
        }
        set {
            SetAttributeValue("sender", value);
        }
    }
    
    /// <summary>
    /// <para>Statut de l'élément de la file d'attente.</para>
    /// <para>Display Name: Statut (déconseillé)</para>
    /// </summary>
    [AttributeLogicalName("state")]
    [DisplayName("Statut (déconseillé)")]
    [Range(0, 1000000000)]
    public int? State {
        get {
            return GetAttributeValue<int?>("state");
        }
        set {
            SetAttributeValue("state", value);
        }
    }
    
    /// <summary>
    /// <para>Indique si l'enregistrement de file d'attente est actif ou inactif. Les enregistrements de file d'attente inactifs sont en lecture seule et ne peuvent pas être modifiés avant d'être réactivés.</para>
    /// <para>Display Name: Statut</para>
    /// </summary>
    [AttributeLogicalName("statecode")]
    [DisplayName("Statut")]
    public QueueItemState? StateCode {
        get {
            return GetOptionSetValue<QueueItemState>("statecode");
        }
        set {
            SetOptionSetValue("statecode", value);
        }
    }
    
    /// <summary>
    /// <para>Raison du statut de l'élément de la file d'attente.</para>
    /// <para>Display Name: Raison du statut (déconseillé)</para>
    /// </summary>
    [AttributeLogicalName("status")]
    [DisplayName("Raison du statut (déconseillé)")]
    [Range(0, 1000000000)]
    public int? Status {
        get {
            return GetAttributeValue<int?>("status");
        }
        set {
            SetAttributeValue("status", value);
        }
    }
    
    /// <summary>
    /// <para>Sélectionnez le statut de l'élément.</para>
    /// <para>Display Name: Raison du statut</para>
    /// </summary>
    [AttributeLogicalName("statuscode")]
    [DisplayName("Raison du statut")]
    public QueueItem_StatusCode? StatusCode {
        get {
            return GetOptionSetValue<QueueItem_StatusCode>("statuscode");
        }
        set {
            SetOptionSetValue("statuscode", value);
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
    /// <para>Affiche le titre ou le nom qui décrit l’enregistrement de la file d’attente. Cette valeur est copiée à partir de l’enregistrement qui a été attribué à la file d’attente.</para>
    /// <para>Display Name: Titre</para>
    /// </summary>
    [AttributeLogicalName("title")]
    [DisplayName("Titre")]
    [MaxLength(850)]
    public string Title {
        get {
            return GetAttributeValue<string>("title");
        }
        set {
            SetAttributeValue("title", value);
        }
    }
    
    /// <summary>
    /// <para>Destinataires présents dans le champ À du message pour les éléments de la file d'attente du courrier électronique.</para>
    /// <para>Display Name: À</para>
    /// </summary>
    [AttributeLogicalName("torecipients")]
    [DisplayName("À")]
    [MaxLength(500)]
    public string ToRecipients {
        get {
            return GetAttributeValue<string>("torecipients");
        }
        set {
            SetAttributeValue("torecipients", value);
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
    /// <para>Numéro de version de l’élément de file d’attente.</para>
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
    /// <para>Affiche la personne qui travaille sur l'élément de file d'attente.</para>
    /// <para>Display Name: Traité par</para>
    /// </summary>
    [AttributeLogicalName("workerid")]
    [DisplayName("Traité par")]
    public EntityReference WorkerId {
        get {
            return GetAttributeValue<EntityReference>("workerid");
        }
        set {
            SetAttributeValue("workerid", value);
        }
    }
    
    /// <summary>
    /// <para>Affiche la date et l'heure de la dernière attribution de la file d'attente à un utilisateur.</para>
    /// <para>Display Name: Traité le</para>
    /// </summary>
    [AttributeLogicalName("workeridmodifiedon")]
    [DisplayName("Traité le")]
    public DateTime? WorkerIdModifiedOn {
        get {
            return GetAttributeValue<DateTime?>("workeridmodifiedon");
        }
    }
    
    /// <summary>
    /// <para>Liveworkstream auquel appartient cet élément de file d’attente</para>
    /// <para>Display Name: Flux de travail actif</para>
    /// </summary>
    [AttributeLogicalName("msdyn_liveworkstreamid")]
    [DisplayName("Flux de travail actif")]
    public EntityReference msdyn_liveworkstreamid {
        get {
            return GetAttributeValue<EntityReference>("msdyn_liveworkstreamid");
        }
        set {
            SetAttributeValue("msdyn_liveworkstreamid", value);
        }
    }
    
    /// <summary>
    /// <para>Cet attribut est utilisé par le système d’acheminement unifié pour décider d’ignorer ou non l’appel de synchronisation vers le service omnicanal.</para>
    /// <para>Display Name: msdyn_skipursync</para>
    /// </summary>
    [AttributeLogicalName("msdyn_skipursync")]
    [DisplayName("msdyn_skipursync")]
    public bool? msdyn_skipursync {
        get {
            return GetAttributeValue<bool?>("msdyn_skipursync");
        }
        set {
            SetAttributeValue("msdyn_skipursync", value);
        }
    }
    
    /// <summary>
    /// <para>Display Name: msft_DataState</para>
    /// </summary>
    [AttributeLogicalName("msft_datastate")]
    [DisplayName("msft_DataState")]
    public msft_datastate? msft_DataState {
        get {
            return GetOptionSetValue<msft_datastate>("msft_datastate");
        }
    }
    
    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Email_QueueItem")]
    public Email Email_QueueItem {
        get {
            return GetRelatedEntity<Email>("Email_QueueItem", null);
        }
        set {
            SetRelatedEntity("Email_QueueItem", null, value);
        }
    }
    
    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("Incident_QueueItem")]
    public Incident Incident_QueueItem {
        get {
            return GetRelatedEntity<Incident>("Incident_QueueItem", null);
        }
        set {
            SetRelatedEntity("Incident_QueueItem", null, value);
        }
    }
    
    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("PhoneCall_QueueItem")]
    public PhoneCall PhoneCall_QueueItem {
        get {
            return GetRelatedEntity<PhoneCall>("PhoneCall_QueueItem", null);
        }
        set {
            SetRelatedEntity("PhoneCall_QueueItem", null, value);
        }
    }
    
    [AttributeLogicalName("createdonbehalfby")]
    [RelationshipSchemaName("lk_queueitem_createdonbehalfby")]
    public SystemUser lk_queueitem_createdonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_queueitem_createdonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_queueitem_createdonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedonbehalfby")]
    [RelationshipSchemaName("lk_queueitem_modifiedonbehalfby")]
    public SystemUser lk_queueitem_modifiedonbehalfby {
        get {
            return GetRelatedEntity<SystemUser>("lk_queueitem_modifiedonbehalfby", null);
        }
        set {
            SetRelatedEntity("lk_queueitem_modifiedonbehalfby", null, value);
        }
    }
    
    [AttributeLogicalName("createdby")]
    [RelationshipSchemaName("lk_queueitembase_createdby")]
    public SystemUser lk_queueitembase_createdby {
        get {
            return GetRelatedEntity<SystemUser>("lk_queueitembase_createdby", null);
        }
        set {
            SetRelatedEntity("lk_queueitembase_createdby", null, value);
        }
    }
    
    [AttributeLogicalName("modifiedby")]
    [RelationshipSchemaName("lk_queueitembase_modifiedby")]
    public SystemUser lk_queueitembase_modifiedby {
        get {
            return GetRelatedEntity<SystemUser>("lk_queueitembase_modifiedby", null);
        }
        set {
            SetRelatedEntity("lk_queueitembase_modifiedby", null, value);
        }
    }
    
    [AttributeLogicalName("workerid")]
    [RelationshipSchemaName("lk_queueitembase_workerid")]
    public SystemUser lk_queueitembase_workerid {
        get {
            return GetRelatedEntity<SystemUser>("lk_queueitembase_workerid", null);
        }
        set {
            SetRelatedEntity("lk_queueitembase_workerid", null, value);
        }
    }
    
    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("nxt_customerfolder_QueueItems")]
    public nxt_customerfolder nxt_customerfolder_QueueItems {
        get {
            return GetRelatedEntity<nxt_customerfolder>("nxt_customerfolder_QueueItems", null);
        }
        set {
            SetRelatedEntity("nxt_customerfolder_QueueItems", null, value);
        }
    }
    
    [AttributeLogicalName("objectid")]
    [RelationshipSchemaName("nxt_message_QueueItems")]
    public nxt_Message nxt_message_QueueItems {
        get {
            return GetRelatedEntity<nxt_Message>("nxt_message_QueueItems", null);
        }
        set {
            SetRelatedEntity("nxt_message_QueueItems", null, value);
        }
    }
    
    [AttributeLogicalName("queueid")]
    [RelationshipSchemaName("queue_entries")]
    public Queue queue_entries {
        get {
            return GetRelatedEntity<Queue>("queue_entries", null);
        }
        set {
            SetRelatedEntity("queue_entries", null, value);
        }
    }
    
    [AttributeLogicalName("workerid")]
    [RelationshipSchemaName("team_queueitembase_workerid")]
    public Team team_queueitembase_workerid {
        get {
            return GetRelatedEntity<Team>("team_queueitembase_workerid", null);
        }
        set {
            SetRelatedEntity("team_queueitembase_workerid", null, value);
        }
    }
    
    public static QueueItem Retrieve(IOrganizationService service, Guid id, params Expression<Func<QueueItem,object>>[] attrs) {
        return service.Retrieve(id, attrs);
    }
}

[DataContract()]
public enum QueueItemState {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=0, Lcid=1036)]
    Actif = 0,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=1, Lcid=1036)]
    Inactif = 1,
}

[DataContract()]
public enum QueueItem_ObjectTypeCode {
    
    [EnumMember()]
    [OptionSetMetadata("Demande", Index=29, Lcid=1036, Description="Incident de requête de service associé à un contrat.")]
    Demande = 112,
    
    [EnumMember()]
    [OptionSetMetadata("Activité", Index=16, Lcid=1036, Description="Tâche effectuée ou à effectuer par un utilisateur. Une activité est une action po" +
        "ur laquelle on peut placer une entrée dans le calendrier.")]
    Activité = 4200,
    
    [EnumMember()]
    [OptionSetMetadata("Rendez-vous", Index=8, Lcid=1036, Description="Engagement représentant un intervalle de temps avec heures de début/fin et durée." +
        "")]
    Rendezvous = 4201,
    
    [EnumMember()]
    [OptionSetMetadata("Courrier électronique", Index=32, Lcid=1036, Description="Activité effectuée via des protocoles de courrier électronique.")]
    Courrierélectronique = 4202,
    
    [EnumMember()]
    [OptionSetMetadata("Télécopie", Index=2, Lcid=1036, Description="Activité qui vérifie le résultat d\'un appel et le nombre de pages d\'une télécopie" +
        ", et qui stocke éventuellement la copie électronique du document.")]
    Télécopie = 4204,
    
    [EnumMember()]
    [OptionSetMetadata("Lettre", Index=13, Lcid=1036, Description="Activité qui assure le suivi de la livraison d\'une lettre. L\'activité peut conten" +
        "ir la copie électronique de la lettre.")]
    Lettre = 4207,
    
    [EnumMember()]
    [OptionSetMetadata("Appel téléphonique", Index=19, Lcid=1036, Description="Activité de suivi d\'un appel téléphonique.")]
    Appeltéléphonique = 4210,
    
    [EnumMember()]
    [OptionSetMetadata("Tâche", Index=22, Lcid=1036, Description="Activité générique représentant le travail à effectuer.")]
    Tâche = 4212,
    
    [EnumMember()]
    [OptionSetMetadata("Activité de service", Index=26, Lcid=1036, Description="Activité de l\'organisation destinée à satisfaire les besoins de son client. Chaqu" +
        "e activité de service comprend la date, l\'heure, la durée et les ressources requ" +
        "ises.")]
    Activitédeservice = 4214,
    
    [EnumMember()]
    [OptionSetMetadata("Activité sociale", Index=23, Lcid=1036, Description="Utilisation interne uniquement.")]
    Activitésociale = 4216,
    
    [EnumMember()]
    [OptionSetMetadata("Rendez-vous périodique", Index=1, Lcid=1036, Description="Rendez-vous principal d’une série de rendez-vous périodiques.")]
    Rendezvouspériodique = 4251,
    
    [EnumMember()]
    [OptionSetMetadata("Réponse de campagne", Index=14, Lcid=1036, Description="Réponse d\'un client existant ou d\'un nouveau client potentiel pour une campagne.")]
    Réponsedecampagne = 4401,
    
    [EnumMember()]
    [OptionSetMetadata("Activité de campagne", Index=24, Lcid=1036, Description="Tâche effectuée, ou à effectuer, par l\'utilisateur pour la planification ou l\'exé" +
        "cution d\'une campagne.")]
    Activitédecampagne = 4402,
    
    [EnumMember()]
    [OptionSetMetadata("Campagne rapide", Index=5, Lcid=1036, Description="Opération système permettant d’effectuer sur de larges ensembles de données des o" +
        "pérations longues et asynchrones telles que la distribution d’activités de campa" +
        "gne et les campagnes rapides.")]
    Campagnerapide = 4406,
    
    [EnumMember()]
    [OptionSetMetadata("Article de la Base de connaissances", Index=0, Lcid=1036, Description="Connaissances organisationnelles destinées à un usage interne et externe.")]
    ArticledelaBasedeconnaissances = 9953,
    
    [EnumMember()]
    [OptionSetMetadata("Conversation instantanée Teams", Index=6, Lcid=1036, Description="Utilisation interne uniquement. Entité qui stocke les données d’association des e" +
        "nregistrements Dynamics 365 avec la conversation instantanée Microsoft Teams")]
    ConversationinstantanéeTeams = 10092,
    
    [EnumMember()]
    [OptionSetMetadata("Modèle d’article de la base de connaissances", Index=28, Lcid=1036, Description="Modèle d’article de la base de connaissances d’organisation pour la création inte" +
        "rne et externe d’articles de la base de connaissances.")]
    Modèledarticledelabasedeconnaissances = 10105,
    
    [EnumMember()]
    [OptionSetMetadata("Alerte IoT", Index=30, Lcid=1036, Description="")]
    AlerteIoT = 10172,
    
    [EnumMember()]
    [OptionSetMetadata("Alerte Customer Voice", Index=25, Lcid=1036, Description="")]
    AlerteCustomerVoice = 10342,
    
    [EnumMember()]
    [OptionSetMetadata("Invitation à l\'enquête Customer Voice", Index=4, Lcid=1036, Description="Activité qui assure le suivi d\'une invitation à une enquête envoyée à une personn" +
        "e.")]
    InvitationàlenquêteCustomerVoice = 10352,
    
    [EnumMember()]
    [OptionSetMetadata("Réponse à l\'enquête Customer Voice", Index=21, Lcid=1036, Description="Réponse à une enquête.")]
    RéponseàlenquêteCustomerVoice = 10354,
    
    [EnumMember()]
    [OptionSetMetadata("Configuration d’action de dépassement", Index=15, Lcid=1036, Description="Configurations d’action de dépassement.")]
    Configurationdactiondedépassement = 10374,
    
    [EnumMember()]
    [OptionSetMetadata("Conversation en cours (déconseillé)", Index=12, Lcid=1036, Description="Suit les interactions entre les agents et le client")]
    Conversationencoursdéconseillé = 10393,
    
    [EnumMember()]
    [OptionSetMetadata("Conversation", Index=31, Lcid=1036, Description="Suit l’interaction entre les agents et le client")]
    Conversation = 10403,
    
    [EnumMember()]
    [OptionSetMetadata("Session", Index=17, Lcid=1036, Description="Session d’interaction avec un client")]
    Session = 10420,
    
    [EnumMember()]
    [OptionSetMetadata("Alerte de réservation", Index=9, Lcid=1036, Description="Les alertes qui notifient les utilisateurs du tableau de planification des problè" +
        "mes de réservation ou des informations relatives à celles-ci.")]
    Alertederéservation = 10561,
    
    [EnumMember()]
    [OptionSetMetadata("Préférence d’exécution", Index=10, Lcid=1036, Description="Spécifiez les groupes d\'heures consistant en plusieurs fenêtres horaires à utilis" +
        "er pour la planification, par exemple.")]
    Préférencedexécution = 10578,
    
    [EnumMember()]
    [OptionSetMetadata("Détail du groupe d\'heures", Index=3, Lcid=1036, Description="Spécifiez les fenêtres horaires individuelles sous un groupe d\'heures.")]
    Détaildugroupedheures = 10579,
    
    [EnumMember()]
    [OptionSetMetadata("Message Espace Client", Index=7, Lcid=1036, Description="")]
    MessageEspaceClient = 10659,
    
    [EnumMember()]
    [OptionSetMetadata("Transcription Copilot", Index=18, Lcid=1036, Description="")]
    TranscriptionCopilot = 11116,
    
    [EnumMember()]
    [OptionSetMetadata("Dossier Client", Index=27, Lcid=1036, Description="")]
    DossierClient = 11226,
    
    [EnumMember()]
    [OptionSetMetadata("Utilisation d’invitation", Index=11, Lcid=1036, Description="Contient les informations concernant l’utilisation d’une invitation.")]
    Utilisationdinvitation = 11297,
    
    [EnumMember()]
    [OptionSetMetadata("Commentaire sur le portail", Index=20, Lcid=1036, Description="Activité permettant de partager des informations entre l’utilisateur et le client" +
        " sur le portail.")]
    Commentairesurleportail = 11298,
}

[DataContract()]
public enum QueueItem_StatusCode {
    
    [EnumMember()]
    [OptionSetMetadata("Actif", Index=1, Lcid=1036)]
    Actif = 1,
    
    [EnumMember()]
    [OptionSetMetadata("Inactif", Index=0, Lcid=1036)]
    Inactif = 2,
}
