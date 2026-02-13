
using System;

namespace Tib.Api.SESAR
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SESARWebHookArgs 
    {
        
    /// <summary>
    /// The crypted manifest
    /// </summary>
    /// <value></value>
    public string CryptedObject { get; set; }

    /// <summary>
    /// The hashkey of the crytped key used
    /// </summary>
    /// <value></value>
    public string HashKey { get; set; }

    }
}