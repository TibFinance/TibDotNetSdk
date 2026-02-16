
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Report
{
    /// <summary>
    /// Represents the ErrorReportDataResponse model.
    /// </summary>
    public class ErrorReportDataResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// ErrorReportDataList contains the list of errors recorded
    /// </summary>
    /// <value></value>
    public List<ErrorReportData> ErrorReportDataList { get; set; }

    }
}