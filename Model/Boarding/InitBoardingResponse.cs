
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class InitBoardingResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Specifies the URL to which the user is redirected after a successful operation within the TIB Finance API.
    /// </summary>
    /// <value>The RedirectUrl property holds the destination URL that users are directed to upon the completion of a process. This URL is crucial for guiding users back to the application or a specific page after an API interaction.</value>
    public string RedirectUrl { get; set; }

    }
}