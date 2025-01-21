using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    public class OverloadingOverriding
    {
        public int sum(int a, int b)
        {
            return a + b;
        }

        public string sum(string a, string b)
        {
            return a +" " + b;
        }

        public int sum(int a, int b, int c)
        {
            return a + b + c;
        }

       public static void Main1(string[] args)
        {
            Employee1 employee = new Employee1();

            employee.PrintEmployee();

            Employee1 employee1 = new Child1();
            employee1.PrintEmployee();

            Console.ReadLine();
         //   Child1 child2 = new Employee1();
            


        }
    }

    public class Employee1
    {
        public virtual void PrintEmployee()
        {
            Console.WriteLine("Employee is called");
        }
    }

    public class Child1 : Employee1
    {
        public override void PrintEmployee()
        {
            Console.WriteLine("Child is called");
        }
    }


}
