
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
    /// Provides a collection of bills filtered according to specified criteria. This collection is essential for managing and reviewing billing information within the system.
    /// </summary>
    /// <value>Contains the list of bills that match the applied filter criteria.</value>
    public IEnumerable<BillModel> Bills { get; set; }

    }
}