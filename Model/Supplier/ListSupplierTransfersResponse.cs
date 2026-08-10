
using System;
using System.Collections.Generic;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the ListSupplierTransfersResponse model.
    /// </summary>
    public class ListSupplierTransfersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of supplier transfers where the caller is the fee-payer. Each entry includes a SupplierAlias field with the payer's custom name for the supplier.
    /// </summary>
    public List<TransferBaseInformationEntity> Transfers { get; set; }

    }
}