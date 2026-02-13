
using System;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ClientSettings 
    {
        
    /// <summary>
    /// Gets or sets the daily collection limit applied to the service contract.
    /// </summary>
    /// <value>The maximum total amount that can be collected in a single day. The value must be between 100 and 100,000,000.</value>
    public decimal CollectionLimitDaily { get; set; }

    /// <summary>
    /// Gets or sets the maximum amount that can be deposited in a single day for the client’s service contract.
    /// </summary>
    /// <value>Daily deposit ceiling expressed as a decimal value in the account’s currency.</value>
    public decimal DepositLimitDaily { get; set; }

    /// <summary>
    /// Gets the tib warning collection limit daily.
    /// </summary>
    /// <value>The tib warning collection limit daily.</value>
    public decimal ClientWarningCollectionLimitDaily { get; set; }

    /// <summary>
    /// Gets the tib warning deposit limit daily.
    /// </summary>
    /// <value>The tib warning deposit limit daily.</value>
    public decimal ClientWarningDepositLimitDaily { get; set; }

    }
}