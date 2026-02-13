
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class FindIdResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? RelatedClientId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ClientName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TableName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string RelatedDescription { get; set; }

    }
}