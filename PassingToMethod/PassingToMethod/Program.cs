using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingToMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Count(5);
            
            Count(15); // we define in the brackets the number of counts
        }

        // Our number counter. You must alos have an explicit type, you can not use var.
        static void Count(int numberToCountTo)
        {
            for (int current = 1; current <= numberToCountTo; current++)
                Console.WriteLine(current);
            Console.WriteLine();
        }
    }
}
