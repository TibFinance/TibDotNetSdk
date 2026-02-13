
using System;
using System.Collections.Generic;
using Tib.Api.Model.General;
using Tib.Api.Common;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetSummaryInformationsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the aggregated category extractions.
    /// </summary>
    /// <value>The aggregated category extractions.</value>
    public List<AggregatedCategoryExtraction> AggregatedCategoryExtractions { get; set; }

    /// <summary>
    /// Gets or sets the monthly transaction stats.
    /// </summary>
    /// <value>The monthly transaction stats.</value>
    public List<MonthlyStats> MonthlyTransactionStats { get; set; }

    /// <summary>
    /// Gets or sets the daily cashback stats.
    /// </summary>
    /// <value>The daily cashback stats.</value>
    public List<CashBackStats> DailyCashbackStats { get; set; }

    }
}