
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Represents the LoadBoardingInfoResponse model.
    /// </summary>
    public class LoadBoardingInfoResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public BoardingStepEnum Step { get; set; }

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
    public CompanyTypeEnum? CompanyType { get; set; }

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
    public string DrivingLicenceNumber { get; set; }

    }
}