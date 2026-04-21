
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
    /// Indicates the category of the recurring transfer (e.g., inbound, outbound, internal).
    /// </summary>
    /// <value>Enum TransferTypeEnum; possible values: INBOUND, OUTBOUND, INTERNAL. Returned in uppercase; null if not applicable.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// Gets or sets the authorized payment mode.
    /// </summary>
    /// <value>The authorized payment mode.</value>
    public AutorizedPaymentMethodFlags AuthorizedPaymentMode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ExternalReferenceNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Title { get; set; }

    /// <summary>
    /// Human‑readable description of the transfer
    /// </summary>
    /// <value>Free‑form UTF‑8 text describing the purpose or details of the transfer; optional, max length 255 characters</value>
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime? PaymentDueDate { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The name of the merchant associated with the transfer.
    /// </summary>
    /// <value>String, up to 100 characters; may be empty or null if the transfer has no merchant context.</value>
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