
namespace Tib.Api.Model
{
    public class Enum
    {
      public enum AccountOperationDirectionEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The withdraw
/// </summary>
Withdraw = 1,
/// <summary>
/// The deposit
/// </summary>
Deposit = 2,
}public enum AccountTypeEnum {
    /// <summary>
/// 
/// </summary>
CustomerChecking = 1,
/// <summary>
/// 
/// </summary>
CustomerSaving = 2,
/// <summary>
/// 
/// </summary>
CorporateChecking = 3,
/// <summary>
/// 
/// </summary>
CorporateSaving = 4,
}public enum AcpFileType {
    /// <summary>
/// 
/// </summary>
Acp = 0,
/// <summary>
/// 
/// </summary>
Perceptech = 1,
}public enum AcpOperationTypeEnum {
    /// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The depot liste de paie
/// </summary>
Depot_liste_de_paie = 200,
/// <summary>
/// The liste de paie speciale
/// </summary>
Liste_de_paie_speciale = 201,
/// <summary>
/// The paie de vacances
/// </summary>
Paie_de_vacances = 202,
/// <summary>
/// The paie heures supplementaires pay
/// </summary>
Paie_heures_supplementaires_PAY = 203,
/// <summary>
/// The paie anticipee
/// </summary>
Paie_anticipee = 204,
/// <summary>
/// The paie de commission
/// </summary>
Paie_de_commission = 205,
/// <summary>
/// The paie de prime
/// </summary>
Paie_de_prime = 206,
/// <summary>
/// The paie de rajustement
/// </summary>
Paie_de_rajustement = 207,
/// <summary>
/// The pension
/// </summary>
Pension = 230,
/// <summary>
/// The pension federale pen
/// </summary>
Pension_federale_PEN = 231,
/// <summary>
/// The pension provinciale
/// </summary>
Pension_provinciale = 232,
/// <summary>
/// The pension privee
/// </summary>
Pension_privee = 233,
/// <summary>
/// The rente
/// </summary>
Rente = 240,
/// <summary>
/// The dividende
/// </summary>
Dividende = 250,
/// <summary>
/// The dividende act ordinaires DVD
/// </summary>
Dividende_act_Ordinaires_DVD = 251,
/// <summary>
/// The dividende act privilegiees
/// </summary>
Dividende_act_Privilegiees = 252,
/// <summary>
/// The placement
/// </summary>
Placement = 260,
/// <summary>
/// The fonds mutuels fmu
/// </summary>
Fonds_mutuels_FMU = 261,
/// <summary>
/// The regime epargne retraite contribution rer
/// </summary>
Regime_epargne_retraite_contribution_RER = 271,
/// <summary>
/// The fonds de revenu de retraite FRR
/// </summary>
Fonds_de_revenu_de_retraite_FRR = 272,
/// <summary>
/// The interet
/// </summary>
Interet = 280,
/// <summary>
/// The gouvernement federal
/// </summary>
Gouvernement_federal = 300,
/// <summary>
/// The paiements de stabilisation agriculture agr
/// </summary>
Paiements_de_stabilisation_agriculture_AGR = 301,
/// <summary>
/// The commission canadienne du lait CCL
/// </summary>
Commission_canadienne_du_lait_CCL = 302,
/// <summary>
/// The credit impot pour enfants cie
/// </summary>
Credit_impot_pour_enfants_CIE = 308,
/// <summary>
/// The taxe sur les produits et services TPS
/// </summary>
Taxe_sur_les_produits_et_services_TPS = 309,
/// <summary>
/// The regime de pensions du canada RPC
/// </summary>
Regime_de_pensions_du_Canada_RPC = 310,
/// <summary>
/// The securite de la vieillesse sv
/// </summary>
Securite_de_la_vieillesse_SV = 311,
/// <summary>
/// The allocations aux anciens combattants aac
/// </summary>
Allocations_aux_anciens_combattants_AAC = 312,
/// <summary>
/// The commission DES pensions CCP
/// </summary>
Commission_des_pensions_CCP = 313,
/// <summary>
/// The allocations familiales af
/// </summary>
Allocations_familiales_AF = 314,
/// <summary>
/// The pension de la fonction publique PFP
/// </summary>
Pension_de_la_fonction_publique_PFP = 315,
/// <summary>
/// The pension de retraite DES forces armees PFC
/// </summary>
Pension_de_retraite_des_Forces_armees_PFC = 316,
/// <summary>
/// The remboursement impot rif
/// </summary>
Remboursement_impot_RIF = 317,
/// <summary>
/// The assurance emploi chomage ac
/// </summary>
Assurance_emploi_chomage_AC = 318,
/// <summary>
/// The pret aux etudiants etu
/// </summary>
Pret_aux_etudiants_ETU = 320,
/// <summary>
/// The interet oec oec
/// </summary>
Interet_OEC_OEC = 321,
/// <summary>
/// The affaires exterieures
/// </summary>
Affaires_exterieures = 322,
/// <summary>
/// The assurance
/// </summary>
Assurance = 330,
/// <summary>
/// The assurance vie
/// </summary>
Assurance_vie = 331,
/// <summary>
/// The assurance automobile ass
/// </summary>
Assurance_automobile_ASS = 332,
/// <summary>
/// The assurance biens
/// </summary>
Assurance_biens = 333,
/// <summary>
/// The assurance accidents et risques divers
/// </summary>
Assurance_accidents_et_risques_divers = 334,
/// <summary>
/// The assurance hypothecaire
/// </summary>
Assurance_hypothecaire = 335,
/// <summary>
/// The sante dentaire reclamation ass SDR
/// </summary>
Sante_dentaire_reclamation_ass_SDR = 336,
/// <summary>
/// The prets
/// </summary>
Prets = 350,
/// <summary>
/// The prets personnels
/// </summary>
Prets_personnels = 351,
/// <summary>
/// The prets de plan de vendeur pre
/// </summary>
Prets_de_plan_de_vendeur_PRE = 352,
/// <summary>
/// The prets pour amelioration DES fermes
/// </summary>
Prets_pour_amelioration_des_fermes = 353,
/// <summary>
/// The prets pour amelioration DES residences
/// </summary>
Prets_pour_amelioration_des_residences = 354,
/// <summary>
/// The prets a terme
/// </summary>
Prets_a_terme = 355,
/// <summary>
/// The prets assurance pre
/// </summary>
Prets_assurance_PRE = 356,
/// <summary>
/// The hypotheque
/// </summary>
Hypotheque = 370,
/// <summary>
/// The hypotheque sur residence hyp
/// </summary>
Hypotheque_sur_residence_HYP = 371,
/// <summary>
/// The hypotheque commerciale
/// </summary>
Hypotheque_commerciale = 372,
/// <summary>
/// The hypotheque sur ferme
/// </summary>
Hypotheque_sur_ferme = 373,
/// <summary>
/// The taxes
/// </summary>
Taxes = 380,
/// <summary>
/// The impot sur le revenu
/// </summary>
Impot_sur_le_revenu = 381,
/// <summary>
/// The taxes de vente
/// </summary>
Taxes_de_vente = 382,
/// <summary>
/// The impot sur les corporations tax
/// </summary>
Impot_sur_les_corporations_TAX = 383,
/// <summary>
/// The taxes scolaires
/// </summary>
Taxes_scolaires = 384,
/// <summary>
/// The taxes foncieres
/// </summary>
Taxes_foncieres = 385,
/// <summary>
/// The taxes eau
/// </summary>
Taxes_eau = 386,
/// <summary>
/// The loyers baux
/// </summary>
Loyers_baux = 400,
/// <summary>
/// The loyers baux pour residences
/// </summary>
Loyers_baux_pour_residences = 401,
/// <summary>
/// The loyers baux commerciaux loy
/// </summary>
Loyers_baux_commerciaux_LOY = 402,
/// <summary>
/// The loyers baux materiel
/// </summary>
Loyers_baux_materiel = 403,
/// <summary>
/// The loyers baux automobile
/// </summary>
Loyers_baux_automobile = 404,
/// <summary>
/// The loyers baux appareils
/// </summary>
Loyers_baux_appareils = 405,
/// <summary>
/// The gestion espÃ¨ces
/// </summary>
Gestion_espÃ = 420,
/// <summary>
/// The paiement de facture de telephone
/// </summary>
Paiement_de_facture_de_telephone = 431,
/// <summary>
/// The paiement de facture essence
/// </summary>
Paiement_de_facture_essence = 432,
/// <summary>
/// The paiement de facture electricite fac
/// </summary>
Paiement_de_facture_electricite_FAC = 433,
/// <summary>
/// The paiement de facture de cable
/// </summary>
Paiement_de_facture_de_cable = 434,
/// <summary>
/// The paiement de facture de combustible
/// </summary>
Paiement_de_facture_de_combustible = 435,
/// <summary>
/// The paiement de facture entreprise de services publics
/// </summary>
Paiement_de_facture_entreprise_de_services_publics = 436,
/// <summary>
/// The paiement acces internet pai
/// </summary>
Paiement_acces_Internet_PAI = 437,
/// <summary>
/// The paiments divers
/// </summary>
Paiments_divers = 450,
/// <summary>
/// The cheques DES clients CHP
/// </summary>
Cheques_des_clients_CHP = 451,
/// <summary>
/// The remboursement de depenses RDD
/// </summary>
Remboursement_de_depenses_RDD = 452,
/// <summary>
/// The comptes debiteurs cc
/// </summary>
Comptes_debiteurs_CC = 460,
/// <summary>
/// The frais fee
/// </summary>
Frais_FEE = 470,
/// <summary>
/// The don don
/// </summary>
Don_DON = 480,
/// <summary>
/// The gouvernement provincial
/// </summary>
Gouvernement_provincial = 600,
/// <summary>
/// The regime DES obligations familiales rof
/// </summary>
Regime_des_obligations_familiales_ROF = 601,
/// <summary>
/// The allocation logement log
/// </summary>
Allocation_logement_LOG = 602,
/// <summary>
/// The prestation securite du revenu PSR
/// </summary>
Prestation_securite_du_revenu_PSR = 603,
/// <summary>
/// The prestation familiale provinciale pfa
/// </summary>
Prestation_familiale_provinciale_PFA = 604,
/// <summary>
/// The paiement entente federale provinciale FPT
/// </summary>
Paiement_entente_federale_provinciale_FPT = 605,
/// <summary>
/// The CSST CST
/// </summary>
CSST_CST = 606,
/// <summary>
/// The allocation aide a emploi aae
/// </summary>
Allocation_aide_a_emploi_AAE = 607,
/// <summary>
/// The regime assurance automobile raa
/// </summary>
Regime_assurance_automobile_RAA = 608,
/// <summary>
/// The dpa entreprise
/// </summary>
DPA_entreprise = 700,
/// <summary>
/// The commercial placements
/// </summary>
Commercial_Placements = 701,
/// <summary>
/// The commercial assurance ase
/// </summary>
Commercial_Assurance_ASE = 702,
/// <summary>
/// The commercial assurance automobile aue
/// </summary>
Commercial_Assurance_automobile_AUE = 703,
/// <summary>
/// The commercial assurance de biens abe
/// </summary>
Commercial_Assurance_de_biens_ABE = 704,
/// <summary>
/// The commercial assurance iard are
/// </summary>
Commercial_Assurance_IARD_ARE = 705,
/// <summary>
/// The commercial assurance hypothecaire ahe
/// </summary>
Commercial_Assurance_hypothecaire_AHE = 706,
/// <summary>
/// The commercial prets pee
/// </summary>
Commercial_Prets_PEE = 707,
/// <summary>
/// The commercial pret hypothecaire hye
/// </summary>
Commercial_Pret_hypothecaire_HYE = 708,
/// <summary>
/// The commercial taxes txe
/// </summary>
Commercial_Taxes_TXE = 709,
/// <summary>
/// The commercial impots sur le revenu ire
/// </summary>
Commercial_Impots_sur_le_revenu_IRE = 710,
/// <summary>
/// The commercial taxes de vente tve
/// </summary>
Commercial_Taxes_de_vente_TVE = 711,
/// <summary>
/// The commercial TPS tpe
/// </summary>
Commercial_TPS_TPE = 712,
/// <summary>
/// The commercial taxes foncieres tfe
/// </summary>
Commercial_Taxes_foncieres_TFE = 713,
/// <summary>
/// The commercial loyer bail lbe
/// </summary>
Commercial_Loyer_bail_LBE = 714,
/// <summary>
/// The commercial location de materiel lbe
/// </summary>
Commercial_Location_de_materiel_LBE = 715,
/// <summary>
/// The commercial location automobile lae
/// </summary>
Commercial_Location_automobile_LAE = 716,
}public enum AcpTransactionTypeEnum {
    /// <summary>
/// The collection
/// </summary>
Collection = 0,
/// <summary>
/// The deposit
/// </summary>
Deposit = 1,
}public enum AutorizedPaymentMethodFlags {
    /// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The credit card
/// </summary>
CreditCard = 1,
/// <summary>
/// The direct account
/// </summary>
DirectAccount = 2,
/// <summary>
/// Autorzation to get credit card in PPA
/// </summary>
CreditCardPPA = 4,
/// <summary>
/// Autorisation to get DirectAccount in ppa
/// </summary>
DirectAccountPPA = 8,
/// <summary>
/// The Interac account
/// </summary>
Interac = 16,
}public enum BankingOperationResultEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The confirmed
/// </summary>
Confirmed = 1,
/// <summary>
/// The error other
/// </summary>
ErrorOther = 2,
/// <summary>
/// The no fund
/// </summary>
NoFund = 3,
/// <summary>
/// The account error
/// </summary>
AccountError = 4,
/// <summary>
/// The opposition
/// </summary>
Opposition = 5,
/// <summary>
/// The Interac transaction has been refused by the destination
/// </summary>
InteracRefused = 6,
/// <summary>
/// Interac transaction interrupted
/// </summary>
InteracFailed = 7,
}public enum BoardingDocTypeEnum {
    /// <summary>
/// 
/// </summary>
unknown = -1,
/// <summary>
/// 
/// </summary>
notSet = 0,
/// <summary>
/// 
/// </summary>
companyIdentificationProof = 1,
/// <summary>
/// 
/// </summary>
bankAccountIdentificationProof = 2,
/// <summary>
/// 
/// </summary>
person1IdentificationProof = 3,
/// <summary>
/// 
/// </summary>
person2IdentificationProof = 4,
/// <summary>
/// 
/// </summary>
shareholder1IdentificationProof = 5,
/// <summary>
/// 
/// </summary>
shareholder2IdentificationProof = 6,
/// <summary>
/// 
/// </summary>
shareholder3IdentificationProof = 7,
/// <summary>
/// 
/// </summary>
shareholder4IdentificationProof = 8,
}public enum BoardingIdFileSidesEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
Front = 1,
/// <summary>
/// 
/// </summary>
Back = 2,
}public enum BoardingStatusEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
Draft = 1,
/// <summary>
/// 
/// </summary>
Submit = 11,
/// <summary>
/// 
/// </summary>
InReview = 12,
/// <summary>
/// 
/// </summary>
Completed = 13,
/// <summary>
/// 
/// </summary>
ValidationError = 21,
/// <summary>
/// 
/// </summary>
DocumentsRequired = 22,
/// <summary>
/// 
/// </summary>
Rejected = 23,
/// <summary>
/// 
/// </summary>
DocumentsSubmitted = 24,
}public enum BoardingStepEnum {
    /// <summary>
/// The unkown
/// </summary>
CompanyInfoRejected = -2,
/// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// Client successfully created
/// </summary>
ClientCreated = 1,
/// <summary>
/// Login info created (Signup)
/// </summary>
LoginCreated = 2,
/// <summary>
/// Company info validated
/// </summary>
CompanyInfoToValidate = 3,
/// <summary>
/// Company info validated
/// </summary>
CompanyInfoValidated = 4,
}public enum CheckFeesModeEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The fees on each call
/// </summary>
FeesOnEachCall = 0,
/// <summary>
/// The fees on each call only found
/// </summary>
FeesOnEachCallOnlyFound = 1,
/// <summary>
/// The once per month
/// </summary>
OncePerMonth = 2,
/// <summary>
/// The once per month only if found
/// </summary>
OncePerMonthOnlyIfFound = 3,
/// <summary>
/// The no fees
/// </summary>
NoFees = 4,
}public enum ClientAuthorizationStatus {
    /// <summary>
/// This state mean that the client autorization is not required
/// </summary>
NotRequired = 0,
/// <summary>
/// This state is mean that the client need to approved the transfer
/// </summary>
NeedApprobation = 1,
/// <summary>
/// This state mean that the transfer is approved by the client, refer the the field ClientApprovedBy to know who approved the transfer
/// </summary>
Approved = 2,
/// <summary>
/// This state is rejected by the client
/// </summary>
Rejected = 3,
}public enum CompanyTypeEnum {
    /// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
JointStockCompany = 1,
/// <summary>
/// 
/// </summary>
LimitedCompany = 2,
/// <summary>
/// 
/// </summary>
Partnership = 3,
/// <summary>
/// 
/// </summary>
PublicCompany = 4,
/// <summary>
/// 
/// </summary>
PublicAdministration = 5,
/// <summary>
/// 
/// </summary>
NonprofitOrganization = 6,
/// <summary>
/// 
/// </summary>
SoleProprietorship = 7,
}public enum ContractEditionRequestStatusEnum {
    /// <summary>
/// request have not been processed yet
/// </summary>
Waiting = 1,
/// <summary>
/// request have been processed
/// </summary>
Processed = 2,
}public enum ContractRequestStatusEnum {
    /// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// Request wating for processing
/// </summary>
Waiting = 1,
/// <summary>
/// Request has been processed
/// </summary>
Processed = 2,
}public enum ConvenientFeeModeEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The no fee authorized
/// </summary>
NoFeeAuthorized = 1,
/// <summary>
/// Will round up the amount first to a the upper multiple then apply percentage on this amount then add the absolute value as a fix value. Price: 132.22$, RoundUp: 0.01 (132.23$), Percentage: 10%, Absolute: 5$. Fee = 13.23$ + 5$ = 18.23$ Price: 132.22$, RoundUp: 1 (133$), Percentage: 10%, Absolute: 5$. Fee = 13.30$ + 5$ = 18.30$ Price: 132.22$, RoundUp: 50 (150$), Percentage: 10%, Absolute: 5$. Fee = 15.00$ + 5$ = 20.00$ Price: 132.22$, RoundUp: 100 (200$), Percentage: 10%, Absolute: 5$. Fee = 20$ + 5$ = 25$
/// </summary>
FeeWithRoundupOnPercentage = 2,
/// <summary>
/// First divide the amount by the roundup value and round the result to upper interger. This gives the number of times the roundup value fit in the value. There, multiply the absolute value by the number of slice and add percentage of the full amount (to round up the percentage result to 2 decimals). Price: 132.22$, RoundUp: 0.01 (13222 slices), Percentage: 10%, Absolute: 5$. Fee = 13.33$ + 66110$ = 66123.33$ Price: 132.22$, RoundUp: 1 (133 slices), Percentage: 10%, Absolute: 5$. Fee = 13.33$ + 665 = 678.33$ Price: 132.22$, RoundUp: 50 (3 slices), Percentage: 10%, Absolute: 5$. Fee = 13.33$ + 15$ = 28.33$ Price: 132.22$, RoundUp: 100 (2 slices), Percentage: 10%, Absolute: 5$. Fee = 13.33$ + 10$ = 23.33$
/// </summary>
FeeWithRoundupOnAbsolute = 3,
/// <summary>
/// All the merchant service fee must be fix, RelativeToPaymentTypeFee is not supported. The Percentage and Absolute are added to the merchant fee. They can be zero to only follow the merchant fees. The roundup position never apply
/// </summary>
RelativeToPaymentTypeFee = 4,
}public enum ConvenientFeeSettingStatusEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
Active = 1,
/// <summary>
/// 
/// </summary>
Inactive = 2,
/// <summary>
/// 
/// </summary>
Deleted = 3,
}public enum CountryIdEnum {
    /// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The canada
/// </summary>
Canada = 1,
/// <summary>
/// The usa
/// </summary>
USA = 2,
}public enum CredentialTypeEnum {
    /// <summary>
/// 
/// </summary>
AccountCollect = 1,
/// <summary>
/// 
/// </summary>
PasswordCollect = 2,
/// <summary>
/// 
/// </summary>
AccountDeposit = 3,
/// <summary>
/// 
/// </summary>
PasswordDeposit = 4,
/// <summary>
/// 
/// </summary>
Address = 5,
/// <summary>
/// 
/// </summary>
KeyValuePair = 6,
/// <summary>
/// 
/// </summary>
Question = 7,
/// <summary>
/// 
/// </summary>
ProviderId = 8,
/// <summary>
/// 
/// </summary>
MerchantCredentials = 9,
}public enum CurrencyEnum {
    /// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The cad
/// </summary>
CAD = 1,
/// <summary>
/// The usd
/// </summary>
USD = 2,
/// <summary>
/// 
/// </summary>
EUR = 3,
/// <summary>
/// 
/// </summary>
GBP = 4,
}public enum DasFieldTypeEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
IdentificationNumber = 1,
/// <summary>
/// 
/// </summary>
FileType = 2,
/// <summary>
/// 
/// </summary>
FileNumber = 3,
/// <summary>
/// 
/// </summary>
DeclarationFrequency = 4,
/// <summary>
/// 
/// </summary>
Description = 5,
/// <summary>
/// 
/// </summary>
BusinessName = 6,
/// <summary>
/// 
/// </summary>
BusinessOrAccountNumber = 7,
/// <summary>
/// 
/// </summary>
PeriodStartDate = 8,
/// <summary>
/// 
/// </summary>
PeriodStartMonth = 9,
/// <summary>
/// 
/// </summary>
PeriodStartYear = 10,
/// <summary>
/// 
/// </summary>
PeriodEndDate = 11,
/// <summary>
/// 
/// </summary>
PeriodEndMonth = 12,
/// <summary>
/// 
/// </summary>
PeriodEndYear = 13,
/// <summary>
/// 
/// </summary>
WithhodingTax = 14,
/// <summary>
/// 
/// </summary>
RetirementPensionPlan = 15,
/// <summary>
/// 
/// </summary>
HealthServiceFund = 16,
/// <summary>
/// 
/// </summary>
ParentalInsurancePlan = 17,
/// <summary>
/// 
/// </summary>
CNESST = 18,
/// <summary>
/// 
/// </summary>
LastPayPeriodEmployeeCount = 19,
/// <summary>
/// 
/// </summary>
PeriodRawRemuneration = 20,
/// <summary>
/// 
/// </summary>
PaymentAmount = 21,
}public enum DasKeyValuePropertyTypeEnum {
    /// <summary>
/// 
/// </summary>
StringValue = 0,
/// <summary>
/// 
/// </summary>
IntValue = 1,
/// <summary>
/// 
/// </summary>
DecimalValue = 2,
/// <summary>
/// 
/// </summary>
DasDate = 3,
/// <summary>
/// 
/// </summary>
DasMonthlyDate = 4,
}public enum DasPaymentProcessStatusEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
New = 1,
/// <summary>
/// 
/// </summary>
MoneyCollected = 2,
/// <summary>
/// 
/// </summary>
ReadyToSend = 3,
/// <summary>
/// 
/// </summary>
PaymentSent = 4,
/// <summary>
/// 
/// </summary>
PaymentAccepted = 5,
/// <summary>
/// 
/// </summary>
Cancelled = 10,
/// <summary>
/// 
/// </summary>
Reverted = 11,
/// <summary>
/// 
/// </summary>
ErrorCollectingMoney = 100,
/// <summary>
/// 
/// </summary>
ErrorPreparingPayment = 101,
/// <summary>
/// 
/// </summary>
ErrorSendingPayment = 102,
}public enum DasProviderCanadaDeclarationFrequencyEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
Weekly = 1,
/// <summary>
/// 
/// </summary>
TwiceMonthly = 2,
/// <summary>
/// 
/// </summary>
Monthly = 3,
/// <summary>
/// 
/// </summary>
Quarterly = 4,
}public enum DasProviderCanadaFileTypeEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
FileType_RP = 1,
}public enum DasProviderQuebecDeclarationFrequencyEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
Weekly = 1,
/// <summary>
/// 
/// </summary>
TwiceMonthly = 2,
/// <summary>
/// 
/// </summary>
Monthly = 3,
/// <summary>
/// 
/// </summary>
Quarterly = 4,
/// <summary>
/// 
/// </summary>
Annually = 5,
}public enum DasProviderQuebecFileTypeEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
FileType_RS = 1,
/// <summary>
/// 
/// </summary>
FileType_11 = 2,
}public enum DasProviderTypeEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
RevenuQuebec = 1,
/// <summary>
/// 
/// </summary>
CanadaRevenueAgancy = 2,
}public enum DataSummaryAggregationCategoryEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The today collections
/// </summary>
TodayCollections = 1,
/// <summary>
/// The today deposits
/// </summary>
TodayDeposits = 2,
/// <summary>
/// The today cashback
/// </summary>
TodayCashback = 3,
/// <summary>
/// The pending collections
/// </summary>
PendingCollections = 4,
/// <summary>
/// The pending deposits
/// </summary>
PendingDeposits = 5,
}public enum DateTypeEnum {
    /// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
CreatedDate = 1,
/// <summary>
/// 
/// </summary>
LastModifiedDate = 2,
}public enum DeletedPublicTokenReasonEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
Consumed = 1,
/// <summary>
/// 
/// </summary>
Expired = 2,
/// <summary>
/// 
/// </summary>
Canceled = 3,
/// <summary>
/// 
/// </summary>
WeSentYouNewLogin = 9,
}public enum ErrorCodeEnum {
    /// <summary>
/// 
/// </summary>
InsufficientBalance = 2000,
/// <summary>
/// 
/// </summary>
TransmissionError = 2001,
/// <summary>
/// 
/// </summary>
NotValid = 2003,
}public enum EventToBroadcastTypeEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
TransactionEventToBroadcast = 1,
/// <summary>
/// 
/// </summary>
BatchFileEventToBroadcast = 2,
/// <summary>
/// 
/// </summary>
BoardingEventToBroadcast = 3,
/// <summary>
/// 
/// </summary>
TransferPendingProcessEventToBroadcast = 4,
}public enum FeatureToggleTypeEnum {
    /// <summary>
/// 
/// </summary>
Unknown = -1,
/// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
ftr_wallet = 1,
/// <summary>
/// 
/// </summary>
NewWallet = 2,
}public enum FeeModeEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The fix
/// </summary>
Fix = 1,
/// <summary>
/// The relative to payment type fee
/// </summary>
RelativeToPaymentTypeFee = 2,
/// <summary>
/// 
/// </summary>
FixUsingRoundUp = 3,
}public enum FinancialSettingsDataContextEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// Use for Settings only, not use by FeeSettings. When NEW CLIENT is created, it is created with this Setting. So there will have an entry inside FinancialExecutionBehaviorSettings with DataContext 3 and the related clientId with a copy of the entry with DataContext 1.
/// </summary>
DefaultClientSettings = 1,
/// <summary>
/// Used by Settings and FeeSettings. Understanding the "settings" and "fee settings" for all sub services of a client are set at client level (except if overrided specifically), when a NEW CLIENT is created, it copy the DataContext 2 into DataContext 4 with related client ID. There is an entry into FinancialExecutionBehaviorSettings and FinancialExecutionBehaviorFeeSettings. Wo once client is created, the default service settings for this client ID is set.
/// </summary>
DefaultClientServiceSettings = 2,
/// <summary>
/// Use for Settings only, not use by FeeSettings. This entry is created for client level limits. Meaning as example if the 3 service has 100k, but client level is to 200k the sum of all service usage cannot exceed the limit set for the client. This is auto created with DefaultClientSettings values.
/// </summary>
ClientSettings = 3,
/// <summary>
/// Used by Settings and FeeSettings. Once client is created, it pushes the service level "settings" and "fee settings" for this client (Based on DataContext 2 values). Meaning all the services under this client will have the same common limit.
/// </summary>
ClientDefaultServiceSettings = 4,
/// <summary>
/// Used by Settings and FeeSettings. This allow to override the settings or FeeSettings for a service. All client's service have the settings and fee settings using the DataContext 4 (with ClientId into RelatedId). If a service has different settings or fee settings, there will have a DataContext 5 with "Service ID" into RelatedId.
/// </summary>
ServiceSettings = 5,
/// <summary>
/// 
/// </summary>
MerchantSettings = 6,
}public enum FlagPermission {
    /// <summary>
/// The none
/// </summary>
None = 0,
/// <summary>
/// The admin
/// </summary>
Admin = 1,
/// <summary>
/// The client
/// </summary>
Client = 2,
/// <summary>
/// The merchant
/// </summary>
Merchant = 4,
/// <summary>
/// The customer
/// </summary>
Customer = 8,
/// <summary>
/// The service
/// </summary>
Service = 16,
}public enum FreeDepositAccountTypeEnum {
    /// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The direct to account
/// </summary>
DirectToAccount = 1,
/// <summary>
/// The related to customer
/// </summary>
RelatedToCustomer = 2,
}public enum GetReferenceInformationTypeEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
Service = 1,
}public enum IPNType {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
MERCHANT_PARTNER_ONBOARDED = 1,
/// <summary>
/// 
/// </summary>
APPLICATION_DOCUMENT_REQUEST = 2,
/// <summary>
/// 
/// </summary>
CHARGEBACK_FILE_UPLOADED = 3,
}public enum JobEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
OperationCreation = 1,
}public enum LanguageEnum {
    /// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The french
/// </summary>
French = 1,
/// <summary>
/// The english
/// </summary>
English = 2,
}public enum LineTypeEnum {
    /// <summary>
/// Start of file
/// </summary>
A = 1,
/// <summary>
/// Debit (collect into account)
/// </summary>
D = 2,
/// <summary>
/// Credit (deposit into account)
/// </summary>
C = 3,
/// <summary>
/// End of file
/// </summary>
Z = 4,
}public enum LoginType {
    /// <summary>
/// The none
/// </summary>
NotSet = 0,
/// <summary>
/// The admin
/// </summary>
Admin = 1,
/// <summary>
/// The client
/// </summary>
Client = 2,
/// <summary>
/// The merchant
/// </summary>
Merchant = 4,
/// <summary>
/// The customer
/// </summary>
Customer = 8,
/// <summary>
/// The service
/// </summary>
Service = 16,
}public enum OperationCategoryReportType {
    /// <summary>
/// The deposit
/// </summary>
Deposit = 0,
/// <summary>
/// The collection
/// </summary>
Collection = 1,
/// <summary>
/// The transmitted
/// </summary>
Transmitted = 2,
/// <summary>
/// The bill
/// </summary>
Bill = 3,
/// <summary>
/// The cancel fast
/// </summary>
CancelFast = 4,
/// <summary>
/// The cancel late
/// </summary>
CancelLate = 5,
/// <summary>
/// The payback
/// </summary>
Payback = 6,
/// <summary>
/// The transaction
/// </summary>
Transaction = 7,
/// <summary>
/// 
/// </summary>
UserCanceled = 8,
}public enum OperationKindEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The payment
/// </summary>
Payment = 1,
/// <summary>
/// The free deposit
/// </summary>
FreeDeposit = 2,
/// <summary>
/// The free collection
/// </summary>
FreeCollection = 3,
/// <summary>
/// The fee payment
/// </summary>
FeePayment = 4,
/// <summary>
/// The fee free deposit
/// </summary>
FeeFreeDeposit = 5,
/// <summary>
/// The fee free collection
/// </summary>
FeeFreeCollection = 6,
/// <summary>
/// The return charge
/// </summary>
ReturnCharge = 10,
/// <summary>
/// The file fees
/// </summary>
FileFees = 11,
/// <summary>
/// The refund
/// </summary>
Refund = 12,
/// <summary>
/// The tib collect
/// </summary>
TibCollect = 13,
/// <summary>
/// The account check NSF fees
/// </summary>
AccountCheckNsfFees = 14,
/// <summary>
/// The account check opposition fees
/// </summary>
AccountCheckOppositionFees = 15,
/// <summary>
/// The account check NSF fees hit
/// </summary>
AccountCheckNsfFeesHit = 16,
/// <summary>
/// The account check opposition fees hit
/// </summary>
AccountCheckOppositionFeesHit = 17,
/// <summary>
/// The reverse charge
/// </summary>
FeeReverseCharge = 18,
/// <summary>
/// The reverted operation
/// </summary>
RevertedOperation = 19,
/// <summary>
/// ConvenientFee deposit operation
/// </summary>
ConvenientFee = 20,
/// <summary>
/// 
/// </summary>
RevertConvenientFee = 21,
/// <summary>
/// 
/// </summary>
PlatformFee = 22,
/// <summary>
/// 
/// </summary>
GatewayUsageFee = 23,
/// <summary>
/// 
/// </summary>
SupportFee = 24,
/// <summary>
/// 
/// </summary>
WalletCollect = 25,
/// <summary>
/// The reverted operation
/// </summary>
GroupedFees = 100,
/// <summary>
/// 
/// </summary>
FeesRetransfer = 101,
}public enum OperationStatusEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The success success
/// </summary>
Success_Success = 1,
/// <summary>
/// The success no result returned
/// </summary>
Success_NoResultReturned = 2,
/// <summary>
/// The success skip
/// </summary>
Success_Skip = 3,
/// <summary>
/// The success wait manual
/// </summary>
Success_WaitManual = 4,
/// <summary>
/// The success error
/// </summary>
Success_Error = 10,
/// <summary>
/// The error temporary
/// </summary>
Error_Temporary = 11,
/// <summary>
/// The error fatal
/// </summary>
Error_Fatal = 12,
/// <summary>
/// The transaction is abort
/// </summary>
Abort = 13,
}public enum OperationTargetEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The client
/// </summary>
Client = 1,
/// <summary>
/// The merchant
/// </summary>
Merchant = 2,
/// <summary>
/// The tib client
/// </summary>
TibClient = 3,
/// <summary>
/// Internal Wallet
/// </summary>
Wallet = 4,
/// <summary>
/// The tib
/// </summary>
Tib = 100,
}public enum OperationTypeEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The validation
/// </summary>
Validation = 1,
/// <summary>
/// The transmission
/// </summary>
Transmission = 2,
/// <summary>
/// The status check
/// </summary>
StatusCheck = 3,
/// <summary>
/// The payback
/// </summary>
Payback = 4,
}public enum OwnerTypeEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
Tib = 1,
/// <summary>
/// 
/// </summary>
Client = 2,
}public enum PadDirectionEnum {
    /// <summary>
/// 
/// </summary>
Left = 0,
/// <summary>
/// 
/// </summary>
Right = 1,
}public enum PaymentFilterLevelEnum {
    /// <summary>
/// The service
/// </summary>
Service = 0,
/// <summary>
/// The merchant
/// </summary>
Merchant = 1,
/// <summary>
/// The bill
/// </summary>
Bill = 2,
}public enum PaymentFlowEnum {
    /// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// Payment must be send to user for online entry
/// </summary>
AnonymousOnlinePayment = 1,
/// <summary>
/// Payment must be send to user for online entry. User must select payment method saved under his information in portal. He cannot manage payment method
/// </summary>
KnownCustomerMustUsePresavedPaymentMethod = 2,
/// <summary>
/// Payment must be send to user for online entry. User can select, add, edit, remove payment method and can also set enter volatile payment method
/// </summary>
KnownCustomerCanManagePaymentMethod = 3,
/// <summary>
/// Same than KnownCustomerCanManagePaymentMethod except the user can select desired default payment to be used as automatic payment.
/// </summary>
KnownCustomerCanSetAutoPaymentMethod = 4,
/// <summary>
/// The payment is not available for gateway and will be processed automatically without user action. The customer must possess a profil with autopayment defined.
/// </summary>
KnownCustomerAutoPaymentUsingPreference = 5,
/// <summary>
/// The payment is not available for gateway and will be processed automatically without user action. Must specify the payment method related to the customer.
/// </summary>
KnownCustomerAutoPaymentForcePaymentMethod = 6,
/// <summary>
/// Select the most permissive gateway based on the profil and bill information
/// </summary>
AutoSelectEasier = 7,
/// <summary>
/// Select the most permissive gateway based on the profil and bill information, ignoring the AutoPayment possibilities
/// </summary>
AutoSelectEasierExceptAutoPayment = 8,
}public enum PaymentFlowParsingResultEnum {
    /// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The no error
/// </summary>
NoError = 0,
/// <summary>
/// The success
/// </summary>
Success = 1,
/// <summary>
/// The invalid payment flow
/// </summary>
InvalidPaymentFlow = 2,
/// <summary>
/// The bill not related to known customer
/// </summary>
BillNotRelatedToKnownCustomer = 3,
/// <summary>
/// The bill known customer has no payment method
/// </summary>
BillKnownCustomerHasNoPaymentMethod = 4,
/// <summary>
/// The bill known customer has no automatic payment set
/// </summary>
BillKnownCustomerHasNoAutoPaymentSet = 5,
/// <summary>
/// The forced payment method identifier needed
/// </summary>
ForcedPaymentMethodIdNeeded = 6,
/// <summary>
/// The bill known customer doesnt have specified payment method identifier
/// </summary>
BillKnownCustomerDoesntHaveSpecifiedPaymentMethodId = 7,
/// <summary>
/// The anonymous must have email
/// </summary>
AnonymousMustHaveEmail = 8,
/// <summary>
/// PaymentMethod is not Authorized for PPA (preauthorized automatic payment) Payment
/// </summary>
CustomerPPAConsentIsNeeded = 9,
}public enum PaymentMethodTypeEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The credit card
/// </summary>
CreditCard = 1,
/// <summary>
/// The direct account
/// </summary>
DirectAccount = 2,
/// <summary>
/// Interac account
/// </summary>
Interac = 3,
}public enum PaymentMethodTypeFlag {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
CreditCard = 1,
/// <summary>
/// 
/// </summary>
DirectAccount = 2,
/// <summary>
/// 
/// </summary>
Interac = 4,
}public enum ProcessStatusEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The new
/// </summary>
New = 1,
/// <summary>
/// The collect validation success success
/// </summary>
Collect_Validation_Success_Success = 2,
/// <summary>
/// The collect validation success no result returned
/// </summary>
Collect_Validation_Success_NoResultReturned = 3,
/// <summary>
/// The collect validation success skip
/// </summary>
Collect_Validation_Success_Skip = 4,
/// <summary>
/// The collect validation success wait manual
/// </summary>
Collect_Validation_Success_WaitManual = 5,
/// <summary>
/// The collect validation success error
/// </summary>
Collect_Validation_Success_Error = 6,
/// <summary>
/// The collect validation error temporary
/// </summary>
Collect_Validation_Error_Temporary = 7,
/// <summary>
/// The collect validation error fatal
/// </summary>
Collect_Validation_Error_Fatal = 8,
/// <summary>
/// The collect transmission success success
/// </summary>
Collect_Transmission_Success_Success = 9,
/// <summary>
/// The collect transmission success no result returned
/// </summary>
Collect_Transmission_Success_NoResultReturned = 10,
/// <summary>
/// The collect transmission success skip
/// </summary>
Collect_Transmission_Success_Skip = 11,
/// <summary>
/// The collect transmission success wait manual
/// </summary>
Collect_Transmission_Success_WaitManual = 12,
/// <summary>
/// The collect transmission success error
/// </summary>
Collect_Transmission_Success_Error = 13,
/// <summary>
/// The collect transmission error temporary
/// </summary>
Collect_Transmission_Error_Temporary = 14,
/// <summary>
/// The collect transmission error fatal
/// </summary>
Collect_Transmission_Error_Fatal = 15,
/// <summary>
/// The collect status check success success
/// </summary>
Collect_StatusCheck_Success_Success = 16,
/// <summary>
/// The collect status check success no result returned
/// </summary>
Collect_StatusCheck_Success_NoResultReturned = 17,
/// <summary>
/// The collect status check success skip
/// </summary>
Collect_StatusCheck_Success_Skip = 18,
/// <summary>
/// The collect status check success wait manual
/// </summary>
Collect_StatusCheck_Success_WaitManual = 19,
/// <summary>
/// The collect status check success error
/// </summary>
Collect_StatusCheck_Success_Error = 20,
/// <summary>
/// The collect status check error temporary
/// </summary>
Collect_StatusCheck_Error_Temporary = 21,
/// <summary>
/// The collect status check error fatal
/// </summary>
Collect_StatusCheck_Error_Fatal = 22,
/// <summary>
/// The collect payback success success
/// </summary>
Collect_Payback_Success_Success = 23,
/// <summary>
/// The collect payback success no result returned
/// </summary>
Collect_Payback_Success_NoResultReturned = 24,
/// <summary>
/// The collect payback success skip
/// </summary>
Collect_Payback_Success_Skip = 25,
/// <summary>
/// The collect payback success wait manual
/// </summary>
Collect_Payback_Success_WaitManual = 26,
/// <summary>
/// The collect payback success error
/// </summary>
Collect_Payback_Success_Error = 27,
/// <summary>
/// The collect payback error temporary
/// </summary>
Collect_Payback_Error_Temporary = 28,
/// <summary>
/// The collect payback error fatal
/// </summary>
Collect_Payback_Error_Fatal = 29,
/// <summary>
/// The deposit validation success success
/// </summary>
Deposit_Validation_Success_Success = 30,
/// <summary>
/// The deposit validation success no result returned
/// </summary>
Deposit_Validation_Success_NoResultReturned = 31,
/// <summary>
/// The deposit validation success skip
/// </summary>
Deposit_Validation_Success_Skip = 32,
/// <summary>
/// The deposit validation success wait manual
/// </summary>
Deposit_Validation_Success_WaitManual = 33,
/// <summary>
/// The deposit validation success error
/// </summary>
Deposit_Validation_Success_Error = 34,
/// <summary>
/// The deposit validation error temporary
/// </summary>
Deposit_Validation_Error_Temporary = 35,
/// <summary>
/// The deposit validation error fatal
/// </summary>
Deposit_Validation_Error_Fatal = 36,
/// <summary>
/// The deposit transmission success success
/// </summary>
Deposit_Transmission_Success_Success = 37,
/// <summary>
/// The deposit transmission success no result returned
/// </summary>
Deposit_Transmission_Success_NoResultReturned = 38,
/// <summary>
/// The deposit transmission success skip
/// </summary>
Deposit_Transmission_Success_Skip = 39,
/// <summary>
/// The deposit transmission success wait manual
/// </summary>
Deposit_Transmission_Success_WaitManual = 40,
/// <summary>
/// The deposit transmission success error
/// </summary>
Deposit_Transmission_Success_Error = 41,
/// <summary>
/// The deposit transmission error temporary
/// </summary>
Deposit_Transmission_Error_Temporary = 42,
/// <summary>
/// The deposit transmission error fatal
/// </summary>
Deposit_Transmission_Error_Fatal = 43,
/// <summary>
/// The deposit status check success success
/// </summary>
Deposit_StatusCheck_Success_Success = 44,
/// <summary>
/// The deposit status check success no result returned
/// </summary>
Deposit_StatusCheck_Success_NoResultReturned = 45,
/// <summary>
/// The deposit status check success skip
/// </summary>
Deposit_StatusCheck_Success_Skip = 46,
/// <summary>
/// The deposit status check success wait manual
/// </summary>
Deposit_StatusCheck_Success_WaitManual = 47,
/// <summary>
/// The deposit status check success error
/// </summary>
Deposit_StatusCheck_Success_Error = 48,
/// <summary>
/// The deposit status check error temporary
/// </summary>
Deposit_StatusCheck_Error_Temporary = 49,
/// <summary>
/// The deposit status check error fatal
/// </summary>
Deposit_StatusCheck_Error_Fatal = 50,
/// <summary>
/// The deposit payback success success
/// </summary>
Deposit_Payback_Success_Success = 51,
/// <summary>
/// The deposit payback success no result returned
/// </summary>
Deposit_Payback_Success_NoResultReturned = 52,
/// <summary>
/// The deposit payback success skip
/// </summary>
Deposit_Payback_Success_Skip = 53,
/// <summary>
/// The deposit payback success wait manual
/// </summary>
Deposit_Payback_Success_WaitManual = 54,
/// <summary>
/// The deposit payback success error
/// </summary>
Deposit_Payback_Success_Error = 55,
/// <summary>
/// The deposit payback error temporary
/// </summary>
Deposit_Payback_Error_Temporary = 56,
/// <summary>
/// The deposit payback error fatal
/// </summary>
Deposit_Payback_Error_Fatal = 57,
/// <summary>
/// The collect validation not set
/// </summary>
Collect_Validation_NotSet = 100,
/// <summary>
/// The collect transmission not set
/// </summary>
Collect_Transmission_NotSet = 101,
/// <summary>
/// The collect status check not set
/// </summary>
Collect_StatusCheck_NotSet = 102,
/// <summary>
/// The collect payback not set
/// </summary>
Collect_Payback_NotSet = 103,
/// <summary>
/// The deposit validation not set
/// </summary>
Deposit_Validation_NotSet = 104,
/// <summary>
/// The deposit transmission not set
/// </summary>
Deposit_Transmission_NotSet = 105,
/// <summary>
/// The deposit status check not set
/// </summary>
Deposit_StatusCheck_NotSet = 106,
/// <summary>
/// The deposit payback not set
/// </summary>
Deposit_Payback_NotSet = 107,
/// <summary>
/// 
/// </summary>
Collect_Validation_Abort = 108,
/// <summary>
/// 
/// </summary>
Collect_Transmission_Abort = 109,
/// <summary>
/// 
/// </summary>
Collect_StatusCheck_Abort = 110,
/// <summary>
/// 
/// </summary>
Collect_Payback_Abort = 111,
/// <summary>
/// 
/// </summary>
Deposit_Validation_Abort = 112,
/// <summary>
/// 
/// </summary>
Deposit_Transmission_Abort = 113,
/// <summary>
/// 
/// </summary>
Deposit_StatusCheck_Abort = 114,
/// <summary>
/// 
/// </summary>
Deposit_Payback_Abort = 115,
/// <summary>
/// Immediate Transfer Insufficient Wallet Balance
/// </summary>
Deposit_Immediate_Insufficient_Wallet_Balance_Abort = 116,
/// <summary>
/// 
/// </summary>
Collect_Transmission_Pending = 117,
/// <summary>
/// 
/// </summary>
Collect_StatusCheck_Pending = 118,
/// <summary>
/// 
/// </summary>
Deposit_Transmission_Pending = 119,
/// <summary>
/// 
/// </summary>
Deposit_StatusCheck_Pending = 120,
/// <summary>
/// 
/// </summary>
Authorization_Denied = 900,
}public enum ProcessTypeEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The collect
/// </summary>
Collect = 1,
/// <summary>
/// The deposit
/// </summary>
Deposit = 2,
/// <summary>
/// The check status
/// </summary>
CheckStatus = 3,
/// <summary>
/// The check payback
/// </summary>
CheckPayback = 4,
/// <summary>
/// The gather account information
/// </summary>
GatherAccountInfo = 5,
/// <summary>
/// The transmit accounting file
/// </summary>
TransmitAccountingFile = 6,
/// <summary>
/// Process deposit only without state execution
/// </summary>
QuickInterac = 7,
/// <summary>
/// 
/// </summary>
BuildTransactionsCacheFile = 8,
/// <summary>
/// 
/// </summary>
SendAllBills = 9,
/// <summary>
/// 
/// </summary>
CollectPortalFee = 10,
/// <summary>
/// 
/// </summary>
SendAllCommissions = 11,
}public enum ProviderEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The sandbox account
/// </summary>
Sandbox_Account = 100,
/// <summary>
/// The sandbox credit card
/// </summary>
Sandbox_CreditCard = 200,
/// <summary>
/// The sandbox Interac
/// </summary>
Sandbox_Interac = 300,
/// <summary>
/// The sandbox Interac ARN
/// </summary>
Sandbox_ARN = 400,
/// <summary>
/// The sandbox Blue Snap Account
/// </summary>
Sandbox_BlueSnap_Account_USD = 101,
/// <summary>
/// The sandbox Blue Snap Account CAD
/// </summary>
Sandbox_BlueSnap_Account_CAD = 102,
/// <summary>
/// The sandbox Blue Snap Credit Card
/// </summary>
Sandbox_BlueSnap_CreditCard_USD = 201,
/// <summary>
/// The sandbox Blue Snap Credit Card CAD
/// </summary>
Sandbox_BlueSnap_CreditCard_CAD = 202,
/// <summary>
/// The provider for credit card moneris
/// </summary>
CA_CreditCard_Moneris = 1000,
/// <summary>
/// The provider for credit card Bank of America
/// </summary>
CA_CreditCard_BankOfAmerica = 1001,
/// <summary>
/// The ca account desjardins
/// </summary>
CA_Account_Desjardins = 1100,
/// <summary>
/// The ca account RBC
/// </summary>
CA_Account_RBC = 1101,
/// <summary>
/// The Interac provider using RBC
/// </summary>
CA_Interac_RBC = 1200,
/// <summary>
/// The Account provider using RBC
/// </summary>
RBC_ARN = 3000,
/// <summary>
/// The Account provider using BlueSnap CreditCard USD
/// </summary>
BlueSnap_CreditCard_USD = 4000,
/// <summary>
/// The Account provider using BlueSnap Account USD
/// </summary>
BlueSnap_Account_USD = 4001,
/// <summary>
/// The Account provider using BlueSnap CreditCard CAD
/// </summary>
BlueSnap_CreditCard_CAD = 4002,
/// <summary>
/// The Account provider using BlueSnap Account CAD
/// </summary>
BlueSnap_Account_CAD = 4003,
}public enum ProviderRefIdTypeEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
Merchant = 1,
/// <summary>
/// 
/// </summary>
Service = 2,
}public enum ProviderSubTypeEnum {
    /// <summary>
/// 
/// </summary>
RBC_ARN = 0,
}public enum ProvinceStateIdEnum {
    /// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The ca alberta
/// </summary>
CA_Alberta = 1,
/// <summary>
/// The ca british columbia
/// </summary>
CA_BritishColumbia = 2,
/// <summary>
/// The ca manitoba
/// </summary>
CA_Manitoba = 3,
/// <summary>
/// The ca new brunswick
/// </summary>
CA_NewBrunswick = 4,
/// <summary>
/// The ca newfoundland
/// </summary>
CA_Newfoundland = 5,
/// <summary>
/// The ca nova scotia
/// </summary>
CA_NovaScotia = 6,
/// <summary>
/// The ca nunavut
/// </summary>
CA_Nunavut = 7,
/// <summary>
/// The ca ontario
/// </summary>
CA_Ontario = 8,
/// <summary>
/// The ca prince edward island
/// </summary>
CA_PrinceEdwardIsland = 9,
/// <summary>
/// The ca quebec
/// </summary>
CA_Quebec = 10,
/// <summary>
/// The ca saskatchewan
/// </summary>
CA_Saskatchewan = 11,
/// <summary>
/// The ca northwest territories
/// </summary>
CA_NorthwestTerritories = 12,
/// <summary>
/// The ca yukon territory
/// </summary>
CA_YukonTerritory = 13,
/// <summary>
/// The us armed forces americas
/// </summary>
US_ArmedForcesAmericas = 14,
/// <summary>
/// The us armed forces europe and middle east and canada
/// </summary>
US_ArmedForcesEuropeAndMiddleEastAndCanada = 15,
/// <summary>
/// The us alaska
/// </summary>
US_Alaska = 16,
/// <summary>
/// The us alabama
/// </summary>
US_Alabama = 17,
/// <summary>
/// The us armed forces pacific
/// </summary>
US_ArmedForcesPacific = 18,
/// <summary>
/// The us arkansas
/// </summary>
US_Arkansas = 19,
/// <summary>
/// The us american samoa
/// </summary>
US_AmericanSamoa = 20,
/// <summary>
/// The us arizona
/// </summary>
US_Arizona = 21,
/// <summary>
/// The us california
/// </summary>
US_California = 22,
/// <summary>
/// The us colorado
/// </summary>
US_Colorado = 23,
/// <summary>
/// The us connecticut
/// </summary>
US_Connecticut = 24,
/// <summary>
/// The us districtof columbia
/// </summary>
US_DistrictofColumbia = 25,
/// <summary>
/// The us delaware
/// </summary>
US_Delaware = 26,
/// <summary>
/// The us florida
/// </summary>
US_Florida = 27,
/// <summary>
/// The us federated statesof micronesia
/// </summary>
US_FederatedStatesofMicronesia = 28,
/// <summary>
/// The us georgia
/// </summary>
US_Georgia = 29,
/// <summary>
/// The us guam
/// </summary>
US_Guam = 30,
/// <summary>
/// The us hawaii
/// </summary>
US_Hawaii = 31,
/// <summary>
/// The us iowa
/// </summary>
US_Iowa = 32,
/// <summary>
/// The us idaho
/// </summary>
US_Idaho = 33,
/// <summary>
/// The us illinois
/// </summary>
US_Illinois = 34,
/// <summary>
/// The us indiana
/// </summary>
US_Indiana = 35,
/// <summary>
/// The us kansas
/// </summary>
US_Kansas = 36,
/// <summary>
/// The us kentucky
/// </summary>
US_Kentucky = 37,
/// <summary>
/// The us louisiana
/// </summary>
US_Louisiana = 38,
/// <summary>
/// The us massachusetts
/// </summary>
US_Massachusetts = 39,
/// <summary>
/// The us maryland
/// </summary>
US_Maryland = 40,
/// <summary>
/// The us maine
/// </summary>
US_Maine = 41,
/// <summary>
/// The us marshall islands
/// </summary>
US_MarshallIslands = 42,
/// <summary>
/// The us michigan
/// </summary>
US_Michigan = 43,
/// <summary>
/// The us minnesota
/// </summary>
US_Minnesota = 44,
/// <summary>
/// The us missouri
/// </summary>
US_Missouri = 45,
/// <summary>
/// The us northern mariana islands
/// </summary>
US_NorthernMarianaIslands = 46,
/// <summary>
/// The us mississippi
/// </summary>
US_Mississippi = 47,
/// <summary>
/// The us montana
/// </summary>
US_Montana = 48,
/// <summary>
/// The us north carolina
/// </summary>
US_NorthCarolina = 49,
/// <summary>
/// The us north dakota
/// </summary>
US_NorthDakota = 50,
/// <summary>
/// The us nebraska
/// </summary>
US_Nebraska = 51,
/// <summary>
/// The us new hampshire
/// </summary>
US_NewHampshire = 52,
/// <summary>
/// The us new jersey
/// </summary>
US_NewJersey = 53,
/// <summary>
/// The us new mexico
/// </summary>
US_NewMexico = 54,
/// <summary>
/// The us nevada
/// </summary>
US_Nevada = 55,
/// <summary>
/// The us new york
/// </summary>
US_NewYork = 56,
/// <summary>
/// The us ohio
/// </summary>
US_Ohio = 57,
/// <summary>
/// The us oklahoma
/// </summary>
US_Oklahoma = 58,
/// <summary>
/// The us oregon
/// </summary>
US_Oregon = 59,
/// <summary>
/// The us pennsylvania
/// </summary>
US_Pennsylvania = 61,
/// <summary>
/// The us puerto rico
/// </summary>
US_PuertoRico = 62,
/// <summary>
/// The us palau
/// </summary>
US_Palau = 63,
/// <summary>
/// The us rhode island
/// </summary>
US_RhodeIsland = 64,
/// <summary>
/// The us south carolina
/// </summary>
US_SouthCarolina = 65,
/// <summary>
/// The us south dakota
/// </summary>
US_SouthDakota = 66,
/// <summary>
/// The us tennessee
/// </summary>
US_Tennessee = 67,
/// <summary>
/// The us texas
/// </summary>
US_Texas = 68,
/// <summary>
/// The us utah
/// </summary>
US_Utah = 69,
/// <summary>
/// The us virginia
/// </summary>
US_Virginia = 70,
/// <summary>
/// The us virgin islands
/// </summary>
US_VirginIslands = 71,
/// <summary>
/// The us vermont
/// </summary>
US_Vermont = 72,
/// <summary>
/// The us washington
/// </summary>
US_Washington = 73,
/// <summary>
/// The us west virginia
/// </summary>
US_WestVirginia = 74,
/// <summary>
/// The us wisconsin
/// </summary>
US_Wisconsin = 75,
/// <summary>
/// The us wyoming
/// </summary>
US_Wyoming = 76,
}public enum PublicAccessTokenRoutingType {
    /// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The transfer
/// </summary>
Transfer = 1,
/// <summary>
/// The anonymous payment
/// </summary>
AnonymousPayment = 2,
/// <summary>
/// The create service
/// </summary>
CreateService = 3,
/// <summary>
/// The pending change
/// </summary>
PendingChange = 4,
/// <summary>
/// The know customer payment
/// </summary>
KnowCustomerPayment = 5,
/// <summary>
/// The drop in
/// </summary>
DropIn = 6,
/// <summary>
/// 
/// </summary>
SignUp = 8,
/// <summary>
/// The boarding step during the boarding of a client
/// </summary>
Boarding = 9,
/// <summary>
/// The contract step during the boarding of a client
/// </summary>
BoardingContract = 10,
/// <summary>
/// Change user password for login
/// </summary>
ChangePassword = 11,
/// <summary>
/// 
/// </summary>
ExternalSupplierFinancialInformationsRequest = 12,
/// <summary>
/// 
/// </summary>
ExternalSupplierReadOnlyPortalLink = 13,
}public enum ReferenceTypeEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
Client = 1,
/// <summary>
/// 
/// </summary>
Service = 2,
/// <summary>
/// 
/// </summary>
Merchant = 3,
}public enum SandboxTestStatusEnum {
    /// <summary>
/// 
/// </summary>
COLLECT_DEPOSIT_SUCCESS = 1,
/// <summary>
/// 
/// </summary>
COLLECT_DEPOSIT_WEBHOOK_SUCCESS = 1,
/// <summary>
/// 
/// </summary>
COLLECT_VALIDATION_FAIL = 2,
/// <summary>
/// 
/// </summary>
COLLECT_VALIDATION_SUCCESS = 3,
/// <summary>
/// 
/// </summary>
COLLECT_TRANSMISSION_FAIL = 4,
/// <summary>
/// 
/// </summary>
COLLECT_TRANSMISSION_SUCCESS = 5,
/// <summary>
/// 
/// </summary>
COLLECT_STATUSCHECK_FAIL = 6,
/// <summary>
/// 
/// </summary>
COLLECT_STATUSCHECK_PENDING = 7,
/// <summary>
/// 
/// </summary>
COLLECT_STATUSCHECK_SUCCESS = 8,
/// <summary>
/// 
/// </summary>
COLLECT_PAYBACK_FAIL = 9,
/// <summary>
/// 
/// </summary>
COLLECT_PAYBACK_SUCCESS = 10,
/// <summary>
/// 
/// </summary>
DEPOSIT_VALIDATION_FAIL = 11,
/// <summary>
/// 
/// </summary>
DEPOSIT_VALIDATION_SUCCESS = 12,
/// <summary>
/// 
/// </summary>
DEPOSIT_TRANSMISSION_FAIL = 13,
/// <summary>
/// 
/// </summary>
DEPOSIT_TRANSMISSION_PENDING = 14,
/// <summary>
/// 
/// </summary>
DEPOSIT_TRANSMISSION_SUCCESS = 15,
/// <summary>
/// 
/// </summary>
DEPOSIT_STATUSCHECK_FAIL = 16,
/// <summary>
/// 
/// </summary>
DEPOSIT_STATUSCHECK_SUCCESS = 17,
/// <summary>
/// 
/// </summary>
DEPOSIT_PAYBACK_FAIL = 18,
/// <summary>
/// 
/// </summary>
DEPOSIT_PAYBACK_SUCCESS = 19,
}public enum SysOptionsTypeEnum {
    /// <summary>
/// 
/// </summary>
TargetMerchantFeesRedeposit = 1,
}public enum TibAuthorizationStatus {
    /// <summary>
/// This state automaticly approved the transfer
/// </summary>
NotRequired = 0,
/// <summary>
/// This state mean, that the transfer need to be approved by the client, when the client will approved, the state should be Required
/// </summary>
WaitingForClientApprobation = 1,
/// <summary>
/// This state mean that the TIB approbation is required
/// </summary>
Required = 2,
/// <summary>
/// This state mean that the transfer is approved by the tib Refer to the field TIBApprovedBy to know who approve this transaction
/// </summary>
Approved = 3,
/// <summary>
/// The declined
/// </summary>
Declined = 4,
}public enum TibCustomPaymentStatus {
    /// <summary>
/// 
/// </summary>
Pending = 0,
/// <summary>
/// 
/// </summary>
InProgress = 1,
/// <summary>
/// 
/// </summary>
RevertedPending = 2,
/// <summary>
/// 
/// </summary>
Completed = 3,
/// <summary>
/// 
/// </summary>
RevertedCompleted = 4,
/// <summary>
/// 
/// </summary>
Error = 5,
/// <summary>
/// 
/// </summary>
Canceled = 6,
}public enum TibOperationStatus {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
New = 1,
/// <summary>
/// 
/// </summary>
InProgress = 2,
/// <summary>
/// 
/// </summary>
Failed = 3,
/// <summary>
/// 
/// </summary>
Abord = 4,
/// <summary>
/// 
/// </summary>
Success = 5,
/// <summary>
/// 
/// </summary>
Lost = 6,
}public enum TransferDirectionEnum {
    /// <summary>
/// The unknown
/// </summary>
Unknown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The collect
/// </summary>
Collect = 1,
/// <summary>
/// The deposit
/// </summary>
Deposit = 2,
}public enum TransferFrequencyEnum {
    /// <summary>
/// 
/// </summary>
NotSet = -1,
/// <summary>
/// 
/// </summary>
Once = 0,
/// <summary>
/// 
/// </summary>
Daily = 1,
/// <summary>
/// 
/// </summary>
Weekly = 2,
/// <summary>
/// 
/// </summary>
EveryTwoWeeks = 3,
/// <summary>
/// 
/// </summary>
Monthly = 4,
/// <summary>
/// 
/// </summary>
Trimester = 5,
/// <summary>
/// 
/// </summary>
BiAnually = 6,
/// <summary>
/// 
/// </summary>
Anually = 7,
}public enum TransferTypeEnum {
    /// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The payment
/// </summary>
Payment = 1,
/// <summary>
/// The free deposit
/// </summary>
FreeDeposit = 2,
/// <summary>
/// The free collection
/// </summary>
FreeCollection = 3,
/// <summary>
/// The fee
/// </summary>
Fee = 4,
/// <summary>
/// The revert
/// </summary>
Revert = 5,
/// <summary>
/// Payment and Free Collection
/// </summary>
PaymentAndFreeCollection = 6,
/// <summary>
/// 
/// </summary>
Commission = 7,
/// <summary>
/// 
/// </summary>
DepositToWallet = 8,
/// <summary>
/// 
/// </summary>
CollectFromWallet = 9,
/// <summary>
/// 
/// </summary>
DepositToWalletFromInterac = 10,
}public enum TransferTypeFlag {
    /// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// The payment
/// </summary>
Payment = 1,
/// <summary>
/// The free collection
/// </summary>
FreeCollection = 2,
/// <summary>
/// The payment and free collection
/// </summary>
PaymentAndFreeCollection = 3,
/// <summary>
/// The free deposit
/// </summary>
FreeDeposit = 4,
/// <summary>
/// The payment and free deposit
/// </summary>
PaymentAndFreeDeposit = 5,
/// <summary>
/// The free collection and free deposit
/// </summary>
FreeCollectionAndFreeDeposit = 6,
/// <summary>
/// All
/// </summary>
All = 7,
}public enum UserType {
    /// <summary>
/// The admin
/// </summary>
Admin = 0,
/// <summary>
/// The user
/// </summary>
User = 1,
}public enum ValidationLimitStatus {
    /// <summary>
/// The no errors
/// </summary>
NoErrors = 0,
/// <summary>
/// The limit per bank account daily reach
/// </summary>
LimitPerBankAccountDailyReach = 1,
/// <summary>
/// The limit per bank account per delays reach
/// </summary>
LimitPerBankAccountPerDelaysReach = 2,
/// <summary>
/// The number per bank account daily reach
/// </summary>
NumberPerBankAccountDailyReach = 4,
/// <summary>
/// The number per bank account per delays reach
/// </summary>
NumberPerBankAccountPerDelaysReach = 8,
/// <summary>
/// The limit reach
/// </summary>
LimitReach = 16,
/// <summary>
/// The limit daily reach
/// </summary>
LimitDailyReach = 32,
/// <summary>
/// The client limit daily reach
/// </summary>
LimitClientDailyReach = 64,
}public enum WalletAdjustmentEnum {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
IncreaseWallet = 2,
/// <summary>
/// 
/// </summary>
DecreaseWallet = 4,
}public enum WalletHistoryStatus {
    /// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
New = 1,
/// <summary>
/// 
/// </summary>
InProgress = 2,
/// <summary>
/// 
/// </summary>
Failed = 3,
/// <summary>
/// 
/// </summary>
Abord = 4,
/// <summary>
/// 
/// </summary>
Success = 5,
/// <summary>
/// 
/// </summary>
Lost = 6,
}public enum WalletTypeEnum {
    /// <summary>
/// 
/// </summary>
Schedule = 1,
/// <summary>
/// 
/// </summary>
Manual = 2,
/// <summary>
/// 
/// </summary>
Automatic = 3,
}public enum WebhookActionEnum {
    /// <summary>
/// 
/// </summary>
CollectSuccess = 1,
/// <summary>
/// 
/// </summary>
DepositSuccess = 2,
}public enum WhitelabelingLevelsEnum {
    /// <summary>
/// 
/// </summary>
Default = -1,
/// <summary>
/// 
/// </summary>
NotSet = 0,
/// <summary>
/// 
/// </summary>
Merchant = 1,
/// <summary>
/// 
/// </summary>
Service = 2,
/// <summary>
/// 
/// </summary>
Client = 3,
/// <summary>
/// 
/// </summary>
Url = 4,
}
    }
}
