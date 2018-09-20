using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I'm about to go into a method.");
            Console.WriteLine();

            CountToTen();

            Console.WriteLine();
            Console.WriteLine("We are now back from the method.");
        }

        static void CountToTen()
        {
            for (int index = 1; index <= 10; index++)
            {
                Console.WriteLine($"{index}");
            }
            Console.WriteLine("This is inside the method doing the counting from 1 to 10");
        }
    }
}
