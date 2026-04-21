
using System;
using System.Collections.Generic;
using Tib.Api.Model.Bill;
using Tib.Api.Common;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Represents the ListBillsResponse model.
    /// </summary>
    public class ListBillsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// A collection of BillModel objects representing the bills returned by the ListBills call.
    /// </summary>
    /// <value>IEnumerable&lt;BillModel&gt;; never null (empty collection if no bills); each BillModel includes fields such as Id, Amount, DueDate, Status, etc.</value>
    public IEnumerable<BillModel> Bills { get; set; }

    }
}