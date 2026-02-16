
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the CreateServiceRequestFormArgs model.
    /// </summary>
    public class CreateServiceRequestFormArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the merchant email.
    /// </summary>
    /// <value>The merchant email.</value>
    public string MerchantEmail { get; set; }

    }
}