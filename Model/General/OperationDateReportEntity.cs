
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Model.General;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the OperationDateReportEntity model.
    /// </summary>
    public class OperationDateReportEntity 
    {
        
    /// <summary>
    /// Gets or sets the report date.
    /// </summary>
    /// <value>The report date.</value>
    public DateTime ReportDate { get; set; }

    /// <summary>
    /// Gets or sets the categories.
    /// </summary>
    /// <value>The categories.</value>
    public Dictionary<OperationCategoryReportType, OperationCategoryReportEntity> Categories { get; set; }

    }
}