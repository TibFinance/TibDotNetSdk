
using System;

namespace Tib.Api.Gateway.Entities
{
    /// <summary>
    /// Represents the LoginRelationsEntity model.
    /// </summary>
    public class LoginRelationsEntity 
    {
        
    /// <summary>
    /// Identifies this access. Pass it to Login to open a session on it.
    /// </summary>
    public Guid LoginsUserRelationsId { get; set; }

    /// <summary>
    /// The level of this access. The usual values are 2 (client), 4 (merchant) and 16 (service).
    /// </summary>
    public int InternalReferenceType { get; set; }

    /// <summary>
    /// The ID of the client, merchant or service this access is for. For a merchant-level access, it is the MerchantId.
    /// </summary>
    public Guid InternalReferenceId { get; set; }

    /// <summary>
    /// A display label for this access, usually naming its client, merchant or service. For display only; do not parse it.
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// True when this access is read-only.
    /// </summary>
    public bool IsReadOnly { get; set; }

    }
}