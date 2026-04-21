
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the ProcessWebHookResponse model.
    /// </summary>
    public class ProcessWebHookResponse 
    {
        
    /// <summary>
    /// Identifier of the boarding information linked to the merchant
    /// </summary>
    /// <value>A valid GUID referencing the merchant's boarding information record; included only when such data exists</value>
    public Guid BoardingInformationId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TransactionType { get; set; }

    /// <summary>
    /// Indicates the current onboarding state of the merchant identified by the external ID
    /// </summary>
    /// <value>String value such as "Pending", "InReview", "Completed" or "Failed"; reflects the merchant's progress through TIB Finance's boarding workflow and is case‑sensitive.</value>
    public BoardingStatusEnum BoardingStatus { get; set; }

    }
}