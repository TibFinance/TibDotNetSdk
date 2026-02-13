
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetClientsByBoardingStepArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the boarding step.
    /// </summary>
    /// <value>The boarding step.</value>
    public int BoardingStep { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public object Override { get; set; }

    }
}