
using System;
using System.Collections.Generic;
using Tib.Api.Model.Bill;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BillEntityAdvanced : BillEntity
    {
        
    /// <summary>
    /// Invoice number prefix (e.g., "INV-", "FAC-"). If not provided, merchant's default will be used.
    /// </summary>
    /// <value></value>
    public string InvoiceNumberPrefix { get; set; }

    /// <summary>
    /// Custom invoice number. If not provided, system will auto-generate based on merchant's sequence.
    /// </summary>
    /// <value></value>
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// Purchase order number from customer (optional reference)
    /// </summary>
    /// <value></value>
    public string PurchaseOrderNumber { get; set; }

    /// <summary>
    /// Specifies the due date for the payment. If the value is null, the system treats the due date as the current date and time.
    /// </summary>
    /// <value>The date and time by which the payment must be completed.</value>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Invoice status. Defaults to Draft (0). 0=Draft, 1=Sent, 2=Viewed, 3=Paid, 4=Overdue, 5=Cancelled, 6=PartiallyPaid
    /// </summary>
    /// <value></value>
    public int InvoiceStatus { get; set; }

    /// <summary>
    /// Customer billing name
    /// </summary>
    /// <value></value>
    public string BillingName { get; set; }

    /// <summary>
    /// Customer billing email
    /// </summary>
    /// <value></value>
    public string BillingEmail { get; set; }

    /// <summary>
    /// Customer billing phone
    /// </summary>
    /// <value></value>
    public string BillingPhone { get; set; }

    /// <summary>
    /// Customer billing address line 1
    /// </summary>
    /// <value></value>
    public string BillingAddress1 { get; set; }

    /// <summary>
    /// Customer billing address line 2
    /// </summary>
    /// <value></value>
    public string BillingAddress2 { get; set; }

    /// <summary>
    /// Customer billing city
    /// </summary>
    /// <value></value>
    public string BillingCity { get; set; }

    /// <summary>
    /// Customer billing provincestate
    /// </summary>
    /// <value></value>
    public string BillingProvince { get; set; }

    /// <summary>
    /// Customer billing postalzip code
    /// </summary>
    /// <value></value>
    public string BillingPostalCode { get; set; }

    /// <summary>
    /// Customer billing country (ISO 2-letter code, e.g., "CA", "US")
    /// </summary>
    /// <value></value>
    public string BillingCountry { get; set; }

    /// <summary>
    /// First tax name (e.g., "TPS", "GST", "HST")
    /// </summary>
    /// <value></value>
    public string TaxName1 { get; set; }

    /// <summary>
    /// First tax rate as percentage (e.g., 5.00 for 5%)
    /// </summary>
    /// <value></value>
    public decimal? TaxRate1 { get; set; }

    /// <summary>
    /// First tax registration number (e.g., GST number)
    /// </summary>
    /// <value></value>
    public string TaxNumber1 { get; set; }

    /// <summary>
    /// Second tax name (e.g., "TVQ", "PST", "QST")
    /// </summary>
    /// <value></value>
    public string TaxName2 { get; set; }

    /// <summary>
    /// Second tax rate as percentage (e.g., 9.975 for QST)
    /// </summary>
    /// <value></value>
    public decimal? TaxRate2 { get; set; }

    /// <summary>
    /// Second tax registration number (e.g., QST number)
    /// </summary>
    /// <value></value>
    public string TaxNumber2 { get; set; }

    /// <summary>
    /// Overall discount percentage applied to subtotal (0-100)
    /// </summary>
    /// <value></value>
    public decimal? DiscountPercent { get; set; }

    /// <summary>
    /// Overall discount amount applied to subtotal (alternative to percentage)
    /// </summary>
    /// <value></value>
    public decimal? DiscountAmount { get; set; }

    /// <summary>
    /// Notes visible to the customer on the invoice
    /// </summary>
    /// <value></value>
    public string Notes { get; set; }

    /// <summary>
    /// Internal notes (not visible to customer)
    /// </summary>
    /// <value></value>
    public string InternalNotes { get; set; }

    /// <summary>
    /// Terms and conditions text for the invoice
    /// </summary>
    /// <value></value>
    public string TermsAndConditions { get; set; }

    /// <summary>
    /// Footer text for the invoice
    /// </summary>
    /// <value></value>
    public string FooterText { get; set; }

    /// <summary>
    /// External accounting system ID (for sync with QuickBooks, Sage, Xero, etc.)
    /// </summary>
    /// <value></value>
    public string ExternalAccountingId { get; set; }

    /// <summary>
    /// Name of the external accounting system (e.g., "QuickBooks", "Sage", "Xero")
    /// </summary>
    /// <value></value>
    public string ExternalAccountingSystem { get; set; }

    /// <summary>
    /// Line items for the invoice. If not provided, a single line will be created from BillAmount.
    /// </summary>
    /// <value></value>
    public List<BillLineEntity> Lines { get; set; }

    }
}