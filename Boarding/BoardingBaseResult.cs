
using System;
using System.Collections.Generic;
using Tib.Api.Boarding;

namespace Tib.Api.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BoardingBaseResult 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public HttpStatusCode HttpStatusCode { get; set; }

    /// <summary>
    /// Represents a textual message within the system, used for communication or logging purposes.
    /// </summary>
    /// <value>The 'Message' type is utilized to convey information, warnings, or errors throughout the application. It serves as a standard format for displaying or recording messages.</value>
    public string Message { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<BoardingBaseError> ErrorList { get; set; }

    }
}