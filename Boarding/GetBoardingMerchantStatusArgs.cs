
using System;
using System.Collections.Generic;
using Tib.Api.Boarding;
using Tib.Api.Financial;

namespace Tib.Api.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetBoardingMerchantStatusArgs 
    {
        
    /// <summary>
    /// Gets or sets the SubmitDocumentEntity.
    /// </summary>
    /// <value>The SubmitDocumentEntity.</value>
    public GetBoardingMerchantStatusEntity GetBoardingMerchantStatusEntity { get; set; }

    /// <summary>
    /// Gets or sets the mailing information.
    /// </summary>
    /// <value>The mailing information.</value>
    public TransactionMailingInfo MailingInfo { get; set; }

    /// <summary>
    /// Gets or sets the provider credentials.
    /// </summary>
    /// <value>The provider credentials.</value>
    public List<ProviderAccount> ProviderCredentials { get; set; }

    }
}