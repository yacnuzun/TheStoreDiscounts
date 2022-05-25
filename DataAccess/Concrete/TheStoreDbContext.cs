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
        public DbSet<Bill>? Bills { get; set; }
        public DbSet<Card>? Cards { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer {Id=1,FullName = "Selim Acar",Card=CardTypes.Gold ,Affilation=true ,MemberDateTime= DateTime.Parse("5/2/2018")},
                new Customer {Id=2,FullName = "Selin Acar", Card = CardTypes.Silver, Affilation = true, MemberDateTime = DateTime.Parse("6/2/2020") },
                new Customer {Id=3,FullName = "Murat Gök", Card = CardTypes.Not, Affilation = false, MemberDateTime = DateTime.Parse("5/2/2021") }

                );
        }
    }
}
