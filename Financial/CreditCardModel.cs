
using System;
using Tib.Api.Common;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreditCardModel 
    {
        
    /// <summary>
    /// Provides a description to identify the credit card within the TIB Finance API. This description helps in distinguishing between multiple credit card payment methods associated with a customer.
    /// </summary>
    /// <value>Stores the descriptive text for the credit card, aiding in its recognition and management.</value>
    public string CreditCardDescription { get; set; }

    /// <summary>
    /// Represents the primary account number (PAN) of the credit card.
    /// </summary>
    /// <value>Stores the credit card number securely.</value>
    public ulong Pan { get; set; }

    /// <summary>
    /// Represents the card verification code (CVD) used for validating credit card transactions.
    /// </summary>
    /// <value>Stores the CVD as a string.</value>
    public string CVD { get; set; }

    /// <summary>
    /// Specifies the expiration month of the credit card.
    /// </summary>
    /// <value>Represents the month when the credit card expires.</value>
    public int ExpirationMonth { get; set; }

    /// <summary>
    /// Specifies the expiration year of the credit card. This is a crucial component for validating the card's validity period within the TIB Finance API.
    /// </summary>
    /// <value>Represents the year when the credit card expires.</value>
    public int ExpirationYear { get; set; }

    /// <summary>
    /// Specifies the name of the card owner.
    /// </summary>
    /// <value>Represents the name of the individual who owns the credit card. This information is crucial for validating and processing transactions.</value>
    public string CardOwner { get; set; }

    /// <summary>
    /// Retrieves or assigns the registered address associated with a credit card. This property is crucial for verifying the billing address linked to the credit card, ensuring secure and accurate transaction processing.
    /// </summary>
    /// <value>Represents the address registered with the credit card, used for billing verification purposes.</value>
    public AddressModel CreditCardRegisteredAddress { get; set; }

    /// <summary>
    /// Handles the extraction or assignment of a particular entity's expiration date.
    /// </summary>
    /// <value>Denotes the expiration date of a specific entity, represented as a DateTime object.</value>
    public DateTime ExpirationDate { get; set; }

    /// <summary>
    /// A well formated string of the credit card number
    /// </summary>
    /// <value>The formated credit card string.</value>
    public string FormatedCreditCardString { get; set; }

    /// <summary>
    /// An obfuscated string of the card number
    /// </summary>
    /// <value>The preview string.</value>
    public string PreviewString { get; set; }

    }
}