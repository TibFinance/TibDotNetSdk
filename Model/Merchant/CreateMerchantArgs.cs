
using System;
using Tib.Api.Model.Merchant;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the CreateMerchantArgs model.
    /// </summary>
    public class CreateMerchantArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// This property holds the basic information necessary for creating or updating a merchant's account within the TIB Finance API system.
    /// </summary>
    /// <value>Contains essential details about the merchant.</value>
    public MerchantModel MerchantInfo { get; set; }

    }
}