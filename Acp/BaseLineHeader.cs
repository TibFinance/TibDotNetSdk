
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Acp;

namespace Tib.Api.Acp
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BaseLineHeader : LineBase
    {
        
    /// <summary>
    /// Gets or sets the type of the line.
    /// </summary>
    /// <value>The type of the line.</value>
    public LineTypeEnum LineType { get; set; }

    /// <summary>
    /// Gets or sets the file number.
    /// </summary>
    /// <value>The file number.</value>
    public int FileNumber { get; set; }

    /// <summary>
    /// Gets or sets the organization number.
    /// </summary>
    /// <value>The organization number.</value>
    public string OrganizationNumber { get; set; }

    }
}