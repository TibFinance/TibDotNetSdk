
using System;
using System.Collections.Generic;
using Tib.Api.Model.General;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Report
{
    /// <summary>
    /// Represents the GetOperationsReportResponse model.
    /// </summary>
    public class GetOperationsReportResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the date line report.
    /// </summary>
    /// <value>The date line report.</value>
    public List<OperationDateReportEntity> DateLineReport { get; set; }

    /// <summary>
    /// Transfers lists related to the query
    /// </summary>
    /// <value></value>
    public List<TransferBaseInformationEntity> Transfers { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<USOperationReportEntity> USOperationsData { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsBrandNewSupplier { get; set; }

    }
}