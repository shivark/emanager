namespace eManager.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using eManager.Core;

    internal sealed class Configuration : DbMigrationsConfiguration<eManager.Web.Infrastructure.DepartmentsDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(eManager.Web.Infrastructure.DepartmentsDB context)
        {
                  context.Departments.AddOrUpdate(
                  p => p.Name,
                  new Department() { Name = "HR" },
                  new Department() { Name = "Sales" },
                  new Department() { Name = "IS" }
                );
            
        }
    }
}
