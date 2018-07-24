using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 2;
            int result = a / b;
            Console.WriteLine(result); // incorrect result, wheres the remainder??

            float d = 7.0f;
            float e = 2.0f;
            float f = d / e;
            Console.WriteLine(f);
        }
    }
}
