
using System;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the BoardingFileModel model.
    /// </summary>
    public class BoardingFileModel 
    {
        
    /// <summary>
    /// The type of document associated with the merchant record.
    /// </summary>
    /// <value>String; may contain values such as "Passport", "BusinessLicense", etc. Max length 50 characters. May be empty if no document is linked.</value>
    public string DocType { get; set; }

    /// <summary>
    /// Indicates the document receipt status for the merchant.
    /// </summary>
    /// <value>String flag (e.g., "Received", "Pending", "Partial") showing whether all required documents have been submitted.</value>
    public string DocsReceived { get; set; }

    /// <summary>
    /// The maximum number of merchant records returned in the response
    /// </summary>
    /// <value>String representing an integer limit applied to the result set; empty or omitted means no limit. Must contain only digits and fit within the platform's maximum allowed value.</value>
    public string DocLimit { get; set; }

    /// <summary>
    /// A free‑form textual description of the merchant returned by the request
    /// </summary>
    /// <value>String up to 500 characters; may include plain text or simple markup; optional and may be null if no description is set</value>
    public string DocGenericDescription { get; set; }

    /// <summary>
    /// The current lifecycle status of the merchant record returned by GetMerchantsByExternalId.
    /// </summary>
    /// <value>String indicating one of the predefined statuses (e.g., "Active", "Inactive", "Pending", "Suspended"). Read‑only; may be empty if the status is not set.</value>
    public string DocStatus { get; set; }

    }
}