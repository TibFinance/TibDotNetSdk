
using System;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Model.AccountCheck
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CheckNsfArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Contains the necessary details for replacing a merchant's account information within the system.
    /// </summary>
    /// <value>This model represents the account details associated with a merchant, ensuring that all relevant information is accurately captured and stored.</value>
    public AccountModel Account { get; set; }

    }
}