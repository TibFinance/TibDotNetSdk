
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Report
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetOperationsReportArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime DateFrom { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime DateTo { get; set; }

    /// <summary>
    /// Defines and manages the type of transfer operation within the system.
    /// </summary>
    /// <value>Specifies the category of the transfer, determining its processing logic and applicable rules.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public OperationTargetEnum TargetType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool ReturnTransferList { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public OperationCategoryReportType? LimitToSpecificCategory { get; set; }

    }
}