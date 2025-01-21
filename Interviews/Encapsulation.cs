using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    public class Encapsulation
    {
        private String studentName;
        private int studentAge;

        public String Name { get; set; }
        public int Age { get; set; }
        
    }

    class Geeks
    {
        static public void Main1()
        {
            Encapsulation obj = new Encapsulation();

            obj.Name = "Ankita";

            obj.Age = 21;

            Console.WriteLine(" Name : " + obj.Name);
            Console.WriteLine(" Age : " + obj.Age);
            Console.ReadLine();
        }
    }
}
