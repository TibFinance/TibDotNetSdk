
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model
{
    /// <summary>
    /// Represents the LoginAttempt model.
    /// </summary>
    public class LoginAttempt 
    {
        
    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    /// <value>The type.</value>
    public UserType Type { get; set; }

    /// <summary>
    /// Gets or sets the attempts.
    /// </summary>
    /// <value>The attempts.</value>
    public List<DateTime> Attempts { get; set; }

    }
}