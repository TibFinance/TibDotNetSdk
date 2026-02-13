
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.ExternalForm
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TibServiceContractForm 
    {
        
    /// <summary>
    /// Gets or sets the name of the bank.
    /// </summary>
    /// <value>The name of the bank.</value>
    public string BankName { get; set; }

    /// <summary>
    /// Gets or sets the bank address.
    /// </summary>
    /// <value>The bank address.</value>
    public string BankAddress { get; set; }

    /// <summary>
    /// Gets or sets the bank city.
    /// </summary>
    /// <value>The bank city.</value>
    public string BankCity { get; set; }

    /// <summary>
    /// Gets or sets the bank province.
    /// </summary>
    /// <value>The bank province.</value>
    public string BankProvince { get; set; }

    /// <summary>
    /// Gets or sets the bank country.
    /// </summary>
    /// <value>The bank country.</value>
    public string BankCountry { get; set; }

    /// <summary>
    /// Gets or sets the bank name1.
    /// </summary>
    /// <value>The bank name1.</value>
    public string BankName1 { get; set; }

    /// <summary>
    /// Gets or sets the bank number1.
    /// </summary>
    /// <value>The bank number1.</value>
    public string BankNumber1 { get; set; }

    /// <summary>
    /// Gets or sets the bank transit1.
    /// </summary>
    /// <value>The bank transit1.</value>
    public string BankTransit1 { get; set; }

    /// <summary>
    /// Gets or sets the bank account1.
    /// </summary>
    /// <value>The bank account1.</value>
    public string BankAccount1 { get; set; }

    /// <summary>
    /// Gets or sets the name of the enterprise.
    /// </summary>
    /// <value>The name of the enterprise.</value>
    public string EnterpriseName { get; set; }

    /// <summary>
    /// Gets or sets the name of the owner.
    /// </summary>
    /// <value>The name of the owner.</value>
    public string OwnerName { get; set; }

    /// <summary>
    /// Gets or sets the owner address.
    /// </summary>
    /// <value>The owner address.</value>
    public string OwnerAddress { get; set; }

    /// <summary>
    /// Gets or sets the owner city.
    /// </summary>
    /// <value>The owner city.</value>
    public string OwnerCity { get; set; }

    /// <summary>
    /// Gets or sets the owner country.
    /// </summary>
    /// <value>The owner country.</value>
    public string OwnerCountry { get; set; }

    /// <summary>
    /// Gets or sets the owner province.
    /// </summary>
    /// <value>The owner province.</value>
    public string OwnerProvince { get; set; }

    /// <summary>
    /// Gets or sets the owner postal code.
    /// </summary>
    /// <value>The owner postal code.</value>
    public string OwnerPostalCode { get; set; }

    /// <summary>
    /// Gets or sets the owner email.
    /// </summary>
    /// <value>The owner email.</value>
    public string OwnerEmail { get; set; }

    /// <summary>
    /// Gets or sets the transaction number withdraw.
    /// </summary>
    /// <value>The transaction number withdraw.</value>
    public string TransactionNumberWithdraw { get; set; }

    /// <summary>
    /// Gets or sets the transaction number deposit.
    /// </summary>
    /// <value>The transaction number deposit.</value>
    public string TransactionNumberDeposit { get; set; }

    /// <summary>
    /// Gets or sets the transaction number NSF.
    /// </summary>
    /// <value>The transaction number NSF.</value>
    public string TransactionNumberNsf { get; set; }

    /// <summary>
    /// Gets or sets the amount limit withdraw.
    /// </summary>
    /// <value>The amount limit withdraw.</value>
    public string AmountLimitWithdraw { get; set; }

    /// <summary>
    /// Gets or sets the amount limit deposit.
    /// </summary>
    /// <value>The amount limit deposit.</value>
    public string AmountLimitDeposit { get; set; }

    /// <summary>
    /// Gets or sets the amount limit NSF.
    /// </summary>
    /// <value>The amount limit NSF.</value>
    public string AmountLimitNsf { get; set; }

    /// <summary>
    /// Gets or sets the transaction maximum amount.
    /// </summary>
    /// <value>The transaction maximum amount.</value>
    public string transactionMaxAmount { get; set; }

    /// <summary>
    /// Gets or sets the autorization mail1.
    /// </summary>
    /// <value>The autorization mail1.</value>
    public string autorizationMail1 { get; set; }

    /// <summary>
    /// Gets or sets the autorization mail2.
    /// </summary>
    /// <value>The autorization mail2.</value>
    public string autorizationMail2 { get; set; }

    /// <summary>
    /// Gets or sets the double authentication account.
    /// </summary>
    /// <value>The double authentication account.</value>
    public string DoubleAuthenticationAccount { get; set; }

    /// <summary>
    /// Gets or sets the authorization limit.
    /// </summary>
    /// <value>The authorization limit.</value>
    public string authorizationLimit { get; set; }

    /// <summary>
    /// Gets or sets the client autorisation limit.
    /// </summary>
    /// <value>The client autorisation limit.</value>
    public string clientAutorisationLimit { get; set; }

    /// <summary>
    /// Gets or sets the is accepted.
    /// </summary>
    /// <value>The is accepted.</value>
    public string IsAccepted { get; set; }

    /// <summary>
    /// Gets or sets the public token.
    /// </summary>
    /// <value>The public token.</value>
    public Guid PublicToken { get; set; }

    /// <summary>
    /// Retrieves or assigns the default language preference for a customer.
    /// </summary>
    /// <value>This property specifies the default language setting for a customer, allowing for personalized communication and interaction within the TIB Finance system.</value>
    public LanguageEnum DefaultCustomerLanguage { get; set; }

    }
}