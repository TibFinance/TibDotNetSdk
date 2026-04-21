
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the CreatePaymentResponse model.
    /// </summary>
    public class CreatePaymentResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Unique identifier of the newly created payment
    /// </summary>
    /// <value>System‑generated GUID (36‑character string), immutable and required for all subsequent payment‑related operations</value>
    public Guid? PaymentId { get; set; }

    /// <summary>
    /// The payment flow that the system automatically selected for the created payment.
    /// </summary>
    /// <value>Returned as a PaymentFlowEnum value (e.g., STANDARD, INSTANT, RECURRING). Present only when auto‑selection is enabled; otherwise null. Must match one of the defined enum members.</value>
    public PaymentFlowEnum? AutoSelectPaymentFlowResult { get; set; }

    /// <summary>
    /// Indicates the outcome of parsing the payment flow request
    /// </summary>
    /// <value>Enum values (e.g., SUCCESS, INVALID_FORMAT, MISSING_FIELDS, UNSUPPORTED_CURRENCY) describe whether the payment flow was parsed correctly or why it failed; returned only in the response payload.</value>
    public PaymentFlowParsingResultEnum PaymentFlowParsingResult { get; set; }

    /// <summary>
    /// A URL that the payer can visit to complete the created payment.
    /// </summary>
    /// <value>HTTPS string, max 2048 characters, unique per transaction, expires according to the payment's TTL; must be URL‑encoded and reachable by the client.</value>
    public string PaymentLink { get; set; }

    }
}