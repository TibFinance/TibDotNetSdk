
using System;
using System.Collections.Generic;
using Tib.Api.Model.Client;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the GetConsolidationInternalReportResponse model.
    /// </summary>
    public class GetConsolidationInternalReportResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the consolidation internal report list.
    /// </summary>
    /// <value>The consolidation internal report list.</value>
    public List<ConsolidationInternalReportEntity> ConsolidationInternalReportList { get; set; }

    }
}