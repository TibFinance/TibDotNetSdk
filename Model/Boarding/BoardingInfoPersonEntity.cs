
using System;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BoardingInfoPersonEntity 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? BoardingInfoPersonId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string FirstName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string LastName { get; set; }

    /// <summary>
    /// Gets or sets the address associated with the entity.
    /// </summary>
    /// <value>The address represented by an AddressModel object.</value>
    public string Address { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Country { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string State { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string City { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Zip { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Phone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BirthDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string GovId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? SharePercentage { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsRepresentant { get; set; }

    }
}