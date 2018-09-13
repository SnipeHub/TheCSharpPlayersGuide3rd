using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] matrixOne = new int[4, 4];
            //matrixOne[0, 0] = 1;
            // matrixOne[0, 1] = 0;
            // matrixOne[3, 3] = 1;

            // jagged array
            int[][] matrixOne = new int[5][];
            matrixOne[0] = new int[1];
            matrixOne[1] = new int[2];
            matrixOne[2] = new int[4];
            matrixOne[3] = new int[5];
            matrixOne[4] = new int[8];

            // continue filling in values...

            for (int row = 0; row < matrixOne.Length; row++)
            {
                for (int column = 0; column < matrixOne[row].Length; column++)
                {
                    Console.Write(matrixOne[row][column] + " "); // Each item in the row seperated by spaces Use console.Write rather than writeline.
                }
                Console.WriteLine(); // to put our spaces in the rows, otherwise it will write its all on one line.
            }
            

        }
    }
}
