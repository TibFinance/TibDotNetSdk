
namespace Tib.Api.Model
{
    public class Enum
    {
      public enum AccountTypeEnum {

    /// <summary>
/// Personal checking account.
/// </summary>
CustomerChecking = 1,
/// <summary>
/// Personal savings account.
/// </summary>
CustomerSaving = 2,
/// <summary>
/// Business or corporate checking account.
/// </summary>
CorporateChecking = 3,
/// <summary>
/// Business or corporate savings account.
/// </summary>
CorporateSaving = 4,
}
      public enum AutorizedPaymentMethodFlags {

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
/// <summary>
/// Authorization for Visa credit cards
/// </summary>
CreditCardVisa = 32,
/// <summary>
/// Authorization for Mastercard credit cards
/// </summary>
CreditCardMastercard = 64,
/// <summary>
/// Authorization for American Express credit cards
/// </summary>
CreditCardAmex = 128,
}
      public enum BankingOperationResultEnum {

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
}
      public enum ConvenientFeeModeEnum {

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
}
      public enum CountryIdEnum {

    /// <summary>
/// Unknown or unspecified country.
/// </summary>
Unkown = -1,
/// <summary>
/// No country specified.
/// </summary>
NotSet = 0,
/// <summary>
/// Canada (CAD currency region).
/// </summary>
Canada = 1,
/// <summary>
/// United States (USD currency region).
/// </summary>
USA = 2,
}
      public enum CurrencyEnum {

    /// <summary>
/// Currency could not be determined.
/// </summary>
Unkown = -1,
/// <summary>
/// No currency has been specified.
/// </summary>
NotSet = 0,
/// <summary>
/// Canadian dollar.
/// </summary>
CAD = 1,
/// <summary>
/// United States dollar.
/// </summary>
USD = 2,
/// <summary>
/// Euro.
/// </summary>
EUR = 3,
/// <summary>
/// British pound sterling.
/// </summary>
GBP = 4,
}
      public enum DateTypeEnum {

    /// <summary>
/// The unkown
/// </summary>
Unkown = -1,
/// <summary>
/// The not set
/// </summary>
NotSet = 0,
/// <summary>
/// Filter or sort by the record's creation date.
/// </summary>
CreatedDate = 1,
/// <summary>
/// Filter or sort by the record's last modification date.
/// </summary>
LastModifiedDate = 2,
}
      public enum FeeModeEnum {

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
/// Fixed fee with round-up pricing applied.
/// </summary>
FixUsingRoundUp = 3,
}
      public enum LanguageEnum {

