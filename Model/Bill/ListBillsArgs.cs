
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ListBillsArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
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
    /// Specifies the starting date and time for filtering data.
    /// </summary>
    /// <value>Defines the initial point in time from which data is filtered.</value>
    public DateTime? FromDateTime { get; set; }

    /// <summary>
    /// Converts a specified date filter to a DateTime object.
    /// </summary>
    /// <value>This function processes a given date filter and returns its equivalent DateTime representation.</value>
    public DateTime? ToDateTime { get; set; }

    }
}