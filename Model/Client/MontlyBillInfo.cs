
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class MontlyBillInfo 
    {
        
    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// Specifies the default language used by the merchant within the TIB Finance API. This setting is crucial for ensuring that all communications and operations are conducted in the preferred language of the merchant.
    /// </summary>
    /// <value>Defines the language preference for the merchant.</value>
    public LanguageEnum MerchantLanguage { get; set; }

    /// <summary>
    /// Specifies the category of a financial operation.
    /// </summary>
    /// <value>Indicates the type of operation, such as deposit, collection, fee, or other supported categories defined by the API.</value>
    public OperationKindEnum OperationKind { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int TotalCount { get; set; }

    /// <summary>
    /// Identifies the type of payment method linked to a specific account.
    /// </summary>
    /// <value>A unique identifier representing the type of the payment method.</value>
    public PaymentMethodTypeEnum PaymentMethodType { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    }
}