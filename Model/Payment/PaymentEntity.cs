
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the PaymentEntity model.
    /// </summary>
    public class PaymentEntity 
    {
        
    /// <summary>
    /// Specifies the execution mode used for processing a payment.
    /// </summary>
    /// <value>Indicates which payment flow is applied (e.g., AutoSelect, Anonymous, DirectDeposit, etc.).</value>
    public PaymentFlowEnum PaymentFlow { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// Identifies the customer linked to this payment, when a customer relationship exists.
    /// </summary>
    /// <value>The unique GUID that references the associated customer record.</value>
    public Guid? RelatedCustomerId { get; set; }

    /// <summary>
    /// Specifies the due date for the payment. If the value is null, the system treats the due date as the current date and time.
    /// </summary>
    /// <value>The date and time by which the payment must be completed.</value>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Defines the frequency at which transfers occur within the TIB Finance API.
    /// </summary>
    /// <value>This enumeration specifies the intervals for executing financial transfers, enabling precise scheduling and management of recurring transactions.</value>
    public TransferFrequencyEnum TransferFrequency { get; set; }

    /// <summary>
    /// Specifies the amount to be paid. The value must not exceed the sum of the associated bill amount and any previously recorded payments. If null, the system applies the remaining unpaid portion of the bill.
    /// </summary>
    /// <value>The monetary amount of the payment, expressed as a decimal number.</value>
    public decimal? PaymentAmount { get; set; }

    /// <summary>
    /// Identifies the customer payment method that is mandatory when the payment flow operates in forced mode.
    /// </summary>
    /// <value>Guid of the forced customer payment method.</value>
    public Guid? ForcedCustomerPaymentMethodId { get; set; }

    /// <summary>
    /// Represents the unique identifier for a group within the TIB Finance API.
    /// </summary>
    /// <value>The GroupId is used to uniquely identify and manage groups, ensuring precise operations within the API.</value>
    public string GroupId { get; set; }

    /// <summary>
    /// External reference identifier supplied by the client to correlate the transaction with external systems.
    /// </summary>
    /// <value>A free‑form alphanumeric string that uniquely identifies the transaction in the client’s external system.</value>
    public string ExternalReferenceIdentification { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public AutorizedPaymentMethodFlags? AutorizedPaymentMethod { get; set; }

    /// <summary>
    /// Indicates if the system must request the customer's consent prior to executing the payment.
    /// </summary>
    /// <value>Set to true to trigger a consent request; false skips the consent step.</value>
    public bool? AskForCustomerConsent { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsDeleted { get; set; }

    }
}