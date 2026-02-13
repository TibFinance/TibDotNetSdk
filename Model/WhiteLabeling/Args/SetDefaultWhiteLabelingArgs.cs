
using System;
using System.Collections.Generic;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Model.WhiteLabeling.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SetDefaultWhiteLabelingArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// WhiteLabeling Data.
    /// </summary>
    /// <value></value>
    public List<WhiteLabelingDataModel> WhiteLabelingData { get; set; }

    }
}