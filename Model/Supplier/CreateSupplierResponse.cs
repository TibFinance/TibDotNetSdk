
using System;
using System.Collections.Generic;
using Tib.Api.Model.Merchant;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the CreateSupplierResponse model.
    /// </summary>
    public class CreateSupplierResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Unique identifier of the created or existing supplier's merchant account.
    /// </summary>
    /// <value></value>
    public Guid SupplierId { get; set; }

    /// <summary>
    /// Display name of the supplier.
    /// </summary>
    /// <value></value>
    public string SupplierName { get; set; }

    /// <summary>
    /// List of existing merchants that matched the supplier email, if reusing an existing supplier.
    /// </summary>
    /// <value></value>
    public IEnumerable<MerchantViewModel> MatchingExistingMerchants { get; set; }

    }
}