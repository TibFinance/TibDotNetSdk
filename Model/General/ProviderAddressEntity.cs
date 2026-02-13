
using System;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ProviderAddressEntity 
    {
        
    /// <summary>
    /// Gets or sets the type of the URL.
    /// </summary>
    /// <value>The type of the URL.</value>
    public string UrlType { get; set; }

    /// <summary>
    /// Gets or sets the URL.
    /// </summary>
    /// <value>The URL.</value>
    public string Url { get; set; }

    /// <summary>
    /// Gets or sets the port.
    /// </summary>
    /// <value>The port.</value>
    public int Port { get; set; }

    }
}