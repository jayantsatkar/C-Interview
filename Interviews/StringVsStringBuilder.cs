using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interviews
{
    public class StringVsStringBuilder
    {
        public static void Main1(string[] args)
        {
            string a = "abc";
            StringBuilder b = new StringBuilder();
            b.Append("abc");
        }
    }
}
