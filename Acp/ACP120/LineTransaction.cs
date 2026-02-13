
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Acp;

namespace Tib.Api.Acp.ACP120
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class LineTransaction : BaseTransaction
    {
        
    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// Gets or sets the date funds available.
    /// </summary>
    /// <value>The date funds available.</value>
    public DateTime DateFundsAvailable { get; set; }

    /// <summary>
    /// Gets or sets the target institution number.
    /// </summary>
    /// <value>The target institution number.</value>
    public string TargetInstitutionNumber { get; set; }

    /// <summary>
    /// Gets or sets the target full account number.
    /// </summary>
    /// <value>The target full account number.</value>
    public string TargetFullAccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the name of the target.
    /// </summary>
    /// <value>The name of the target.</value>
    public string TargetName { get; set; }

    /// <summary>
    /// Gets or sets the reference number.
    /// </summary>
    /// <value>The reference number.</value>
    public string RefNumber { get; set; }

    /// <summary>
    /// Specifies the operation category used throughout the API.
    /// </summary>
    /// <value>Represents the operation type defined in the OperationTypeEnum, enabling the system to differentiate between deposit, collection, fee, and other transaction flows.</value>
    public AcpOperationTypeEnum OperationType { get; set; }

    /// <summary>
    /// Gets or sets the type of the line.
    /// </summary>
    /// <value>The type of the line.</value>
    public LineTypeEnum LineType { get; set; }

    }
}