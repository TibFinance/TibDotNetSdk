
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Das;
using Tib.Api.Common;

namespace Tib.Api.Das
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class AddNewDasPaymentArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// The provider Id on which perform the payment.
    /// </summary>
    /// <value></value>
    public Guid DasProviderId { get; set; }

    /// <summary>
    /// Dertermine which payment object passed will be processed
    /// </summary>
    /// <value></value>
    public DasProviderTypeEnum DasPaymentProviderType { get; set; }

    /// <summary>
    /// Payment for canada provider
    /// </summary>
    /// <value></value>
    public DasPaymentCanadaEntity DasPaymentCanada { get; set; }

    /// <summary>
    /// Payment for Quebec provider
    /// </summary>
    /// <value></value>
    public DasPaymentQuebecEntity DasPaymentQuebec { get; set; }

    }
}