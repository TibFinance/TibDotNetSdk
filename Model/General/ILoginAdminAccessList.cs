using System;

namespace Tib.Api.Model.General
{
    public interface ILoginAdminAccessList
    {
        Guid ClientId { get; set; }
        string Username { get; set; }
    }
}
