using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    public class LINQ
    {

        public static void Main()
        {
            // Data source Or Database 
            string[] records = {"Rajesh", "Geeks", "Utkarsh"
          , "Aaditya", "Sourabhe"};

            // LINQ Query  
            var Linq_query = from name in records
                             where name.Contains('e')
                             select name;

            // Query execution 
            foreach (var name in Linq_query)
                Console.Write(name + " \n");

            var resp = Linq_query.Where(x => x.Contains('e'));


            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var evenNumbers = from number in numbers
                              where number % 2 == 0
                              select number;
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }



            int[] sequence1 = { 112, 44, 55, 66, 77, 777, 56 };
            string[] sequence2 = { "Geeks", "GeeksforGeeks" };

            // Get the element which specifies 
            // the given condition Using  
            // Last(Condition) function 
            var result1 = sequence1.Last(seq => seq < 777);
            var result3 = sequence1.First();

            var result4 = sequence1.ElementAt(3);

            Console.WriteLine("Element: {0}", result1);
            Console.WriteLine("Element: {0}", result3);
            Console.WriteLine("Element: {0}", result4);

            // Get the only element of the  
            // sequence Using Last() function 
            var result2 = sequence2.Last();

            Console.WriteLine("Element: {0}", result2);

            List<Employee> emp = new List<Employee>() {

            new Employee() {emp_id = 209, emp_name = "Anjita", emp_gender = "Female",
                                    emp_hire_date = "12/3/2017", emp_salary = 20000},

            new Employee() {emp_id = 210, emp_name = "Soniya", emp_gender = "Female",
                                      emp_hire_date = "22/4/2018", emp_salary = 30000},

            new Employee() {emp_id = 211, emp_name = "Rohit", emp_gender = "Male",
                                  emp_hire_date = "3/5/2016", emp_salary = 40000},

            new Employee() {emp_id = 212, emp_name = "Supriya", emp_gender = "Female",
                                      emp_hire_date = "4/8/2017", emp_salary = 40000},

            new Employee() {emp_id = 213, emp_name = "Anil", emp_gender = "Male",
                                emp_hire_date = "12/1/2016", emp_salary = 40000},

            new Employee() {emp_id = 214, emp_name = "Anju", emp_gender = "Female",
                                  emp_hire_date = "17/6/2015", emp_salary = 50000},
        };

            var first= emp.First();

            var last = emp.Last();

            var second = emp.ElementAt(1);



            ///Intersect Operator 
            ///

            char[] seq1 = {'m', 'q', 'o',
                           's', 'y', 'a'};

            char[] seq2 = {'p', 't', 'r',
                           's', 'y', 'z'};

            // Display the sequences 
            Console.WriteLine("Sequence 1 is: ");

            foreach (var s1 in seq1)
            {
                Console.WriteLine(s1);
            }

            Console.WriteLine("Sequence 2 is: ");

            foreach (var s2 in seq2)
            {
                Console.WriteLine(s2);
            }

            // Get intersection of the given sequence 
            // Using Intersect function 
            var result = seq1.Intersect(seq2);

            Console.WriteLine("New Intersect Sequence: ");

            foreach (var val in result)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("New Except Sequence: ");

            var expect = seq1.Except(seq2);
            foreach (var val in expect)
            {
                Console.WriteLine(val);
            }

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int emp_id { get; set; }

        public string emp_name { get; set; }

        public string emp_gender { get; set; }

        public string emp_hire_date { get; set; }

        public int emp_salary { get; set; }
    }
}