    /// <summary>
/// Unknown or unspecified language.
/// </summary>
Unkown = -1,
/// <summary>
/// No language specified.
/// </summary>
NotSet = 0,
/// <summary>
/// French (Francais).
/// </summary>
French = 1,
/// <summary>
/// English.
/// </summary>
English = 2,
}
      public enum OperationKindEnum {

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
/// Reversal of a convenience fee.
/// </summary>
RevertConvenientFee = 21,
/// <summary>
/// Platform fee charged by TIB.
/// </summary>
PlatformFee = 22,
/// <summary>
/// Gateway usage fee.
/// </summary>
GatewayUsageFee = 23,
/// <summary>
/// Support or maintenance fee.
/// </summary>
SupportFee = 24,
/// <summary>
/// Collection from merchant's internal wallet.
/// </summary>
WalletCollect = 25,
/// <summary>
/// Fee for a failed credit card charge.
/// </summary>
CreditCardFailedCharge = 26,
/// <summary>
/// Low volume fee charged by TIB.
/// </summary>
LowVolumeFee = 28,
/// <summary>
/// Single-leg $0.01 micro-deposit verification operation (no collect or fee sibling).
/// </summary>
MicroDepositVerification = 27,
/// <summary>
/// Aggregated fee operations grouped for batch processing.
/// </summary>
GroupedFees = 100,
/// <summary>
/// Re-transfer of fees when the original fee deposit failed.
/// </summary>
FeesRetransfer = 101,
}
      public enum OperationStatusEnum {

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
}
      public enum OperationTargetEnum {

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
}
      public enum OperationTypeEnum {

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
}
      public enum PaymentFilterLevelEnum {

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
}
      public enum PaymentFlowEnum {

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
}
      public enum PaymentFlowParsingResultEnum {

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
}
      public enum PaymentMethodTypeEnum {

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
}
      public enum ProcessStatusEnum {

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
/// Collection validation was aborted.
/// </summary>
Collect_Validation_Abort = 108,
/// <summary>
/// Collection transmission was aborted.
/// </summary>
Collect_Transmission_Abort = 109,
/// <summary>
/// Collection status check was aborted.
/// </summary>
Collect_StatusCheck_Abort = 110,
/// <summary>
/// Collection payback was aborted.
/// </summary>
Collect_Payback_Abort = 111,
/// <summary>
/// Deposit validation was aborted.
/// </summary>
Deposit_Validation_Abort = 112,
/// <summary>
/// Deposit transmission was aborted.
/// </summary>
Deposit_Transmission_Abort = 113,
/// <summary>
/// Deposit status check was aborted.
/// </summary>
Deposit_StatusCheck_Abort = 114,
/// <summary>
/// Deposit payback was aborted.
/// </summary>
Deposit_Payback_Abort = 115,
/// <summary>
/// Immediate Transfer Insufficient Wallet Balance
/// </summary>
Deposit_Immediate_Insufficient_Wallet_Balance_Abort = 116,
/// <summary>
/// Collection transmission awaiting provider response.
/// </summary>
Collect_Transmission_Pending = 117,
/// <summary>
/// Collection status check awaiting provider response.
/// </summary>
Collect_StatusCheck_Pending = 118,
/// <summary>
/// Deposit transmission awaiting provider response.
/// </summary>
Deposit_Transmission_Pending = 119,
/// <summary>
/// Deposit status check awaiting provider response.
/// </summary>
Deposit_StatusCheck_Pending = 120,
/// <summary>
/// Transfer denied by TIB authorization review.
/// </summary>
Authorization_Denied = 900,
}
      public enum ProviderEnum {

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
}
      public enum ProvinceStateIdEnum {

