using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eManager.Core;

namespace eManager.Core
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
    }

    public class DepartmentRepository :  IDepartmentRepository
    {
        IQueryable<Department> Departments;
       
        IEnumerable<Department> IDepartmentRepository.GetAll()
        {
            throw new NotImplementedException();
        }

    }
}

 