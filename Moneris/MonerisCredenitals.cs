
using System;

namespace Tib.Api.Moneris
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class MonerisCredenitals 
    {
        
    /// <summary>
    /// Gets or sets the store identifier.
    /// </summary>
    /// <value>The store identifier.</value>
    public string StoreID { get; set; }

    /// <summary>
    /// Gets or sets the API token.
    /// </summary>
    /// <value>The API token.</value>
    public string ApiToken { get; set; }

    /// <summary>
    /// Gets or sets the country code.
    /// </summary>
    /// <value>The country code.</value>
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the crypt.
    /// </summary>
    /// <value>The crypt.</value>
    public string Crypt { get; set; }

    /// <summary>
    /// Gets or sets the CVD idicator.
    /// </summary>
    /// <value>The CVD idicator.</value>
    public string CvdIdicator { get; set; }

    }
}