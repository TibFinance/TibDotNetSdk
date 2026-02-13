
using System;
using Tib.Api.Gateway.Entities;
using Tib.Api.Model.Merchant;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetExternalSupplierFinancialInformationsRequestResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public PaymentMethodAddRequestModel PaymentMethodRequestData { get; set; }

    /// <summary>
    /// This property holds the basic information necessary for creating or updating a merchant's account within the TIB Finance API system.
    /// </summary>
    /// <value>Contains essential details about the merchant.</value>
    public MerchantViewModel MerchantInfo { get; set; }

    }
}