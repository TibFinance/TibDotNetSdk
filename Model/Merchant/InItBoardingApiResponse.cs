
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class InItBoardingApiResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Merchant information
    /// </summary>
    /// <value>The merchant.</value>
    public int NoOfPendingBoarding { get; set; }

    /// <summary>
    /// Merchant information
    /// </summary>
    /// <value>The merchant.</value>
    public int NoOfActiveBoarding { get; set; }

    }
}