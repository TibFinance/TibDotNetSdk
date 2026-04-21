
using System;
using Tib.Api.Common;
using Tib.Api.Common.Contract;

namespace Tib.Api.Model.DropIn
{
    /// <summary>
    /// Represents the GetDropInPublicTokenResponse model.
    /// </summary>
    public class GetDropInPublicTokenResponse : ClientBaseResponse, IPublicTokenObject
    {
        
    /// <summary>
    /// Generated public token identifier used to initialize the Drop-In payment form.
    /// </summary>
    /// <value></value>
    public Guid PublicTokenId { get; set; }

    }
}