using System;
using System.Collections.Generic;
using System.Text;

namespace AspCoreRestAPI.Contracts
{
    public interface IRepositoryWrapper
    {
        IClientRepository Client { get; }
        void Save();
    }
}
