
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the ProviderAccountOperations model.
    /// </summary>
    public class ProviderAccountOperations 
    {
        
    /// <summary>
    /// Identifies the category of the service provider for the requested service
    /// </summary>
    /// <value>Returns a ProviderEnum value (e.g., BANK, BROKER, PAYMENT_GATEWAY). Must be one of the defined enum members; case‑sensitive and always present in the GetService response.</value>
    public ProviderEnum ProviderType { get; set; }

    /// <summary>
    /// Gets or sets the account operations.
    /// </summary>
    /// <value>The account operations.</value>
    public List<AccountOperationLine> AccountOperations { get; set; }

    }
}