
using System;
using System.Collections.Generic;
using Tib.Api.Gateway.Entities;
using Tib.Api.Model.Boarding;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BoardingInfoModel : BoardingInfoEntity
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid BoardingInfoId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminBirthDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminZip { get; set; }

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
    public string AdminPhone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminGovId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerBirthDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerZip { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerStateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerPhone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerCountryCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerGovId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerAddress_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerFirstName_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerLastName_Edited { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyCountryCode { get; set; }

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
    public string CompanyStateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyTaxId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyWebSite { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanySalesVolume { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyProductAndServiceDescription { get; set; }

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
    public string BankCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankStateCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankCountryCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankRoutingNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankPayoutCurrency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankSortCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankBsb { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankSwiftCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyBusinessCategory { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AdminCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ManagerCity { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<BoardingInfoFileEntity> Files { get; set; }

    }
}