    /// <summary>
/// Unknown province or state.
/// </summary>
Unkown = -1,
/// <summary>
/// Not specified.
/// </summary>
NotSet = 0,
/// <summary>
/// Alberta, Canada.
/// </summary>
CA_Alberta = 1,
/// <summary>
/// British Columbia, Canada.
/// </summary>
CA_BritishColumbia = 2,
/// <summary>
/// Manitoba, Canada.
/// </summary>
CA_Manitoba = 3,
/// <summary>
/// New Brunswick, Canada.
/// </summary>
CA_NewBrunswick = 4,
/// <summary>
/// Newfoundland and Labrador, Canada.
/// </summary>
CA_Newfoundland = 5,
/// <summary>
/// Nova Scotia, Canada.
/// </summary>
CA_NovaScotia = 6,
/// <summary>
/// Nunavut, Canada.
/// </summary>
CA_Nunavut = 7,
/// <summary>
/// Ontario, Canada.
/// </summary>
CA_Ontario = 8,
/// <summary>
/// Prince Edward Island, Canada.
/// </summary>
CA_PrinceEdwardIsland = 9,
/// <summary>
/// Quebec, Canada.
/// </summary>
CA_Quebec = 10,
/// <summary>
/// Saskatchewan, Canada.
/// </summary>
CA_Saskatchewan = 11,
/// <summary>
/// Northwest Territories, Canada.
/// </summary>
CA_NorthwestTerritories = 12,
/// <summary>
/// Yukon Territory, Canada.
/// </summary>
CA_YukonTerritory = 13,
/// <summary>
/// Armed Forces Americas (AA), United States.
/// </summary>
US_ArmedForcesAmericas = 14,
/// <summary>
/// Armed Forces Europe, Middle East, and Canada (AE), United States.
/// </summary>
US_ArmedForcesEuropeAndMiddleEastAndCanada = 15,
/// <summary>
/// Alaska, United States.
/// </summary>
US_Alaska = 16,
/// <summary>
/// Alabama, United States.
/// </summary>
US_Alabama = 17,
/// <summary>
/// Armed Forces Pacific (AP), United States.
/// </summary>
US_ArmedForcesPacific = 18,
/// <summary>
/// Arkansas, United States.
/// </summary>
US_Arkansas = 19,
/// <summary>
/// American Samoa, United States.
/// </summary>
US_AmericanSamoa = 20,
/// <summary>
/// Arizona, United States.
/// </summary>
US_Arizona = 21,
/// <summary>
/// California, United States.
/// </summary>
US_California = 22,
/// <summary>
/// Colorado, United States.
/// </summary>
US_Colorado = 23,
/// <summary>
/// Connecticut, United States.
/// </summary>
US_Connecticut = 24,
/// <summary>
/// District of Columbia, United States.
/// </summary>
US_DistrictofColumbia = 25,
/// <summary>
/// Delaware, United States.
/// </summary>
US_Delaware = 26,
/// <summary>
/// Florida, United States.
/// </summary>
US_Florida = 27,
/// <summary>
/// Federated States of Micronesia, United States.
/// </summary>
US_FederatedStatesofMicronesia = 28,
/// <summary>
/// Georgia, United States.
/// </summary>
US_Georgia = 29,
/// <summary>
/// Guam, United States.
/// </summary>
US_Guam = 30,
/// <summary>
/// Hawaii, United States.
/// </summary>
US_Hawaii = 31,
/// <summary>
/// Iowa, United States.
/// </summary>
US_Iowa = 32,
/// <summary>
/// Idaho, United States.
/// </summary>
US_Idaho = 33,
/// <summary>
/// Illinois, United States.
/// </summary>
US_Illinois = 34,
/// <summary>
/// Indiana, United States.
/// </summary>
US_Indiana = 35,
/// <summary>
/// Kansas, United States.
/// </summary>
US_Kansas = 36,
/// <summary>
/// Kentucky, United States.
/// </summary>
US_Kentucky = 37,
/// <summary>
/// Louisiana, United States.
/// </summary>
US_Louisiana = 38,
/// <summary>
/// Massachusetts, United States.
/// </summary>
US_Massachusetts = 39,
/// <summary>
/// Maryland, United States.
/// </summary>
US_Maryland = 40,
/// <summary>
/// Maine, United States.
/// </summary>
US_Maine = 41,
/// <summary>
/// Marshall Islands, United States.
/// </summary>
US_MarshallIslands = 42,
/// <summary>
/// Michigan, United States.
/// </summary>
US_Michigan = 43,
/// <summary>
/// Minnesota, United States.
/// </summary>
US_Minnesota = 44,
/// <summary>
/// Missouri, United States.
/// </summary>
US_Missouri = 45,
/// <summary>
/// Northern Mariana Islands, United States.
/// </summary>
US_NorthernMarianaIslands = 46,
/// <summary>
/// Mississippi, United States.
/// </summary>
US_Mississippi = 47,
/// <summary>
/// Montana, United States.
/// </summary>
US_Montana = 48,
/// <summary>
/// North Carolina, United States.
/// </summary>
US_NorthCarolina = 49,
/// <summary>
/// North Dakota, United States.
/// </summary>
US_NorthDakota = 50,
/// <summary>
/// Nebraska, United States.
/// </summary>
US_Nebraska = 51,
/// <summary>
/// New Hampshire, United States.
/// </summary>
US_NewHampshire = 52,
/// <summary>
/// New Jersey, United States.
/// </summary>
US_NewJersey = 53,
/// <summary>
/// New Mexico, United States.
/// </summary>
US_NewMexico = 54,
/// <summary>
/// Nevada, United States.
/// </summary>
US_Nevada = 55,
/// <summary>
/// New York, United States.
/// </summary>
US_NewYork = 56,
/// <summary>
/// Ohio, United States.
/// </summary>
US_Ohio = 57,
/// <summary>
/// Oklahoma, United States.
/// </summary>
US_Oklahoma = 58,
/// <summary>
/// Oregon, United States.
/// </summary>
US_Oregon = 59,
/// <summary>
/// Pennsylvania, United States.
/// </summary>
US_Pennsylvania = 61,
/// <summary>
/// Puerto Rico, United States.
/// </summary>
US_PuertoRico = 62,
/// <summary>
/// Palau, United States.
/// </summary>
US_Palau = 63,
/// <summary>
/// Rhode Island, United States.
/// </summary>
US_RhodeIsland = 64,
/// <summary>
/// South Carolina, United States.
/// </summary>
US_SouthCarolina = 65,
/// <summary>
/// South Dakota, United States.
/// </summary>
US_SouthDakota = 66,
/// <summary>
/// Tennessee, United States.
/// </summary>
US_Tennessee = 67,
/// <summary>
/// Texas, United States.
/// </summary>
US_Texas = 68,
/// <summary>
/// Utah, United States.
/// </summary>
US_Utah = 69,
/// <summary>
/// Virginia, United States.
/// </summary>
US_Virginia = 70,
/// <summary>
/// Virgin Islands, United States.
/// </summary>
US_VirginIslands = 71,
/// <summary>
/// Vermont, United States.
/// </summary>
US_Vermont = 72,
/// <summary>
/// Washington, United States.
/// </summary>
US_Washington = 73,
/// <summary>
/// West Virginia, United States.
/// </summary>
US_WestVirginia = 74,
/// <summary>
/// Wisconsin, United States.
/// </summary>
US_Wisconsin = 75,
/// <summary>
/// Wyoming, United States.
/// </summary>
US_Wyoming = 76,
}
      public enum ReferenceTypeEnum {

