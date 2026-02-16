
using System;
using System.Collections.Generic;
using Tib.Api.Model.AccountCheck;
using Tib.Api.Common;

namespace Tib.Api.Model.AccountCheck
{
    /// <summary>
    /// Represents the CheckErrorReponse model.
    /// </summary>
    public class CheckErrorReponse : ClientBaseResponse
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