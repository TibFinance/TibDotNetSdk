
using System;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TransferBaseInformationEntity 
    {
        
    /// <summary>
    /// TransferId
    /// </summary>
    /// <value></value>
    public Guid i { get; set; }

    /// <summary>
    /// CreatedDate
    /// </summary>
    /// <value></value>
    public DateTime cdt { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    /// <value></value>
    public string t { get; set; }

    /// <summary>
    /// payment method type.
    /// </summary>
    /// <value></value>
    public int pmt { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    /// <value></value>
    public string d { get; set; }

    /// <summary>
    /// Merchant Name
    /// </summary>
    /// <value></value>
    public string m { get; set; }

    /// <summary>
    /// Transfer Due Date.
    /// </summary>
    /// <value></value>
    public DateTime td { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    /// <value></value>
    public decimal a { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    /// <value></value>
    public int s { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int ts { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string cps { get; set; }

    /// <summary>
    /// Bank error Code
    /// </summary>
    /// <value></value>
    public int c { get; set; }

    /// <summary>
    /// customer Name
    /// </summary>
    /// <value></value>
    public string cn { get; set; }

    /// <summary>
    /// customer email
    /// </summary>
    /// <value></value>
    public string cem { get; set; }

    /// <summary>
    /// customer's id
    /// </summary>
    /// <value></value>
    public Guid cid { get; set; }

    /// <summary>
    /// transaction description
    /// </summary>
    /// <value></value>
    public string trd { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string man { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string map { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime ed { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime ed2 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool he { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool del { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal CollectOperationAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal DepositOperationAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal ConvenientFeesOperationAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal FeesOperationAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int Direction { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool Refunded { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal TransferAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsSupplierTransfer { get; set; }

    /// <summary>
    /// External Reference Number (ern)
    /// </summary>
    /// <value></value>
    public string ern { get; set; }

    }
}