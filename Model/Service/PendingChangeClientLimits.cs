
using System;
using Tib.Api.Model.Service;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class PendingChangeClientLimits : IClientWarningLimits
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Retrieves or updates the warning deposit limit configured for a client.
    /// </summary>
    /// <value>The monetary amount that triggers a warning when a client attempts to deposit more than this value. Represented as a decimal amount in the account's currency.</value>
    public decimal ClientWarningDepositLimit { get; set; }

    /// <summary>
    /// Gets or sets the warning collection limit for a client. This limit defines the monetary threshold at which the system raises a warning for client collection activities.
    /// </summary>
    /// <value>The decimal value representing the client’s warning collection threshold.</value>
    public decimal ClientWarningCollectionLimit { get; set; }

    }
}