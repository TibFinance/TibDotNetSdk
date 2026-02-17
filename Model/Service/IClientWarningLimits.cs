using System;

namespace Tib.Api.Model.Service
{
    public interface IClientWarningLimits
    {
        decimal ClientWarningDepositLimit { get; set; }
        decimal ClientWarningCollectionLimit { get; set; }
    }
}
