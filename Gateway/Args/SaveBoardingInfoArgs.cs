
using System;
using System.Collections.Generic;
using Tib.Api.Gateway.Entities;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the SaveBoardingInfoArgs model.
    /// </summary>
    public class SaveBoardingInfoArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BusinessRegistrationNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BusinessRegistrationNumber_Edited { get; set; }

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
    public string ManagerFirstName2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerLastName2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerAddress2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerLinkedIn { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool ManagerIsAlsoAdmin { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? CompanyType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyName2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyAddress2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminFirstName2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminLastName2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminAddress2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? CompanyType2 { get; set; }

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
    public string IdImageAsBase64 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminIdImageFront { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminIdImageBack { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerIdImageFront { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerIdImageBack { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<BoardingInfoFileEntity> IdFiles { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyTaxId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyCountryCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyStateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyZip { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyPhone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyProductAndServiceDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyWebSite { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyBusinessCategory { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanySalesVolume { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminCountryCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminStateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminZip { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminPhone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminBirthDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminGovId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerCountryCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerStateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerZip { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerPhone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerBirthDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerGovId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankPayoutCurrency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankCountryCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankStateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankName { get; set; }

    /// <summary>
    /// Identifies the bank associated with the account using its numeric identifier.
    /// </summary>
    /// <value>Holds the bank number as a string. The value must not exceed the allowed length.</value>
    public string BankNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankTransitNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankAccountNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankRoutingNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankBic { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankIban { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankSortCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankSwiftCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankBsb { get; set; }

    }
}