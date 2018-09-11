using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageValueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int total = 0;
            int arrayTally = arrayOne.Length; // tells us how many in the array, not needed, just for myself

            for (int index = 0; index < arrayOne.Length; index++)
            {
                total += arrayOne[index];
            }
            float average = (float)total / arrayOne.Length;

            Console.WriteLine(average); // 11.55556
            Console.ReadKey();
        }
    }
}
