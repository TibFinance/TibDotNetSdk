
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
    /// The full name of the customer who owns the recurring transfer.
    /// </summary>
    /// <value>String, up to 100 Unicode characters, may include spaces and hyphens; always present in the response.</value>
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
    /// The email address of the customer initiating the payment.
    /// </summary>
    /// <value>Must be a valid RFC‑5322 email, max 254 characters; required for receipt delivery and notifications.</value>
    public string CustomerEmail { get; set; }

    /// <summary>
    /// A collection of payment methods available to the requester.
    /// </summary>
    /// <value>IEnumerable of PaymentMethodModel objects; each includes identifiers, display name, and type. May be empty if no methods are configured. Order is not guaranteed.</value>
    public List<PaymentMethodModel> PaymentMethods { get; set; }

    /// <summary>
    /// The customer's contact information
    /// </summary>
    /// <value>A ContactInfoModel object containing phone numbers, email addresses, and mailing address. All fields are optional and may be null if not provided. Values follow standard E.164 format for phone numbers and RFC 5322 for email. Address fields are normalized per ISO 3166 country codes.</value>
    public ContactInfoModel ContactInfo { get; set; }

    }
}