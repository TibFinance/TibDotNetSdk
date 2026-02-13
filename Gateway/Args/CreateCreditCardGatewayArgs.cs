
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateCreditCardGatewayArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Determines if the customer's payment method is set as the default for automatic transactions.
    /// </summary>
    /// <value>This property returns a boolean value. It yields 'true' if the customer's payment method is configured for automatic transactions, and 'false' otherwise.</value>
    public bool IsCustomerAutomaticPaymentMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string provider { get; set; }

    /// <summary>
    /// Manages all operations associated with credit card data.
    /// </summary>
    /// <value>Represents a distinct numerical identifier that corresponds to a specific credit card in the system.</value>
    public CreditCardModel CreditCard { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsCustomerPreAutorized { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsGatewayCall { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool SkipValidation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsImmediate { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BinCategory { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CardCategory { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CardSubType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CcBin { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CcType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string IsRegulatedCard { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string IssuingCountry { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Token { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Exp { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Last4Digits { get; set; }

    /// <summary>
    /// Specifies the name of the card owner.
    /// </summary>
    /// <value>Represents the name of the individual who owns the credit card. This information is crucial for validating and processing transactions.</value>
    public string CardOwner { get; set; }

    /// <summary>
    /// For ZipCode only situation, not full address
    /// </summary>
    /// <value></value>
    public string ZipCode { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public PublicAccessTokenRoutingType? RoutingType { get; set; }

    }
}