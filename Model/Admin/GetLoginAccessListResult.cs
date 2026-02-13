
using System;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetLoginAccessListResult 
    {
        
    /// <summary>
    /// Retrieves or assigns the identifier for user login relations.
    /// </summary>
    /// <value>Represents the unique identifier associated with user login relations.</value>
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
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the IsReadOnly.
    /// </summary>
    /// <value>IsReadOnly.</value>
    public bool IsReadOnly { get; set; }

    }
}