
using System;

namespace Tib.Api.Gateway.Entities
{
    /// <summary>
    /// Represents the LoginRelationsEntity model.
    /// </summary>
    public class LoginRelationsEntity 
    {
        
    /// <summary>
    /// Gets or sets the logins user relations identifier.
    /// </summary>
    /// <value>The logins user relations identifier.</value>
    public Guid LoginsUserRelationsId { get; set; }

    /// <summary>
    /// Gets or sets the type of the internal reference.
    /// </summary>
    /// <value>The type of the internal reference.</value>
    public int InternalReferenceType { get; set; }

    /// <summary>
    /// The level of login related ID
    /// </summary>
    /// <value></value>
    public Guid InternalReferenceId { get; set; }

    /// <summary>
    /// Human‑readable description of the transfer
    /// </summary>
    /// <value>Free‑form UTF‑8 text describing the purpose or details of the transfer; optional, max length 255 characters</value>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the IsReadOnly.
    /// </summary>
    /// <value>IsReadOnly.</value>
    public bool IsReadOnly { get; set; }

    }
}