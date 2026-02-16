
using System;
using System.Collections.Generic;
using Tib.Api.Model.Admin;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the SearchAdminCustomerPaymentResponse model.
    /// </summary>
    public class SearchAdminCustomerPaymentResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of all Transfers found
    /// </summary>
    /// <value></value>
    public List<AdminCustomerPaymentModel> SearchResult { get; set; }

    }
}