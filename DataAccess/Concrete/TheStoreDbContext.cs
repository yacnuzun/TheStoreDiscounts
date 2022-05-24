using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class TheStoreDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=TheStore;Trusted_Connection=True;");
        }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
