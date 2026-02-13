
using System;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BoardingInfoEntity 
    {
        
    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyAddress { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyPhone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyEmail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminFirstName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminLastName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminAddress { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsManagerAlsoAdmin { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerFirstName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerLastName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerAddress { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerLinkedIn { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? CompanyType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyName_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyAddress_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? CompanyType_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminFirstName_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminLastName_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminAddress_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? DidOwnersAlreadyBeenSubjectOfResiliationOfPaymentService { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? DidOwnersAlreadyAskedForBankrupcy { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? HaveYouBeenSubjectOfVisaRiskProgram { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string SpecimenFile { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string IdFile { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? BoardingStep { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TransitNumber { get; set; }

    /// <summary>
    /// Specifies the bank account number associated with the payment method.
    /// </summary>
    /// <value>Gets or sets the account number. The value must be a non‑empty string with a maximum length of 20 characters.</value>
    public string AccountNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AccountOwner { get; set; }

    /// <summary>
    /// Identifies the bank associated with the account using its numeric identifier.
    /// </summary>
    /// <value>Holds the bank number as a string. The value must not exceed the allowed length.</value>
    public string BankNumber { get; set; }

    }
}