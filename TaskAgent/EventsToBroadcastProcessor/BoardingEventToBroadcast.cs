
using System;

namespace Tib.Api.TaskAgent.EventsToBroadcastProcessor
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BoardingEventToBroadcast 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid BoardingInfoId { get; set; }

    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyAddress { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Nullable<int> CompanyType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Nullable<bool> DidOwnersAlreadyBeenSubjectOfResiliationOfPaymentService { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Nullable<bool> DidOwnersAlreadyAskedForBankrupcy { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Nullable<bool> HaveYouBeenSubjectOfVisaRiskProgram { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string DrivingLicenceNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int BoardingStep { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyName_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyAddress_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Nullable<int> CompanyType_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AccountOwner { get; set; }

    /// <summary>
    /// Specifies the bank account number associated with the payment method.
    /// </summary>
    /// <value>Gets or sets the account number. The value must be a non‑empty string with a maximum length of 20 characters.</value>
    public string AccountNumber { get; set; }

    /// <summary>
    /// Identifies the bank associated with the account using its numeric identifier.
    /// </summary>
    /// <value>Holds the bank number as a string. The value must not exceed the allowed length.</value>
    public string BankNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TransitNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public byte[] SignedContractContent { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ClientName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ClientEmail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ClientPhone { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string SpecimenFile { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string IdFile { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyTaxId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyCountryCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyStateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyZip { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyPhone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyProductAndServiceDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyWebSite { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyBusinessCategory { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanySalesVolume { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankPayoutCurrency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankCountryCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankStateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankRoutingNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankBic { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankIban { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankSortCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankSwiftCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankBsb { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BusinessRegistrationNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BusinessRegistrationNumber_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyLegalName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyBusinessType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyAccountUserName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankAccountType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankMinimalPayoutAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankRefundReserve { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string MerchantServiceAgreementDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string MerchantPricingAgreementDate { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Nullable<Guid> MerchantId { get; set; }

    /// <summary>
    /// Represents the current state of a transaction within the system.
    /// </summary>
    /// <value>The Status integer indicates the progress or outcome of a transaction, providing essential information for error handling and process monitoring.</value>
    public Nullable<int> Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ErrorResponse { get; set; }

    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Nullable<Guid> ServiceId { get; set; }

    /// <summary>
    /// Gets or sets the string that contains the required document identifiers for the client.
    /// </summary>
    /// <value>A concatenated string (or JSON array) representing the identifiers of all documents that must be provided.</value>
    public string RequiredDocuments { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderRequestId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CaseId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyEmail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AverageTransactionAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string HighestTransactionAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string RiskMonitoring { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string RiskPayment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string RiskByCommission { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string PaymentReference { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerLinkedIn { get; set; }

    }
}