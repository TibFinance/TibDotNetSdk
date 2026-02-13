
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Acp;

namespace Tib.Api.Acp
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class LineDefTransactionSegment : BaseTransaction
    {
        
    /// <summary>
    /// Gets the start position.
    /// </summary>
    /// <value>The start position.</value>
    public int StartPosition { get; set; }

    /// <summary>
    /// Specifies the operation category used throughout the API.
    /// </summary>
    /// <value>Represents the operation type defined in the OperationTypeEnum, enabling the system to differentiate between deposit, collection, fee, and other transaction flows.</value>
    public AcpOperationTypeEnum OperationType { get; set; }

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
    /// Gets or sets the short name of the organization.
    /// </summary>
    /// <value>The short name of the organization.</value>
    public string ShortOrganizationName { get; set; }

    /// <summary>
    /// Gets or sets the name of the target.
    /// </summary>
    /// <value>The name of the target.</value>
    public string TargetName { get; set; }

    /// <summary>
    /// Gets or sets the name of the organization.
    /// </summary>
    /// <value>The name of the organization.</value>
    public string OrganizationName { get; set; }

    /// <summary>
    /// Gets or sets the organization number.
    /// </summary>
    /// <value>The organization number.</value>
    public string OrganizationNumber { get; set; }

    /// <summary>
    /// Gets or sets the reference number.
    /// </summary>
    /// <value>The reference number.</value>
    public string RefNumber { get; set; }

    /// <summary>
    /// Gets or sets the return institution.
    /// </summary>
    /// <value>The return institution.</value>
    public string ReturnInstitution { get; set; }

    /// <summary>
    /// Gets or sets the return account.
    /// </summary>
    /// <value>The return account.</value>
    public string ReturnAccount { get; set; }

    /// <summary>
    /// Gets or sets the free organization field.
    /// </summary>
    /// <value>The free organization field.</value>
    public string FreeOrganizationField { get; set; }

    }
}