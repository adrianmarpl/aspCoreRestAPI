using AspCoreRestAPI.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspCoreRestAPI.Entities
{
    public class RepositoryContext : DbContext
    {
        private static bool _created = false;
        public RepositoryContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlite(@"Data Source=d:\CrmDb.db");
        }

        public DbSet<Client> Clients { get; set; }
    }
}
