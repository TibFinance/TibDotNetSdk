
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
    /// Gets or sets the type of the provider.
    /// </summary>
    /// <value>The type of the provider.</value>
    public ProviderEnum ProviderType { get; set; }

    /// <summary>
    /// Gets or sets the account operations.
    /// </summary>
    /// <value>The account operations.</value>
    public List<AccountOperationLine> AccountOperations { get; set; }

    }
}