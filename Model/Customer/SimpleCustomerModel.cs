
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the SimpleCustomerModel model.
    /// </summary>
    public class SimpleCustomerModel 
    {
        
    /// <summary>
    /// This property represents the full name of the customer in the system.
    /// </summary>
    /// <value>The 'CustomerName' is a string attribute that holds the complete name of the customer as registered in the system.</value>
    public string CustomerName { get; set; }

    /// <summary>
    /// Serves as a unique identifier for customers within an external system, enabling efficient data mapping and integration across various platforms.
    /// </summary>
    /// <value>This string parameter represents a distinct identifier assigned to a customer within an external system, thereby facilitating seamless synchronization of data and customer identification across different platforms.</value>
    public string CustomerExternalId { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// Retrieves or assigns a detailed description for a specific customer.
    /// </summary>
    /// <value>The 'CustomerDescription' property signifies an extensive textual representation of a customer, offering a profound insight into the customer's profile.</value>
    public string CustomerDescription { get; set; }

    /// <summary>
    /// Handles the acquisition and assignment of a customer's email address.
    /// </summary>
    /// <value>Represents a valid email address linked to a specific customer, provided as a string.</value>
    public string CustomerEmail { get; set; }

    }
}