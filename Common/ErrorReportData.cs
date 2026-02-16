
using System;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the ErrorReportData model.
    /// </summary>
    public class ErrorReportData 
    {
        
    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public String Description { get; set; }

    /// <summary>
    /// Represents the name associated with the merchant's account.
    /// </summary>
    /// <value>Specifies the name of the merchant's account used for identification and transaction purposes.</value>
    public String AccountName { get; set; }

    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public String MerchantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public String ErrorDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime ErrorDate2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime TransactionDate2 { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the execution date and time of the transaction.
    /// </summary>
    /// <value>A DateTime value indicating when the transaction was executed, stored in UTC.</value>
    public Nullable<DateTime> ExecutedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public String TransactionDate { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public String Context { get; set; }

    }
}