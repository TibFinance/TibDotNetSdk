
using System;
using Tib.Api.Model.Bill;
using Tib.Api.Common;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Represents the GetBillResponse model.
    /// </summary>
    public class GetBillResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Bill model representing a financial invoice in the TIB Finance system.
    /// </summary>
    /// <value>Contains the complete set of properties that describe a bill, such as BillId (Guid), Amount, Currency, Status, IssueDate, DueDate, and the associated CustomerId.</value>
    public BillModel Bill { get; set; }

    }
}