    /// <summary>
/// No reference type specified.
/// </summary>
NotSet = 0,
/// <summary>
/// Reference belongs to a client entity.
/// </summary>
Client = 1,
/// <summary>
/// Reference belongs to a service entity.
/// </summary>
Service = 2,
/// <summary>
/// Reference belongs to a merchant entity.
/// </summary>
Merchant = 3,
}
      public enum TibOperationStatus {

    /// <summary>
/// Default uninitialized state.
/// </summary>
NotSet = 0,
/// <summary>
/// Operation created, not yet picked up for processing.
/// </summary>
New = 1,
/// <summary>
/// Operation currently being processed.
/// </summary>
InProgress = 2,
/// <summary>
/// Operation failed (terminal state).
/// </summary>
Failed = 3,
/// <summary>
/// Operation was aborted.
/// </summary>
Abord = 4,
/// <summary>
/// Operation completed successfully.
/// </summary>
Success = 5,
/// <summary>
/// Operation lost or unresolved.
/// </summary>
Lost = 6,
}
      public enum TransferDirectionEnum {

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
}
      public enum TransferFrequencyEnum {

    /// <summary>
/// No frequency specified.
/// </summary>
NotSet = -1,
/// <summary>
/// One-time transfer (non-recurring).
/// </summary>
Once = 0,
/// <summary>
/// Recurs every day.
/// </summary>
Daily = 1,
/// <summary>
/// Recurs every week.
/// </summary>
Weekly = 2,
/// <summary>
/// Recurs every two weeks.
/// </summary>
EveryTwoWeeks = 3,
/// <summary>
/// Recurs once per month.
/// </summary>
Monthly = 4,
/// <summary>
/// Recurs every three months (quarterly).
/// </summary>
Trimester = 5,
/// <summary>
/// Recurs every six months (semi-annually).
/// </summary>
BiAnually = 6,
/// <summary>
/// Recurs once per year.
/// </summary>
Anually = 7,
}
      public enum TransferTypeEnum {

