
using System;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SearchCustomerResultModel 
    {
        
    /// <summary>
    /// This property represents the full name of the customer in the system.
    /// </summary>
    /// <value>The 'CustomerName' is a string attribute that holds the complete name of the customer as registered in the system.</value>
    public string CustomerName { get; set; }

    /// <summary>
    /// Provides a secure representation of the account card number associated with a specific payment method.
    /// </summary>
    /// <value>The 'AccountPreview' property securely displays the account card number by masking certain digits, thereby safeguarding sensitive information.</value>
    public string AccountPreview { get; set; }

    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int NumberOfTransaction { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal MinTransferAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal MaxTransferAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime? MinTransferDueDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime? MaxTransferDueDate { get; set; }

    }
}