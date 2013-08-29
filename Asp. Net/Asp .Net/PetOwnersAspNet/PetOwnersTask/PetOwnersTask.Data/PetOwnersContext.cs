using System;
using System.Linq;
using System.Data.Entity;
using PetOwnersTask.Models;

namespace PetOwnersTask.Data
{
    public class PetOwnersContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }
        public DbSet<PetBase> Pets { get; set; }
    }
}
