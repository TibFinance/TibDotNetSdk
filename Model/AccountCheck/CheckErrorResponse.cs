
using System;
using Tib.Api.Model.AccountCheck;
using Tib.Api.CryptedService;

namespace Tib.Api.Model.AccountCheck
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CheckErrorResponse : BaseCryptedServiceResponse
    {
        
    /// <summary>
    /// Gets or sets the check result.
    /// </summary>
    /// <value>The check result.</value>
    public CheckResultModel CheckResult { get; set; }

    /// <summary>
    /// Gets or sets the result.
    /// </summary>
    /// <value>The result.</value>
    public List<CheckResultDetailModel> Result { get; set; }

    }
}