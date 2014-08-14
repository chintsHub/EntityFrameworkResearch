using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Entities;

namespace CodeFirst.Contexts
{
    public class AdminContext : DbContext
    {
        public IDbSet<User> Users { get; set; }
        public IDbSet<Role> Roles { get; set; }


        public AdminContext()
        {
        }

        public AdminContext(string connectionString) : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //var mapperType = typeof(CodeFirst.Mapper.BaseMapper);
            //var mapperAssembly = mapperType.Assembly;
            //var mappers = mapperAssembly.GetTypes().Where(t => mapperType.IsAssignableFrom(t) && t != mapperType);
            //foreach (var m in mappers.Select(mapper => (CodeFirst.Mapper.BaseMapper)Activator.CreateInstance(mapper, modelBuilder)))
            //{
            //    if (m.GetType() == typeof(User) || m.GetType() == typeof(Role))
            //        m.RegisterMapping();

            //}

            //base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>().ToTable("Users");

            modelBuilder.Entity<User>().HasKey(c => c.UserId);
            modelBuilder.Entity<User>().Property(c => c.FirstName).IsRequired();
            modelBuilder.Entity<User>().Property(c => c.LastName).IsRequired();
            modelBuilder.Entity<User>().HasRequired(c => c.MyRole);

            modelBuilder.Entity<Role>().ToTable("Roles");
            modelBuilder.Entity<Role>().HasKey(c => c.RoldeId);
            modelBuilder.Entity<Role>().Property(c => c.RoleName).IsRequired();
        }
    }
}
