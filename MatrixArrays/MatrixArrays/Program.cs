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
            int[][] matrixOne = new int[4][];
            matrixOne[0] = new int[2];
            matrixOne[1] = new int[6];
            matrixOne[2] = new int[8];
            matrixOne[3] = new int[10];

            // continue filling in values...

            for (int row = 0; row < matrixOne.Length; row++)
            {
                for (int column = 0; column < matrixOne[row].Length; column++)
                
                    Console.WriteLine(matrixOne[row][column] + " "); // Each item in the row seperated by spaces
                Console.WriteLine(); // to put our spaces in the rows
            }
            

        }
    }
}
