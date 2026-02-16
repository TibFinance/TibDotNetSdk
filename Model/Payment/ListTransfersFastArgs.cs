
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the ListTransfersFastArgs model.
    /// </summary>
    public class ListTransfersFastArgs : ClientCallBaseArgs
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
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Identifies the group of related transfer operations.
    /// </summary>
    /// <value>A GUID string that uniquely identifies a transfer group within the system.</value>
    public string TransferGroupId { get; set; }

    /// <summary>
    /// Defines and manages the type of transfer operation within the system.
    /// </summary>
    /// <value>Specifies the category of the transfer, determining its processing logic and applicable rules.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// Indicates whether the request should consider only payments that are already marked as resolved.
    /// </summary>
    /// <value>Returns true when only resolved payments are to be processed; returns false to include all payments regardless of their resolution status.</value>
    public bool MarkResolvedOnly { get; set; }

    /// <summary>
    /// External merchant group identifier used to filter transfer operations.
    /// </summary>
    /// <value>Specifies the GUID of the external merchant group. When provided, the API returns only transfers associated with this group.</value>
    public string ExternalMerchantGroupId { get; set; }

    /// <summary>
    /// Indicates whether the transfer list should be filtered to include only operations that have an error status.
    /// </summary>
    /// <value>True to return only transfer operations with an error status; false to return all transfer operations regardless of status.</value>
    public bool OnlyWithErrors { get; set; }

    }
}