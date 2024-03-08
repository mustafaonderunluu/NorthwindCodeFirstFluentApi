using NorthwindEfCodeFirstFluentApi.Entities.EfCodeFirstMappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEfCodeFirstFluentApi.Context
{
    public class NortwindContext:DbContext
    {
        //public NortwindContext() : base("Name=ContextConnectionString") { 
        
        
        
        
        //}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderMap());
        }
    }
}
