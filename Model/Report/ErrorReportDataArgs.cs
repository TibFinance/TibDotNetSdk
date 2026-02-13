
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Report
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ErrorReportDataArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Date format of dates 0 for canadian format YYYYMMDD 1 for american format MMDDYYYY
    /// </summary>
    /// <value></value>
    public int? Dateformat { get; set; }

    /// <summary>
    /// Interval span as number of months
    /// </summary>
    /// <value></value>
    public int? Interval { get; set; }

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
    /// Specifies the starting date for filtering payment due dates.
    /// </summary>
    /// <value>Indicates the initial date from which payments are considered.</value>
    public string FromDate { get; set; }

    }
}