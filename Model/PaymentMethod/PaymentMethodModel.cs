
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Represents the PaymentMethodModel model.
    /// </summary>
    public class PaymentMethodModel 
    {
        
    /// <summary>
    /// Acts as a unique identifier for a distinct payment method.
    /// </summary>
    /// <value>This unique identifier, or token, is specifically associated with a single payment method.</value>
    public Guid PaymentMethodId { get; set; }

    /// <summary>
    /// Determines if the customer's payment method is set as the default for automatic transactions.
    /// </summary>
    /// <value>This property returns a boolean value. It yields 'true' if the customer's payment method is configured for automatic transactions, and 'false' otherwise.</value>
    public bool IsCustomerAutomaticPaymentMethod { get; set; }

    /// <summary>
    /// Identifies the type of payment method linked to a specific account.
    /// </summary>
    /// <value>A unique identifier representing the type of the payment method.</value>
    public PaymentMethodTypeEnum PaymentMethodType { get; set; }

    /// <summary>
    /// Provides a detailed description of the payment method for easy identification.
    /// </summary>
    /// <value>The 'PaymentMethodDescription' property stores a descriptive string that offers a comprehensive understanding of the specific payment method.</value>
    public string PaymentMethodDescription { get; set; }

    /// <summary>
    /// Provides a secure representation of the account card number associated with a specific payment method.
    /// </summary>
    /// <value>The 'AccountPreview' property securely displays the account card number by masking certain digits, thereby safeguarding sensitive information.</value>
    public string AccountPreview { get; set; }

    /// <summary>
    /// Handles the extraction or assignment of a particular entity's expiration date.
    /// </summary>
    /// <value>Denotes the expiration date of a specific entity, represented as a DateTime object.</value>
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// The 'Owner' property is designed to assign and identify the ownership of a specific resource or object within the system.
    /// </summary>
    /// <value>The 'Owner' property holds a unique string value that signifies the identifier of the owner, ensuring distinct representation within the system.</value>
    public string Owner { get; set; }

    /// <summary>
    /// Fetches a list of merchants who are preauthorized for a Preauthorized Payment Agreement (PPA) on a specified payment method.
    /// </summary>
    /// <value>This property encapsulates a list of merchant identifiers and corresponding names that have received preauthorization for PPA.</value>
    public List<MerchantIdName> PreauthorizedMerchants { get; set; }

    }
}