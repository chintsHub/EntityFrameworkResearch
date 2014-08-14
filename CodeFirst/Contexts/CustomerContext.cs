using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Entities;

namespace CodeFirst.Contexts
{
    public class CustomerContext : DbContext
    {
     
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<Customer> Customers { get; set; }

        public CustomerContext()
        {
        }

        public CustomerContext(string connectionString)
            : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //var mapperType = typeof(CodeFirst.Mapper.BaseMapper);
            //var mapperAssembly = mapperType.Assembly;
            //var mappers = mapperAssembly.GetTypes().Where(t => mapperType.IsAssignableFrom(t) && t != mapperType);
            //foreach (var m in mappers.Select(mapper => (CodeFirst.Mapper.BaseMapper)Activator.CreateInstance(mapper, modelBuilder)))
            //{
            //    if (m.GetType() == typeof(Order) || m.GetType() == typeof(Customer))
            //        m.RegisterMapping();

            //}

            //base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<Role>();
            modelBuilder.Ignore<User>();

            modelBuilder.Entity<Order>().ToTable("Orders");
            
            modelBuilder.Entity<Order>().HasKey(c => c.OrderId);
            modelBuilder.Entity<Order>().Property(c => c.Amount).IsRequired();
            modelBuilder.Entity<Order>().Property(c => c.Date).IsRequired();
            modelBuilder.Entity<Order>().Property(c => c.Quantity).IsRequired();
            modelBuilder.Entity<Order>().HasRequired(c => c.Customer);

            modelBuilder.Entity<Customer>().ToTable("Customers");

            modelBuilder.Entity<Customer>().HasKey(c => c.CustomerId);
            modelBuilder.Entity<Customer>().Property(c => c.CustomerName).IsRequired();
            modelBuilder.Entity<Customer>().HasMany(c => c.Orders);
        }
    }
}
