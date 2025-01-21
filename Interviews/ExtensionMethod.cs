using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    public class ExtensionMethod
    {
        public ExtensionMethod()
        {
            Console.WriteLine("Hello World");
        }


        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World");

            string s = "hello world";
            Console.WriteLine(s.CapitalizeFirstLetter());
        }

        


    }

    public static class StringExtensions
    {
        public static string CapitalizeFirstLetter(this string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}
