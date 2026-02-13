
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SearchAdminArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string SearchText { get; set; }

    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public string ClientId { get; set; }

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
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> MerchantIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> CustomerIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> TransferIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> OperationIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> TransactionGroupIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> TransactionIds { get; set; }

    /// <summary>
    /// Defines and manages the type of transfer operation within the system.
    /// </summary>
    /// <value>Specifies the category of the transfer, determining its processing logic and applicable rules.</value>
    public int? TransferType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? TIBAuthorizationStatus { get; set; }

    /// <summary>
    /// Specifies the target of an operation, indicating whether the operation pertains to the merchant or the customer.
    /// </summary>
    /// <value>Enum value that identifies the operation target.</value>
    public int? OperationTarget { get; set; }

    /// <summary>
    /// Specifies the direction of the operation, indicating whether funds are being collected or deposited.
    /// </summary>
    /// <value>A TransferDirectionEnum value that represents the operation direction (Collect or Deposit).</value>
    public int? OperationDirection { get; set; }

    /// <summary>
    /// Specifies the category of a financial operation.
    /// </summary>
    /// <value>Indicates the type of operation, such as deposit, collection, fee, or other supported categories defined by the API.</value>
    public int? OperationKind { get; set; }

    /// <summary>
    /// Retrieves the numeric status code of an operation.
    /// </summary>
    /// <value>The property holds an integer that identifies the current status of the operation.</value>
    public int? OperationStatus { get; set; }

    /// <summary>
    /// Specifies the operation category used throughout the API.
    /// </summary>
    /// <value>Represents the operation type defined in the OperationTypeEnum, enabling the system to differentiate between deposit, collection, fee, and other transaction flows.</value>
    public int? OperationType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int RowCount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? IsTextSearch { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? IsRevertSearch { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime DueDateFrom { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime DueDateTo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime ExecutedFrom { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime ExecutedTo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime RealDueDateFrom { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime RealDueDateTo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime LastModifiedDateFrom { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime LastModifiedDateTo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsCreatedDateChecked { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsDueDateChecked { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsExecutedDateChecked { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsRealDueDateChecked { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsLastModifiedDateChecked { get; set; }

    }
}