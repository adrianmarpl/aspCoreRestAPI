using AspCoreRestAPI.Contracts;
using AspCoreRestAPI.Entities;
using AspCoreRestAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspCoreRestAPI.Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
