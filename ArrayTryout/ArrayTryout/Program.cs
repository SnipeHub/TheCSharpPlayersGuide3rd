using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTryout // tryout Page 106 copying an array http://starboundsoftware.com/books/c-sharp/try-it-out/copying-an-array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[] { 34, 88, 1, 97, 16, 32, 33, 48, 59, 100 };
            int arrayOneLength = arrayOne.Length;

            // copy the values from one array to a copy
            int[] arrayOneCopy = new int[arrayOne.Length];
            for (int index = 0; index < arrayOne.Length; index++)
            {
                arrayOneCopy[index] = arrayOne[index];
            }

            // print out the original array.
            for (int index = 0; index < arrayOne.Length; index++)
            {
                Console.WriteLine($"Original Array: {arrayOne[index]}");
            }
            Console.WriteLine(); // writes a blank line, think of it as a new paragraph
            Console.WriteLine($"The array count is {arrayOneLength} items.");
            Console.WriteLine();

            // print out the copy.
            for (int index = 0; index < arrayOneCopy.Length; index++)
            {
                Console.WriteLine($"Copy of Array: {arrayOneCopy[index]}");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
