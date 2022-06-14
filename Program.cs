using System;
using System.Collections.Generic;
using System.Linq;

namespace CareerDawg.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
          List<Employee> employees = new List<Employee>();
          while (true)
          {
            Console.WriteLine("Please enter first name: (leave empty to exit): ");
            string firstName = Console.ReadLine();
            if(firstName == "")
            {
              break;
            }

            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter ID: ");
            int id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Photo URL:");
            string photUrl = Console.ReadLine();
            Employee currentEmployee = new Employee(firstName, lastName, id, photUrl);
            employees.Add(currentEmployee);
          }
          return employees;
        }
        
        static void Main(string[] args)
        {
          List<Employee> employees = GetEmployees();
          Util.PrintEmployees(employees);        
        }
        
    }
}
