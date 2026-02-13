
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Das
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DasKeyValuePropertyBase 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DasFieldTypeEnum FieldId { get; set; }

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