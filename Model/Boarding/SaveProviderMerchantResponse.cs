
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the SaveProviderMerchantResponse model.
    /// </summary>
    public class SaveProviderMerchantResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Represents the current state of a transaction within the system.
    /// </summary>
    /// <value>The Status integer indicates the progress or outcome of a transaction, providing essential information for error handling and process monitoring.</value>
    public string Status { get; set; }

    }
}