using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eManager.Core
{
    public class Department
    {

            public virtual string Name { get; set; }
            public virtual int Id { get; set; }
            public virtual ICollection<Employee> Employees { get; set; }
    }
}
