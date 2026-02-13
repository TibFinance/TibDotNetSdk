
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ValidationsLimitsRules 
    {
        
    /// <summary>
    /// Gets or sets the limit.
    /// </summary>
    /// <value>The limit.</value>
    public decimal Limit { get; set; }

    /// <summary>
    /// Gets or sets the limit daily.
    /// </summary>
    /// <value>The limit daily.</value>
    public decimal LimitDaily { get; set; }

    /// <summary>
    /// Gets or sets the limit per bank account daily.
    /// </summary>
    /// <value>The limit per bank account daily.</value>
    public decimal LimitPerBankAccountDaily { get; set; }

    /// <summary>
    /// Gets or sets the limit per bank account per delays.
    /// </summary>
    /// <value>The limit per bank account per delays.</value>
    public decimal LimitPerBankAccountPerDelays { get; set; }

    /// <summary>
    /// Gets or sets the delays.
    /// </summary>
    /// <value>The delays.</value>
    public int Delays { get; set; }

    /// <summary>
    /// Gets or sets the client warning limit.
    /// </summary>
    /// <value>The client warning limit.</value>
    public decimal ClientWarningLimit { get; set; }

    /// <summary>
    /// Gets or sets the tib warning limit.
    /// </summary>
    /// <value>The tib warning limit.</value>
    public decimal TIBWarningLimit { get; set; }

    /// <summary>
    /// Gets or sets the number per bank account daily.
    /// </summary>
    /// <value>The number per bank account daily.</value>
    public int NumberPerBankAccountDaily { get; set; }

    /// <summary>
    /// Gets or sets the number per bank per delays.
    /// </summary>
    /// <value>The number per bank per delays.</value>
    public int NumberPerBankPerDelays { get; set; }

    /// <summary>
    /// Gets or sets the tib warning limit per bank account daily.
    /// </summary>
    /// <value>The tib warning limit per bank account daily.</value>
    public decimal TIBWarningLimitPerBankAccountDaily { get; set; }

    /// <summary>
    /// Gets or sets the tib warning limit per bank account per delays.
    /// </summary>
    /// <value>The tib warning limit per bank account per delays.</value>
    public decimal TIBWarningLimitPerBankAccountPerDelays { get; set; }

    /// <summary>
    /// Gets or sets the tib warning number per bank account daily.
    /// </summary>
    /// <value>The tib warning number per bank account daily.</value>
    public int TIBWarningNumberPerBankAccountDaily { get; set; }

    /// <summary>
    /// Gets or sets the tib warning number per bank per delays.
    /// </summary>
    /// <value>The tib warning number per bank per delays.</value>
    public int TIBWarningNumberPerBankPerDelays { get; set; }

    /// <summary>
    /// Gets or sets the tib warning limit daily.
    /// </summary>
    /// <value>The tib warning limit daily.</value>
    public decimal TIBWarningLimitDaily { get; set; }

    /// <summary>
    /// Specifies the operation category used throughout the API.
    /// </summary>
    /// <value>Represents the operation type defined in the OperationTypeEnum, enabling the system to differentiate between deposit, collection, fee, and other transaction flows.</value>
    public AcpTransactionTypeEnum OperationType { get; set; }

    /// <summary>
    /// Gets or sets the client Daily limit
    /// </summary>
    /// <value>The client daily limit.</value>
    public decimal ClientLimitDaily { get; set; }

    /// <summary>
    /// Gets or sets the tib warning client Daily limit
    /// </summary>
    /// <value>The tib warning client daily limit.</value>
    public decimal TIBWarningClientLimitDaily { get; set; }

    }
}