
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Model.PaymentMethod;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the CustomerEntity model.
    /// </summary>
    public class CustomerEntity 
    {
        
    /// <summary>
    /// The name of the customer
    /// </summary>
    /// <value>The name of the customer.</value>
    public string CustomerName { get; set; }

    /// <summary>
    /// The external identifier assigned to the customer by the client’s system.
    /// </summary>
    /// <value>String; must be unique per customer, case‑sensitive, up to 50 characters; may be empty only if the customer has no external reference.</value>
    public string CustomerExternalId { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// A textual description of the customer identified by the external ID
    /// </summary>
    /// <value>Free‑form Unicode string, up to 255 characters; may be omitted if no description is defined</value>
    public string CustomerDescription { get; set; }

    /// <summary>
    /// Email address of the customer.
    /// </summary>
    public string CustomerEmail { get; set; }

    /// <summary>
    /// Payment methods registered for this customer. Populated on read; ignored when supplied on create or save — use CreateDirectAccountPaymentMethod, CreateCreditCardPaymentMethod or CreateInteracPaymentMethod to register one.
    /// </summary>
    public List<PaymentMethodModel> PaymentMethods { get; set; }

    /// <summary>
    /// Contact information of the customer to be created
    /// </summary>
    /// <value>Provides email, phone, and address; at least one contact method (email or phone) is required; fields must conform to standard format and length constraints defined in ContactInfoModel</value>
    public ContactInfoModel ContactInfo { get; set; }

    }
}