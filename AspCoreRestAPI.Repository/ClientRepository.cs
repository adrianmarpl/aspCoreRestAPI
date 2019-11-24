using AspCoreRestAPI.Contracts;
using AspCoreRestAPI.Entities;
using AspCoreRestAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspCoreRestAPI.Repository
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }

        public Client GetClientById(int id)
        {
            return FindByExpression(client=>client.ID.Equals(id))
                .FirstOrDefault();
        }
    }
}
