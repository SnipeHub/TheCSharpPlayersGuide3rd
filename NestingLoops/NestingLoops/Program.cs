using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestingLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int column = 0; column < 5; column++)
            {
                for (int row = 0; row < 10; row++)
                    Console.Write("*");

                Console.WriteLine(); // This makes it wrap around the beginning of the line.
            }

            for(int row = 0; row < 10; row++)
            {
                for (int column = 0; column < row + 1; column++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
