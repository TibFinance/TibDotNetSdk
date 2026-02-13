
using System;

namespace Tib.Api.Acp.CSV
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CsvUntypedRow 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string OrganizationNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string FileNumber { get; set; }

    /// <summary>
    /// Specifies the operation category used throughout the API.
    /// </summary>
    /// <value>Represents the operation type defined in the OperationTypeEnum, enabling the system to differentiate between deposit, collection, fee, and other transaction flows.</value>
    public string OperationType { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public string Amount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string DateFundsAvailable { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TargetName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TargetInstitutionNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TargetFullAccountNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string RefNumber { get; set; }

    /// <summary>
    /// Specifies the email address associated with the merchant.
    /// </summary>
    /// <value>Represents the merchant's email address, which is used for communication and identification purposes within the TIB Finance API.</value>
    public string Email { get; set; }

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
    /// 
    /// </summary>
    /// <value></value>
    public string Province { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Country { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ZipCode { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public string Language { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Frequency { get; set; }

    }
}