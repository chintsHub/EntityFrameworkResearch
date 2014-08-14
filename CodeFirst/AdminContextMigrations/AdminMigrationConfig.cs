using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Contexts;

namespace CodeFirst.AdminContextMigrations
{
    public class AdminMigrationConfig : DbMigrationsConfiguration<AdminContext>
    {
        public AdminMigrationConfig()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"AdminContextMigrations";
        }

        protected override void Seed(AdminContext context)
        {
        }
    }
}
