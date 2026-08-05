
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the CreateSubClientArgs model.
    /// </summary>
    public class CreateSubClientArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Display name for the new sub-client.
    /// </summary>
    /// <value></value>
    public string Name { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// Default currency for the sub-client (CAD or USD). Omitting the field defaults to CAD; an explicit NotSet/other value is rejected.
    /// </summary>
    /// <value></value>
    public CurrencyEnum Currency { get; set; }

    }
}