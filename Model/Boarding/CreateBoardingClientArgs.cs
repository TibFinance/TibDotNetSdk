
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateBoardingClientArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the name of the sub-client.
    /// </summary>
    /// <value>Specifies the name associated with the sub-client.</value>
    public String Name { get; set; }

    /// <summary>
    /// Specifies the email address associated with the merchant.
    /// </summary>
    /// <value>Represents the merchant's email address, which is used for communication and identification purposes within the TIB Finance API.</value>
    public String Email { get; set; }

    /// <summary>
    /// The merchant's phone number used for contact and transaction notifications.
    /// </summary>
    /// <value>A string containing the merchant's telephone number. The value must conform to the allowed character set defined by the regular expression.</value>
    public String PhoneNumber { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public int Language { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public int Currency { get; set; }

    }
}