using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[10] { 33, 23, 1, 56, 768, 0, 99, 169, 17, 10 };

            foreach (int number in scores) // a lot easier to read and simpler than a for loop. Apparently a foreach loop is slower.
            {
                Console.WriteLine(number);
            }
        }
    }
}
