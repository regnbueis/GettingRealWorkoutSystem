using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmbracoWorkoutSystem.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UmbracoWorkoutSystem.Persistence
{
    public static class EmployeeRepository
    {
        private static List<Employee> employees = new List<Employee>();

        public static void Initialize()
        {

            employees = new List<Employee>();
            try
            {
                int employeeid = 0;

                using StreamReader sr = new StreamReader("EmployeePersistence.txt");
                {
                    string line = sr.ReadLine();

                    List<Employee> result = JsonConvert.DeserializeObject<List<Employee>>(line);

                    foreach (Employee employee in result)
                    {
                        if (employee.EmployeeId > employeeid)
                            Log.SetId(employeeid);
                    }

                    employees = result;
                }
            }
            catch (IOException)
            {
                throw;
            }
        }

        public static void Save()
        {
            try
            {
                using StreamWriter sw = new StreamWriter("EmployeePersistence.txt");
                {
                    string saveObject = JsonConvert.SerializeObject(employees);
                    sw.WriteLine(saveObject);
                }
            }
            catch
            {
                throw new Exception("Save not succesful");
            }
        }

        public static Employee Add(string name, bool admin)
        {
            Employee result = null;

            if (!string.IsNullOrEmpty(name))
            {
                result = new Employee()
                {
                    Name = name,
                    Admin = admin
                };
                employees.Add(result);
            }
            else
                throw new ArgumentException("Not all arguments are valid");

            return result;
        }

        public static void Edit(int id, string name, bool admin)
        {

            Employee employee = GetById(id);

            if (employee != null)
            {
                if (string.IsNullOrEmpty(name))
                {
                    if (employee.Name != name)
                        employee.Name = name;
                    if (employee.Admin != admin)
                        employee.Admin = admin;
                }
                else
                    throw new ArgumentException("Not all arguments are valid");
            }
            else
                throw new ArgumentException("Employee with ID " + id + " not found");
        }

        public static void Delete(int id)
        {
            Employee employee = GetById(id);
            if (employee != null)
                employees.Remove(employee);
            else
                throw new ArgumentException("Employee with ID " + id + " not found");
        }

        public static Employee GetById(int id)
        {
            Employee result = null;

            foreach (Employee e in employees)
            {
                if (e.EmployeeId == id)
                    result = e;
            }
            return result;

        }
    }
}
