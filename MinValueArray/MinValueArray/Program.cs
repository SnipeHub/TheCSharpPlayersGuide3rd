using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinValueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int currentMinimum = Int32.MaxValue; // We start high, so that any element in the array will be lower.

            for (int index = 0; index < arrayOne.Length; index++)
            {
                if (arrayOne[index] < currentMinimum)
                {
                    currentMinimum = arrayOne[index];
                }
                else
                    Console.WriteLine(currentMinimum);
            }
            
        }
    }
}
