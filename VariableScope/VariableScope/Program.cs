using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableScope
{
    class Program
    {
        public void DoSomething()
        {
            int a = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine(x);
            }

            x = -5; // This won't compile--the variable 'x' is "out of scope".
        }

        /// <summary>
        /// Interestingly, we can use the same variable named (x) for a different variable in a second for loop and they will not conflict.
        /// </summary>
        public void DoMore()
        {
            for (int x = 0; x < 10; x++)
                Console.WriteLine(x);

            for (int x = 50; x < 60; x++)
                Console.WriteLine(x);
        }

        static void Main(string[] args)
        {
        }
    }
}
