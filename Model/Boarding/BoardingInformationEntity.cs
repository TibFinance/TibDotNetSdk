
using System;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the BoardingInformationEntity model.
    /// </summary>
    public class BoardingInformationEntity 
    {
        
    /// <summary>
    /// Unique identifier of the client initiating the session
    /// </summary>
    /// <value>Required Guid; must be a valid, registered client ID in the TIB Finance system</value>
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
    /// The bank account number used for the direct account payment.
    /// </summary>
    /// <value>String of digits only (no spaces or symbols), typically 8–34 characters, matching the format required by the selected bank; required input.</value>
    public string AccountNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AccountOwner { get; set; }

    /// <summary>
    /// The bank's identification number used for the direct account payment method.
    /// </summary>
    /// <value>String of up to 4 numeric characters, required, no spaces or special symbols.</value>
    public string BankNumber { get; set; }

    }
}