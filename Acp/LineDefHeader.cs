
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Acp;

namespace Tib.Api.Acp
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class LineDefHeader : BaseLineHeader
    {
        
    /// <summary>
    /// Gets or sets the type of the line.
    /// </summary>
    /// <value>The type of the line.</value>
    public LineTypeEnum LineType { get; set; }

    /// <summary>
    /// Ce numÃ©ro sert Ã vÃ©rifier quâ€™il ne manque pas dâ€™enregistrements dans le fichier. Le type dâ€™enregistrement logique A doit avoir une valeur de Â« 000000001 Â», sinon le fichier est rejetÃ©. Tous les enregistrements subsÃ©quents doivent Ãªtre numÃ©riques et avoir une valeur supÃ©rieure dâ€™une unitÃ© au nombre dâ€™enregistrements logiques indiquÃ© sur lâ€™enregistrement logique prÃ©cÃ©dent, sinon le fichier est rejetÃ©.
    /// </summary>
    /// <value>The row number.</value>
    public int RowNumber { get; set; }

    /// <summary>
    /// Gets or sets the organization number.
    /// </summary>
    /// <value>The organization number.</value>
    public string OrganizationNumber { get; set; }

    /// <summary>
    /// Cet Ã©lÃ©ment de donnÃ©e sert Ã vÃ©rifier que tous les fichiers crÃ©Ã©s par le centre de traitement informatique de lâ€™organisme sont reÃ§us par la banque(et quâ€™il nâ€™en manque aucun ou quâ€™aucun nâ€™est traitÃ© deux fois). Cet Ã©lÃ©ment de donnÃ©e doit Ãªtre majorÃ© dâ€™une unitÃ© chaque fois quâ€™un fichier est crÃ©Ã©.
    /// </summary>
    /// <value>The file number.</value>
    public int FileNumber { get; set; }

    }
}