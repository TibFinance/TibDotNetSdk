
using System;
using Tib.Api.Financial;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Represents the CreateInteracPaymentMethodArgs model.
    /// </summary>
    public class CreateInteracPaymentMethodArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Unique identifier of the customer owning the recurring transfers
    /// </summary>
    /// <value>A non‑null GUID that matches an existing customer record; used to correlate transfers with the correct account</value>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Indicates whether this payment method is configured as the customer's automatic payment method.
    /// </summary>
    /// <value>True if the method will be used for automatic payments, false otherwise. Only applicable to payment methods that support auto‑pay; the flag is read‑only in this response.</value>
    public bool IsCustomerAutomaticPaymentMethod { get; set; }

    /// <summary>
    /// Details of the Interac e‑transfer payment method to be created.
    /// </summary>
    /// <value>Required InteracModel containing valid Canadian banking fields (bankAccountNumber, transitNumber, institutionNumber) and optional description; all values must conform to Canadian banking format and the object cannot be null.</value>
    public InteracModel InteracInformation { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    }
}