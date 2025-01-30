using System.Collections.Generic;

namespace CRM.Shared.PluginBase.Referentials
{
    public static class ErrorMessage
    {
        public static readonly string TechnicalError = "TechnicalError";
        public static readonly string ReferetialNotExist = "ReferetialNotExist";
        public static readonly string InvalidLoanOperation = "InvalidLoanOperation";
        public static readonly string SelectionIsEmpty = "SelectionIsEmpty";
        public static readonly string InvalidProgramValidation = "InvalidProgramValidation";
        public static readonly string InvalidMultipleProgramValidation = "InvalidMultipleProgramValidation";
        public static readonly string RelatedProgramNotExist = "ProgramNotExit";
        public static readonly string InvalidGuidList = "InvalidGuidList";
        public static readonly string InvalidCheckDepositDetails = "InvalidCheckDepositDetails";
        public static readonly string InvalidCheckDepositDetailOperation = "InvalidCheckDepositDetailOperation";
        public static readonly string EmptyParameterError = "EmptyParameterError";

        public static readonly Dictionary<string, string> _1033 = new Dictionary<string, string>
        {
            {TechnicalError,"A technical error occured, please contact your administrator"},
            {InvalidLoanOperation, "Unauthorized Operation : You cannot create, modify or delete a loan for this customer folder because its signature date has been filled." },
            {SelectionIsEmpty, "Unauthorized Operation : You need to select at least one row." },
            {InvalidProgramValidation, "Unauthorized Operation : Your customer folder doesn't belong to the same program" },
            {InvalidMultipleProgramValidation, "Unauthorized Operation : Multiple program has been detected among your selected customer folder" },
            {RelatedProgramNotExist, "Unauthorized Operation : Program is missing among your selected customer folder" },
            {InvalidGuidList, "The list contains an invalid GUID" },
            {InvalidCheckDepositDetails, "Unauthorized Operation : Check deposit details has some missing elements" },
            {InvalidCheckDepositDetailOperation, "Unauthorized Operation : You cannot create, modify or delete a check deposit detail related to an inactif check deposit slip." },
            {EmptyParameterError, "Unauthorized Operation : {0} is empty"}
        };

        public static readonly Dictionary<string, string> _1036 = new Dictionary<string, string>
        {
            {TechnicalError, "Une erreur technique est survenue, merci de contacter votre administrateur. " },
            {ReferetialNotExist,"Le référentiel {0} n'existe pas."},
            {InvalidLoanOperation, "Opération non autorisée : Vous ne pouvez pas créer, modifier ou supprimer un prêt sur ce Dossier Client car une date de signature est renseignée." },
            {SelectionIsEmpty, "Opération non autorisée : Vous devez sélectionner au moins une ligne." },
            {InvalidProgramValidation, "Opération non autorisée : Le Dossier Client sélectionné n’appartient pas au même programme. Veuillez réitérer votre demande en sélectionnant un Dossier Client issus du même programme." },
            {InvalidMultipleProgramValidation, "Opération non autorisée : Les Dossiers Client sélectionnés n’appartiennent pas au même programme. Veuillez réitérer votre demande en sélectionnant des Dossiers Client issus du même programme." },
            {RelatedProgramNotExist, "Opération non autorisée : Aucun programme détecté parmi votre sélection de dossier client." },
            {InvalidGuidList, "La liste contient un GUID non valide." },
            {InvalidCheckDepositDetails, "Opération non autorisée : Certains champs d'un ou des détail(s) du bordereau de chèque ne sont pas renseignés." },
            {InvalidCheckDepositDetailOperation, "Opération non autorisée : Vous ne pouvez pas créer, modifier ou supprimer un détail de bordereau lié à un bordereau inactif." },
            {EmptyParameterError, "Opération non autorisée : {0} is est vide"}
        };
    }
}
