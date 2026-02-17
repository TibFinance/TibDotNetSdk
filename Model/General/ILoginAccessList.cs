using System;

namespace Tib.Api.Model.General
{
    public interface ILoginAccessList
    {
        Guid ClientId { get; set; }
        string Username { get; set; }
        string Password { get; set; }
    }
}
