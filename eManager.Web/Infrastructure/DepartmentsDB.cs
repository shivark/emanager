using eManager.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace eManager.Web.Infrastructure
{
    public class DepartmentsDB : DbContext, IDepartmentRepository
    {
        public DepartmentsDB()
            : base("DefaultConnection"){}
        
        public DbSet<Department> Departments { get; set; }

        public IEnumerable<Department> GetAll()
        {
            return Departments.ToList<Department>();
        }
    }
}