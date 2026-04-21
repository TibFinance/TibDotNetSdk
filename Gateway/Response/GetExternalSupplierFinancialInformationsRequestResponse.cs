
using System;
using Tib.Api.Gateway.Entities;
using Tib.Api.Model.Merchant;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Represents the GetExternalSupplierFinancialInformationsRequestResponse model.
    /// </summary>
    public class GetExternalSupplierFinancialInformationsRequestResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public PaymentMethodAddRequestModel PaymentMethodRequestData { get; set; }

    /// <summary>
    /// Basic merchant details required for creating or updating a merchant record
    /// </summary>
    /// <value>Object of type MerchantModelBasicInfo; must not be null and must contain all required fields (e.g., merchantName, taxId, contactEmail). Field lengths and formats follow the MerchantModelBasicInfo schema; optional fields may be omitted.</value>
    public MerchantViewModel MerchantInfo { get; set; }

    }
}