
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the ILogin interface.
    /// </summary>
    public interface ILogin 
    {
        
    /// <summary>
    /// Retrieves or assigns the identifier for user login relations.
    /// </summary>
    /// <value>Represents the unique identifier associated with user login relations.</value>
    public Guid LoginsUserRelationsId { get; set; }

    }
}