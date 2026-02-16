
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the AddProviderTransactionsArgs model.
    /// </summary>
    public class AddProviderTransactionsArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the provider.
    /// </summary>
    /// <value>The provider.</value>
    public ProviderEnum Provider { get; set; }

    /// <summary>
    /// Gets or sets the content of the file.
    /// </summary>
    /// <value>The content of the file.</value>
    public string FileContent { get; set; }

    }
}