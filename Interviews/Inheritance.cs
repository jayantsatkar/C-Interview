using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    public interface IPerson
    {
        void PrintPerson();
    }

    public interface IPerson2
    {
        void PrintPerson();
    }
    public class Person : IPerson, IPerson2
    {
        public string AdharId { get; set; } = string.Empty;

        void IPerson.PrintPerson()
        {
            Console.WriteLine("PrintPerson Method is called");
        }

        void IPerson2.PrintPerson()
        {
            Console.WriteLine("PrintPerson Method is called");
        }

        public Person()
        {
            Console.WriteLine("Person CTOR Called");
        }
    }

    public class Person1
    {
        public void PrintPerson()
        {

        }

        public class Student : Person 
        {
            public int Id { get; set; } = 0;
            public Student()
            {
                Console.WriteLine("Student CTOR Called");
            }

            public void HelloWorld()
            {
                Console.WriteLine("Calling Hello World");
            }
        }

        public class Test
        {
            public static void Main()
            {
                Student s = new Student();
                s.Id = 1;
                s.AdharId = "1234";

                Person person = new Person();
                //person.

                testInterface1 obj1 = new Abc();
                testInterface2 obj2 = new Abc();
                obj1.Show();
                obj2.Show();

               
                Console.ReadLine();
            }
        }
        interface testInterface1
        {
            void Show();
        }
        interface testInterface2
        {
            void Show();
        }
        class Abc : testInterface1,    testInterface2
        {
            void testInterface1.Show()
            {
                Console.WriteLine("For testInterface1 !!");
            }
            void testInterface2.Show()
            {
                Console.WriteLine("For testInterface2 !!");
            }
        }
    }
}
