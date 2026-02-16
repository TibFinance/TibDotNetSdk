
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the PreferenceDTOResponse model.
    /// </summary>
    public class PreferenceDTOResponse : ClientBaseResponse
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