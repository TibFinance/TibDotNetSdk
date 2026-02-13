
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ApplyChangeValidationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets a value indicating whether [record is modify].
    /// </summary>
    /// <value><c>true<c> if [record is modify]; otherwise, <c>false<c>.</value>
    public bool RecordIsModify { get; set; }

    }
}