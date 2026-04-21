
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
    /// Specifies the bill identifier to filter transfers associated with that bill
    /// </summary>
    /// <value>String (or numeric) bill ID; must correspond to an existing bill in the system; optional – if omitted, transfers for all bills are returned</value>
    public BillModel Bill { get; set; }

    }
}