    /// <summary>
/// No transfer type specified.
/// </summary>
NotSet = 0,
/// <summary>
/// Standard payment transfer linked to a bill and customer.
/// </summary>
Payment = 1,
/// <summary>
/// Direct deposit operation without a linked payment.
/// </summary>
FreeDeposit = 2,
/// <summary>
/// Direct collection operation without a linked payment.
/// </summary>
FreeCollection = 3,
/// <summary>
/// Fee transfer charged by TIB.
/// </summary>
Fee = 4,
/// <summary>
/// Reversal of a previous transfer.
/// </summary>
Revert = 5,
/// <summary>
/// Combined payment with an associated free collection.
/// </summary>
PaymentAndFreeCollection = 6,
/// <summary>
/// Commission payment transfer.
/// </summary>
Commission = 7,
/// <summary>
/// Deposit into the merchant's internal wallet from a bank account.
/// </summary>
DepositToWallet = 8,
/// <summary>
/// Collection (withdrawal) from the merchant's internal wallet.
/// </summary>
CollectFromWallet = 9,
/// <summary>
/// Deposit into the merchant's wallet via Interac.
/// </summary>
DepositToWalletFromInterac = 10,
/// <summary>
/// Server-initiated $0.01 micro-deposit that carries a verification code in the recipient's bank-statement descriptor.
/// </summary>
MicroDepositVerification = 11,
}
      public enum TransferTypeFlag {

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
}
      public enum TwoFactorStatus {

    /// <summary>
/// Operation completed successfully - no 2FA was required (admin, impersonated, or non-protected operation)
/// </summary>
NotRequired = 0,
/// <summary>
/// User has 2FA enabled - client must prompt for 6-digit code and retry with TwoFactorCode populated
/// </summary>
CodeRequired = 1,
/// <summary>
/// User must set up 2FA first - client should display QR code from SetupData and call Verify2FASetup
/// </summary>
SetupRequired = 2,
/// <summary>
/// 2FA code was verified successfully - operation completed
/// </summary>
Verified = 3,
/// <summary>
/// The provided code was invalid - client should prompt for code again
/// </summary>
InvalidCode = 4,
/// <summary>
/// Security verification required before 2FA setup. Client must prompt user for bank account number and retry with TwoFactorSecurityAnswer populated. Response includes TwoFactorVerificationMerchantName to display in the prompt.
/// </summary>
SecurityVerificationRequired = 5,
/// <summary>
/// The provided bank account number did not match records. Client should re-prompt for bank account number. Response includes TwoFactorVerificationMerchantName for retry.
/// </summary>
SecurityVerificationFailed = 6,
/// <summary>
/// Security verification cannot be performed - no merchant with bank account found. User cannot set up 2FA until they have a bank account on file. This is a blocking error with no retry option.
/// </summary>
SecurityVerificationUnavailable = 7,
}
      public enum WalletAdjustmentEnum {

    /// <summary>
/// No adjustment mode specified.
/// </summary>
NotSet = 0,
/// <summary>
/// Add funds to the wallet balance.
/// </summary>
IncreaseWallet = 2,
/// <summary>
/// Remove funds from the wallet balance.
/// </summary>
DecreaseWallet = 4,
}
      public enum WalletTypeEnum {

    /// <summary>
/// Wallet withdrawals occur on a set schedule.
/// </summary>
Schedule = 1,
/// <summary>
/// Wallet withdrawals require manual action.
/// </summary>
Manual = 2,
/// <summary>
/// Wallet withdrawals occur automatically when the threshold is reached.
/// </summary>
Automatic = 3,
}
    }
}
