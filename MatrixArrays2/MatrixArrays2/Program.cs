using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {

        static void MatrixArrays()
        {
            // a matrix array or jagged array is an array of arrays, say that ten times, fast lol
            int[][] jagArray = new int[4][];

            jagArray[0] = new int[] { 3, 3, 3 };
            jagArray[1] = new int[] { 5, 5, 5, 5, 5 };
            jagArray[2] = new int[] { 1, 4, 22, 44, 34, 78 };
            jagArray[3] = new int[] { 2, 0, 9, 100, 594 };

            Console.WriteLine("Jagged Array - An array within an array");
            Console.WriteLine();

            // for this array, .Length will get all the dimensional values
            for (int row = 0; row < jagArray.Length; row++)
            {
                Console.Write($"Row({row}): ", row + 1);

                for (int column = 0; column < jagArray[row].Length; column++)
                {
                    Console.Write($"{jagArray[row][column]}" + " ");
                }
                Console.WriteLine();
            }

        }

        // program starts here, connects to method above, the code is not connected in anyway, just doing this so I can write out my examples all in one file.
        static void Main(string[] args)
        {
            int[,] arrayThreeByThree = new int[3, 3] // 3 rows by 3 columns
            {
                { 0,1,2},           // row 1
                { 3,4,5},           // row 2
                { 6,7,8}            // row 3
            };
            // 3 columns

            Console.WriteLine("3 x 3 Multi Dimensional array");
            Console.WriteLine();

            for (int row = 0; row < arrayThreeByThree.GetLength(0); row++)
            {
                for (int column = 0; column < arrayThreeByThree.GetLength(1); column++)
                {
                    Console.Write(arrayThreeByThree[row, column] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            MatrixArrays();
            Console.ReadLine();
        }
    }
}
