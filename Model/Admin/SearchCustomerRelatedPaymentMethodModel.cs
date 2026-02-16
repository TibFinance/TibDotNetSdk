
using System;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the SearchCustomerRelatedPaymentMethodModel model.
    /// </summary>
    public class SearchCustomerRelatedPaymentMethodModel 
    {
        
    /// <summary>
    /// Acts as a unique identifier for a distinct payment method.
    /// </summary>
    /// <value>This unique identifier, or token, is specifically associated with a single payment method.</value>
    public Guid? PaymentMethodId { get; set; }

    /// <summary>
    /// Provides a detailed description of the payment method for easy identification.
    /// </summary>
    /// <value>The 'PaymentMethodDescription' property stores a descriptive string that offers a comprehensive understanding of the specific payment method.</value>
    public string PaymentMethodDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? PaymentMethodIsDeleted { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AccountInformationOwner { get; set; }

    }
}