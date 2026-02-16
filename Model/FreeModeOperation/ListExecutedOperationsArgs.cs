
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeModeOperation
{
    /// <summary>
    /// Represents the ListExecutedOperationsArgs model.
    /// </summary>
    public class ListExecutedOperationsArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Specifies the starting date for filtering payment due dates.
    /// </summary>
    /// <value>Indicates the initial date from which payments are considered.</value>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// Specifies the payment due date.
    /// </summary>
    /// <value>Indicates the end date for payment processing.</value>
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// Defines and manages the type of transfer operation within the system.
    /// </summary>
    /// <value>Specifies the category of the transfer, determining its processing logic and applicable rules.</value>
    public TransferTypeFlag TransferType { get; set; }

    /// <summary>
    /// Identifies the group of related transfer operations.
    /// </summary>
    /// <value>A GUID string that uniquely identifies a transfer group within the system.</value>
    public string TransferGroupId { get; set; }

    /// <summary>
    /// Indicates whether the transfer list should be filtered to include only operations that have an error status.
    /// </summary>
    /// <value>True to return only transfer operations with an error status; false to return all transfer operations regardless of status.</value>
    public bool OnlyWithErrors { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Enumerates the supported date classifications used throughout the API.
    /// </summary>
    /// <value>Defines the set of permissible date type values that can be assigned to date fields in requests and responses.</value>
    public DateTypeEnum? DateType { get; set; }

    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid? ServiceId { get; set; }

    }
}