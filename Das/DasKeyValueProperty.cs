
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Das;

namespace Tib.Api.Das
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DasKeyValueProperty : DasKeyValuePropertyBase
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public T Value { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public object InnerValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DasKeyValuePropertyTypeEnum DasKeyValuePropertyType { get; set; }

    }
}