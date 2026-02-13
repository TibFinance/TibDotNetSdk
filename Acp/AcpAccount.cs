
using System;

namespace Tib.Api.Acp
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class AcpAccount 
    {
        
    /// <summary>
    /// Gets or sets the organization number.
    /// </summary>
    /// <value>The organization number.</value>
    public string OrganizationNumber { get; set; }

    /// <summary>
    /// Gets or sets the name of the organization.
    /// </summary>
    /// <value>The name of the organization.</value>
    public string OrganizationName { get; set; }

    /// <summary>
    /// Gets or sets the organization account.
    /// </summary>
    /// <value>The organization account.</value>
    public string OrganizationAccount { get; set; }

    /// <summary>
    /// Gets or sets the organization bank.
    /// </summary>
    /// <value>The organization bank.</value>
    public int OrganizationBank { get; set; }

    /// <summary>
    /// Gets or sets the short name of the organization.
    /// </summary>
    /// <value>The short name of the organization.</value>
    public string OrganizationShortName { get; set; }

    /// <summary>
    /// Gets or sets the routing information.
    /// </summary>
    /// <value>The routing information.</value>
    public string RoutingInformation { get; set; }

    }
}