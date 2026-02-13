
using System;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BillLineEntity 
    {
        
    /// <summary>
    /// Unique identifier for the line item (optional on creation, will be assigned by system)
    /// </summary>
    /// <value></value>
    public Guid? BillLineId { get; set; }

    /// <summary>
    /// Line number for ordering (1-based)
    /// </summary>
    /// <value></value>
    public int LineNumber { get; set; }

    /// <summary>
    /// Product SKUcode (optional)
    /// </summary>
    /// <value></value>
    public string ProductSku { get; set; }

    /// <summary>
    /// Product name (required)
    /// </summary>
    /// <value></value>
    public string ProductName { get; set; }

    /// <summary>
    /// Product description (optional)
    /// </summary>
    /// <value></value>
    public string ProductDescription { get; set; }

    /// <summary>
    /// Quantity (default: 1)
    /// </summary>
    /// <value></value>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Unit of measure (e.g., "unit", "hour", "kg")
    /// </summary>
    /// <value></value>
    public string UnitOfMeasure { get; set; }

    /// <summary>
    /// Unit price
    /// </summary>
    /// <value></value>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// Discount percentage for this line (0-100)
    /// </summary>
    /// <value></value>
    public decimal? DiscountPercent { get; set; }

    /// <summary>
    /// Discount amount for this line (alternative to percentage)
    /// </summary>
    /// <value></value>
    public decimal? DiscountAmount { get; set; }

    /// <summary>
    /// Tax code (e.g., "TX" for taxable, "NT" for non-taxable)
    /// </summary>
    /// <value></value>
    public string TaxCode { get; set; }

    /// <summary>
    /// Whether this line is taxable
    /// </summary>
    /// <value></value>
    public bool IsTaxable { get; set; }

    /// <summary>
    /// Calculated line subtotal (Quantity * UnitPrice - Discount) Read-only on response, calculated by system
    /// </summary>
    /// <value></value>
    public decimal LineSubtotal { get; set; }

    /// <summary>
    /// Calculated tax amount for this line Read-only on response, calculated by system
    /// </summary>
    /// <value></value>
    public decimal LineTaxAmount { get; set; }

    /// <summary>
    /// Calculated line total (Subtotal + Tax) Read-only on response, calculated by system
    /// </summary>
    /// <value></value>
    public decimal LineTotal { get; set; }

    }
}