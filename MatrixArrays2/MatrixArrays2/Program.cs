using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arrayThreeByThree = new int[3, 3] // 3 rows by 3 columns
            {
                { 0,1,2},           // row 1
                { 3,4,5},           // row 2
                { 6,7,8}            // row 3
            };
         // 3 columns

            for (int row = 0; row < arrayThreeByThree.GetLength(0); row++)
            {
                for (int column = 0; column < arrayThreeByThree.GetLength(1); column++)
                {
                    Console.Write(arrayThreeByThree[row, column] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
