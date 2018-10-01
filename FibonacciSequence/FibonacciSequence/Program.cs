using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 1; index <= 10; index++)
            {
                Console.WriteLine(Fibonacci(index));
            }

            Console.ReadKey();
        }

        static ulong Fibonacci(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            if (number == 2)
            {
                return 1;
            }

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }
    }
}
