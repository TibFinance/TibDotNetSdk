
using System;
using Tib.Api.Model.Admin;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the DuplicateOperationResponse model.
    /// </summary>
    public class DuplicateOperationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public AdminOperationModel Operation { get; set; }

    }
}