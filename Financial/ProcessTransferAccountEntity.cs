
using System;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ProcessTransferAccountEntity : ProcessTransferEntity
    {
        
    /// <summary>
    /// Gets or sets the account information.
    /// </summary>
    /// <value>The account information.</value>
    public AccountModel AccountInformation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderGivenIdentification { get; set; }

    }
}