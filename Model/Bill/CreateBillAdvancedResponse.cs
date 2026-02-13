
using System;
using System.Collections.Generic;
using Tib.Api.Model.Bill;
using Tib.Api.Common;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateBillAdvancedResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a bill.
    /// </summary>
    /// <value>Represents the unique identifier associated with a bill.</value>
    public Guid BillId { get; set; }

    /// <summary>
    /// The assigned invoice number (auto-generated or provided)
    /// </summary>
    /// <value></value>
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// Full invoice number with prefix (e.g., "INV-00001")
    /// </summary>
    /// <value></value>
    public string FullInvoiceNumber { get; set; }

    /// <summary>
    /// Calculated subtotal (sum of line items before taxes and discounts)
    /// </summary>
    /// <value></value>
    public decimal Subtotal { get; set; }

    /// <summary>
    /// Total discount amount applied
    /// </summary>
    /// <value></value>
    public decimal DiscountTotal { get; set; }

    /// <summary>
    /// First tax amount calculated
    /// </summary>
    /// <value></value>
    public decimal TaxAmount1 { get; set; }

    /// <summary>
    /// Second tax amount calculated
    /// </summary>
    /// <value></value>
    public decimal TaxAmount2 { get; set; }

    /// <summary>
    /// Total amount of the invoice (subtotal - discount + taxes)
    /// </summary>
    /// <value></value>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// Created line items with their calculated values
    /// </summary>
    /// <value></value>
    public List<BillLineEntity> Lines { get; set; }

    /// <summary>
    /// URL to viewpay the invoice (if applicable)
    /// </summary>
    /// <value></value>
    public string PaymentUrl { get; set; }

    /// <summary>
    /// URL to download the invoice as PDF (if applicable)
    /// </summary>
    /// <value></value>
    public string PdfUrl { get; set; }

    }
}