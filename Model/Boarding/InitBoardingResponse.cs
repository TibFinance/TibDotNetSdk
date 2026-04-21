
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the InitBoardingResponse model.
    /// </summary>
    public class InitBoardingResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// URL to redirect the merchant to for completing the boarding application.
    /// </summary>
    /// <value></value>
    public string RedirectUrl { get; set; }

    }
}