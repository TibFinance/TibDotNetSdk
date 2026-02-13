
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TransferCreationModel 
    {
        
    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// Represents the unique identifier for a group within the TIB Finance API.
    /// </summary>
    /// <value>The GroupId is used to uniquely identify and manage groups, ensuring precise operations within the API.</value>
    public string GroupId { get; set; }

    /// <summary>
    /// Gets or sets the number of transfers.
    /// </summary>
    /// <value>The number of transfers.</value>
    public int NumberOfTransfers { get; set; }

    /// <summary>
    /// Defines and manages the type of transfer operation within the system.
    /// </summary>
    /// <value>Specifies the category of the transfer, determining its processing logic and applicable rules.</value>
    public TransferTypeEnum TransferType { get; set; }

    }
}