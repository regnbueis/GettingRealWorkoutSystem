using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoWorkoutSystem
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public bool Admin { get; set; }

        public Employee(int employeeId, string name, bool admin) 
        {
            EmployeeId = employeeId;
            Name = name;
            Admin = admin;
        }
    }
}
