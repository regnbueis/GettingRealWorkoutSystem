using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbracoWorkoutSystem.Domain
{
    public class Employee
    {
        // idCount maintains a counter assigned as Id to each new Person-object and 
        // then incremented so that each Person-object has a unique Id number
        private static int idCount = 900;

        public int EmployeeId { get; } 
        public string Name { get; set; }
        public bool Admin { get; set; }

        public Employee(string name, bool admin) 
        {
            EmployeeId = idCount++;
            Name = name;
            Admin = admin;
        }
    }
}
