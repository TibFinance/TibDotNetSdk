
using System;
using Tib.Api.Common;
using Tib.Api.Common.Contract;

namespace Tib.Api.Model.Transfer.Args
{
    /// <summary>
    /// Represents the AdminTransferValidationRequestArgs model.
    /// </summary>
    public class AdminTransferValidationRequestArgs : ClientCallBaseArgs, IPublicTokenObject
    {
        
    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="AdminTransferValidationRequestArgs"> is approved.
    /// </summary>
    /// <value><c>true<c> if approved; otherwise, <c>false<c>.</value>
    public bool Approved { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the public token required to initiate a drop‑in session.
    /// </summary>
    /// <value>A GUID that uniquely identifies the public token issued by TIB Finance.</value>
    public Guid PublicTokenId { get; set; }

    }
}