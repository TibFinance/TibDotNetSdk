
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class AdminCustomerPaymentModel 
    {
        
    /// <summary>
    /// Serves as a unique identifier for each customer within the system.
    /// </summary>
    /// <value>The 'CustomerId' is a unique, non-duplicable identifier that is assigned to each customer upon their creation. It functions as a primary key for all operations related to a specific customer.</value>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Acts as a unique identifier for a distinct payment method.
    /// </summary>
    /// <value>This unique identifier, or token, is specifically associated with a single payment method.</value>
    public Guid? PaymentMethodId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? AccountInformationId { get; set; }

    /// <summary>
    /// This property represents the full name of the customer in the system.
    /// </summary>
    /// <value>The 'CustomerName' is a string attribute that holds the complete name of the customer as registered in the system.</value>
    public string CustomerName { get; set; }

    /// <summary>
    /// Handles the acquisition and assignment of a customer's email address.
    /// </summary>
    /// <value>Represents a valid email address linked to a specific customer, provided as a string.</value>
    public string CustomerEmail { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AccountInformationView { get; set; }

    /// <summary>
    /// Identifies the type of payment method linked to a specific account.
    /// </summary>
    /// <value>A unique identifier representing the type of the payment method.</value>
    public PaymentMethodTypeEnum PaymentMethodType { get; set; }

    /// <summary>
    /// The 'Owner' property is designed to assign and identify the ownership of a specific resource or object within the system.
    /// </summary>
    /// <value>The 'Owner' property holds a unique string value that signifies the identifier of the owner, ensuring distinct representation within the system.</value>
    public string Owner { get; set; }

    /// <summary>
    /// Retrieves or assigns the identifier used for external customer identification. This property is crucial for linking customer data with external systems.
    /// </summary>
    /// <value>Represents the unique identifier for a customer used in external systems.</value>
    public string ExternalCustomerId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? IsDeletedCustomer { get; set; }

    /// <summary>
    /// Provides a detailed description of the payment method for easy identification.
    /// </summary>
    /// <value>The 'PaymentMethodDescription' property stores a descriptive string that offers a comprehensive understanding of the specific payment method.</value>
    public string PaymentMethodDescription { get; set; }

    /// <summary>
    /// Determines if the customer's payment method is set as the default for automatic transactions.
    /// </summary>
    /// <value>This property returns a boolean value. It yields 'true' if the customer's payment method is configured for automatic transactions, and 'false' otherwise.</value>
    public bool IsCustomerAutomaticPaymentMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsVerifiedPaymentMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsDeletedPaymentMethod { get; set; }

    /// <summary>
    /// Handles the extraction or assignment of a particular entity's expiration date.
    /// </summary>
    /// <value>Denotes the expiration date of a specific entity, represented as a DateTime object.</value>
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? AccountAddressId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Question { get; set; }

    /// <summary>
    /// Specifies the email address associated with the merchant.
    /// </summary>
    /// <value>Represents the merchant's email address, which is used for communication and identification purposes within the TIB Finance API.</value>
    public string Email { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string MobilePhone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public LanguageEnum? AccountLanguage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Memo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsChecked { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime? CreatedDateCustomer { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime? CreatedDatePaymentMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CustomerInfoEmail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the address associated with the entity.
    /// </summary>
    /// <value>The address represented by an AddressModel object.</value>
    public string Address { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the postal zip code for the address entity.
    /// </summary>
    /// <value>The postal zip code string stored in the object.</value>
    public string PostalZipCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string PaymentMethodTypeValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AccountLanguageValue { get; set; }

    }
}