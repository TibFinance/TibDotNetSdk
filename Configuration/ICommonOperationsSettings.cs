
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Configuration
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public interface ICommonOperationsSettings 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IncludeStack { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public TransactionMailingInfo TransactionMailingSettings { get; set; }

    }
}