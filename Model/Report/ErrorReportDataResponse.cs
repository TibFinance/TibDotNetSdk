
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Report
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
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