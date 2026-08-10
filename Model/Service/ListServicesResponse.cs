
using System;
using System.Collections.Generic;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the ListServicesResponse model.
    /// </summary>
    public class ListServicesResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// A collection of ServiceModel objects representing the services available to the caller.
    /// </summary>
    /// <value>IEnumerable&lt;ServiceModel&gt;; may be empty; each item includes service ID, name, description, status, and related metadata. No duplicate entries; ordered as defined by the platform.</value>
    public IEnumerable<ServiceModel> Services { get; set; }

    /// <summary>
    /// Whether merchants created under this client are authorized immediately. When true, a merchant's bank account supplied at creation is applied right away; when false, it is submitted for review and takes effect only once approved. A brand-new, not-yet-operational service still requires approval regardless of this flag.
    /// </summary>
    public bool SkipClientApprobation { get; set; }

    /// <summary>
    /// Whether this client is exempt from service boarding. When true, the client's services become usable without a boarding submission, so an absent boarding record means 'not required' rather than 'not yet completed' — callers must not treat a missing boarding status as pending for such a client.
    /// </summary>
    public bool IsClientBoardingExempt { get; set; }

    }
}