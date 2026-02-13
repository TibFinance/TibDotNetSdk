
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetBoardingStatusResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public string Currency { get; set; }

    /// <summary>
    /// Specifies the default language used by the merchant within the TIB Finance API. This setting is crucial for ensuring that all communications and operations are conducted in the preferred language of the merchant.
    /// </summary>
    /// <value>Defines the language preference for the merchant.</value>
    public int MerchantLanguage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string MerchantEmail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AuthorizationStatus { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// The merchant's phone number used for contact and transaction notifications.
    /// </summary>
    /// <value>A string containing the merchant's telephone number. The value must conform to the allowed character set defined by the regular expression.</value>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Contains a free‑text description of the merchant, which is stored in the TIB Finance system and displayed in merchant records.
    /// </summary>
    /// <value>A UTF‑8 encoded string that describes the merchant. The description is optional but recommended for identification purposes.</value>
    public string MerchantDescription { get; set; }

    /// <summary>
    /// Represents the name associated with the merchant's account.
    /// </summary>
    /// <value>Specifies the name of the merchant's account used for identification and transaction purposes.</value>
    public string AccountName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AccountInformation { get; set; }

    /// <summary>
    /// Represents the status of the merchant boarding process within the system. This status is crucial for tracking the progress and completion of merchant onboarding.
    /// </summary>
    /// <value>The BoardingStatus does not require additional input parameters and is utilized within the standard API call structure to determine the current state of merchant onboarding.</value>
    public string BoardingStatus { get; set; }

    }
}