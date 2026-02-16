
using System;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the QuestionAnswer model.
    /// </summary>
    public class QuestionAnswer 
    {
        
    /// <summary>
    /// Gets or sets the question.
    /// </summary>
    /// <value>The question.</value>
    public string Question { get; set; }

    /// <summary>
    /// Gets or sets the crypted answer.
    /// </summary>
    /// <value>The crypted answer.</value>
    public string CryptedAnswer { get; set; }

    }
}