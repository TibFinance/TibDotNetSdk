
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the SearchCustomersArgs model.
    /// </summary>
    public class SearchCustomersArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string SearchText { get; set; }

    }
}