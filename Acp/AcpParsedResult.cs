
using System;
using System.Collections.Generic;
using Tib.Api.Acp;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Acp
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class AcpParsedResult 
    {
        
    /// <summary>
    /// Gets or sets the first line.
    /// </summary>
    /// <value>The first line.</value>
    public LineBaseWithHeader FirstLine { get; set; }

    /// <summary>
    /// Gets or sets all transactions.
    /// </summary>
    /// <value>All transactions.</value>
    public Dictionary<AcpTransactionTypeEnum, List<BaseTransaction>> AllTransactions { get; set; }

    /// <summary>
    /// Gets or sets the last line.
    /// </summary>
    /// <value>The last line.</value>
    public BaseLastLine LastLine { get; set; }

    }
}