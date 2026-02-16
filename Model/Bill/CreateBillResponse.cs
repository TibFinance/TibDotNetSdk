
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Represents the CreateBillResponse model.
    /// </summary>
    public class CreateBillResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a bill.
    /// </summary>
    /// <value>Represents the unique identifier associated with a bill.</value>
    public Guid BillId { get; set; }

    }
}