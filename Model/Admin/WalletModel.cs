
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Model.Admin;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the WalletModel model.
    /// </summary>
    public class WalletModel 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid WalletId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ReferenceTypeEnum ReferenceType { get; set; }

    /// <summary>
    /// Gets or sets the reference identifier used to uniquely identify a transaction, operation, or entity within the TIB Finance system.
    /// </summary>
    /// <value>A string containing the unique reference identifier. The identifier follows the GUID format supplied by TIB Finance.</value>
    public Guid ReferenceId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal Balance { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal WithdrawableAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string WalletRefillSchedule { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsProcessing { get; set; }

    /// <summary>
    /// Gets or sets the wallet type identifier used by the TIB Finance API to select the appropriate wallet configuration.
    /// </summary>
    /// <value>Integer representing the wallet type. Valid values correspond to predefined wallet categories defined by TIB Finance.</value>
    public WalletTypeEnum WalletType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<WalletHolderModel> WalletHolders { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ReferenceTypeName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string WalletTypeName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string WalletCombinationTypeName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string WalletDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool WalletFeatureIsActive { get; set; }

    }
}