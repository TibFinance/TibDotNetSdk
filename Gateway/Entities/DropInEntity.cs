
using System;
using System.Collections.Generic;
using Tib.Api.Model.PaymentMethod;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Gateway.Entities
{
    /// <summary>
    /// Represents the DropInEntity model.
    /// </summary>
    public class DropInEntity 
    {
        
    /// <summary>
    /// Gets or sets the customer existings payments.
    /// </summary>
    /// <value>The customer existings payments.</value>
    public List<PaymentMethodModel> CustomerExistingsPayments { get; set; }

    /// <summary>
    /// Gets or sets the amout.
    /// </summary>
    /// <value>The amout.</value>
    public decimal Amout { get; set; }

    /// <summary>
    /// Defines and manages the type of transfer operation within the system.
    /// </summary>
    /// <value>Specifies the category of the transfer, determining its processing logic and applicable rules.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// Gets or sets the authorized payment mode.
    /// </summary>
    /// <value>The authorized payment mode.</value>
    public AutorizedPaymentMethodFlags AuthorizedPaymentMode { get; set; }

    /// <summary>
    /// Gets or sets the external reference number used to link this entity with an external system or business process.
    /// </summary>
    /// <value>The external reference number associated with the entity.</value>
    public string ExternalReferenceNumber { get; set; }

    /// <summary>
    /// Gets or sets the title that identifies the object in a human‑readable way.
    /// </summary>
    /// <value>A short, descriptive string displayed in user interfaces and reports.</value>
    public string Title { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the due date for a payment.
    /// </summary>
    /// <value>The date and time when the payment must be completed, expressed in UTC.</value>
    public DateTime? PaymentDueDate { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string MerchantPhone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string MerchantEmail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool RequestPPAFromCustomer { get; set; }

    }
}