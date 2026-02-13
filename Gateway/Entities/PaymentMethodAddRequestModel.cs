
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
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class PaymentMethodAddRequestModel 
    {
        
    /// <summary>
    /// This property holds the basic information necessary for creating or updating a merchant's account within the TIB Finance API system.
    /// </summary>
    /// <value>Contains essential details about the merchant.</value>
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