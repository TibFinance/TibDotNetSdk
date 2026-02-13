
using System;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class AdminServiceMerchantModel 
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? MerchantAccountId { get; set; }

    /// <summary>
    /// Retrieves or assigns the service's name.
    /// </summary>
    /// <value>This property holds the name of the service, which is crucial for identifying and managing the service within the TIB Finance system.</value>
    public string ServiceName { get; set; }

    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string MerchantEmail { get; set; }

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
    public string AccountInformationView { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? IsActive { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? IsDeletedService { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? IsDeletedMerchant { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? IsAuthorizedMerchant { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? IsClientMerchant { get; set; }

    /// <summary>
    /// Retrieves or assigns the unique identifier for WhiteLabeling.
    /// </summary>
    /// <value>This property represents the unique identifier for a WhiteLabeling entity within the TIB Finance system. It is crucial for distinguishing between different WhiteLabeling configurations.</value>
    public Guid? WhiteLabelingId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string DefaultStatementDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime CreatedDateService { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime CreatedDateMerchant { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? IsDeletedMerchantAccount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? IsActiveService { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsChecked { get; set; }

    }
}