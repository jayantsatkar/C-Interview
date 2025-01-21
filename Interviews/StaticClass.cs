using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    public static class Parent
    {
        public static void PrintA()
        {
            Console.WriteLine("Hello World");
        }
    }

    public static class Child // : Parent // Inheritance Not Possible in Static Class
    {
        
        public static void PrintB()
        {
            
            IList<Employee> employee = new List<Employee>() {
            new Employee()
            {
                emp_id = 209,
                emp_name = "Anjita",
                emp_gender = "Female",
                emp_hire_date = "12/3/2017",
                emp_salary = 20000
            }};

            var a = employee.First();

            dynamic b = employee.First();
            
          
        }
    }

    
}
