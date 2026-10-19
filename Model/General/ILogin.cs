using System;

namespace Tib.Api.Model.General
{
    public interface ILogin : ILoginAccessList
    {
        Guid LoginsUserRelationsId { get; set; }
    }
}
