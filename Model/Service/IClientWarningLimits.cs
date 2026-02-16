
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the IClientWarningLimits interface.
    /// </summary>
    public interface IClientWarningLimits 
    {
        
    /// <summary>
    /// Gets or sets the client warning deposit limit.
    /// </summary>
    /// <value>The client warning deposit limit.</value>
    public decimal ClientWarningDepositLimit { get; set; }

    /// <summary>
    /// Gets or sets the client warning collection limit.
    /// </summary>
    /// <value>The client warning collection limit.</value>
    public decimal ClientWarningCollectionLimit { get; set; }

    }
}