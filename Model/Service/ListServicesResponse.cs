
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
    /// Indicates whether client approbation was bypassed for the listed service.
    /// </summary>
    /// <value>True means the service was provided without the usual client approval step; false means standard client approbation applied. Read‑only, defaults to false, and is only relevant for services that support optional approbation.</value>
    public bool SkipClientApprobation { get; set; }

    }
}