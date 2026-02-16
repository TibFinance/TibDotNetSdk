
using System;
using System.Collections.Generic;
using Tib.Api.Model.Boarding;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the BoardingInformationModel model.
    /// </summary>
    public class BoardingInformationModel : BoardingInformationEntity
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid BoardingInfoId { get; set; }

    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Nullable<Guid> ServiceId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Nullable<Guid> MerchantId { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public Nullable<DateTime> CreatedDate { get; set; }

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
    public string CompanyCountryCode { get; set; }

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
    public string CompanyStateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyTaxId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyWebSite { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanySalesVolume { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyProductAndServiceDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BusinessRegistrationNumber { get; set; }

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
    public string BusinessRegistrationNumber_Edited { get; set; }

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
    public string BankCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankStateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankCountryCode { get; set; }

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
    public string BankAccountNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankTransitNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankPayoutCurrency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankSortCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankBsb { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankSwiftCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyBusinessCategory { get; set; }

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
    /// 
    /// </summary>
    /// <value></value>
    public List<BoardingInformationFileEntity> Files { get; set; }

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
    /// The merchant's phone number used for contact and transaction notifications.
    /// </summary>
    /// <value>A string containing the merchant's telephone number. The value must conform to the allowed character set defined by the regular expression.</value>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int CompanyMerchantLanguage { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public int? Currency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<BoardingInfoPersonEntity> Persons { get; set; }

    }
}