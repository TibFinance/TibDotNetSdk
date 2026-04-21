
using System;
using Tib.Api.Financial;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the FinalizeTransferWithExternalSupplierFinancialInformationsArgs model.
    /// </summary>
    public class FinalizeTransferWithExternalSupplierFinancialInformationsArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool SupplierAccountAlreadyExists { get; set; }

    /// <summary>
    /// The target bank account for the direct payment.
    /// </summary>
    /// <value>Must be a valid, active AccountModel (e.g., accountNumber, routingNumber) belonging to the payer; cannot be null.</value>
    public AccountModel Account { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? CustomerConsent { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool PreAuthorizationGivenForThisMerchant { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool PreAuthorizationGivenForAllMerchants { get; set; }

    }
}