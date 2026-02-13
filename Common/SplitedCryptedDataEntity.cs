
using System;

namespace Tib.Api.Common
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SplitedCryptedDataEntity 
    {
        
    /// <summary>
    /// Gets or sets the base64 crypted data part1.
    /// </summary>
    /// <value>The base64 crypted data part1.</value>
    public string Base64CryptedDataPart1 { get; set; }

    /// <summary>
    /// Gets or sets the base64 crypted data part2.
    /// </summary>
    /// <value>The base64 crypted data part2.</value>
    public string Base64CryptedDataPart2 { get; set; }

    }
}