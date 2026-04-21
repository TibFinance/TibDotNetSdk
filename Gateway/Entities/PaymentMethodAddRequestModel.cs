
using System;
using System.Collections.Generic;
using Tib.Api.Model.Merchant;
using Tib.Api.Model.Payment;
using Tib.Api.Model.Customer;
using Tib.Api.Model.PaymentMethod;
using Tib.Api.Model.Bill;

namespace Tib.Api.Gateway.Entities
{
    /// <summary>
    /// Represents the PaymentMethodAddRequestModel model.
    /// </summary>
    public class PaymentMethodAddRequestModel 
    {
        
    /// <summary>
    /// Basic merchant details required for creating or updating a merchant record
    /// </summary>
    /// <value>Object of type MerchantModelBasicInfo; must not be null and must contain all required fields (e.g., merchantName, taxId, contactEmail). Field lengths and formats follow the MerchantModelBasicInfo schema; optional fields may be omitted.</value>
    public MerchantViewModel MerchantInfo { get; set; }

    /// <summary>
    /// Gets or sets the transfer information.
    /// </summary>
    /// <value>The transfer information.</value>
    public PaymentEntity TransferInfo { get; set; }

    /// <summary>
    /// Gets or sets the customer information.
    /// </summary>
    /// <value>The customer information.</value>
    public CustomerModel CustomerInfo { get; set; }

    /// <summary>
    /// Gets or sets the customer existing payment methods.
    /// </summary>
    /// <value>The customer existing payment methods.</value>
    public List<PaymentMethodModel> CustomerExistingPaymentMethods { get; set; }

    /// <summary>
    /// Gets or sets the related bill information.
    /// </summary>
    /// <value>The related bill information.</value>
    public BillModel RelatedBillInfo { get; set; }

    }
}