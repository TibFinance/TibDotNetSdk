
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the GetAccountInformationResponse model.
    /// </summary>
    public class GetAccountInformationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the provider account operation list.
    /// </summary>
    /// <value>The provider account operation list.</value>
    public List<ProviderAccountOperations> ProviderAccountOperationList { get; set; }

    }
}