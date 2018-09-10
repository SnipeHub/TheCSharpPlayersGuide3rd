using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingArrays.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring array
            // int[] score;

            int[] score = new int[10]; // we declare and create our array with new and define how many in the array.

            string[] namesArray = new string[10]; // here is a string array. 

            // now to put our values into the array.
            score[0] = 99; // remember, all arrays start at 0.
            string blueString = namesArray[0];

            // other ways to create arrays
            int[] score1 = new int[10] { 100, 95, 92, 87, 55, 50, 48, 40, 35, 10 }; // we create and set the array values at the same time.

            // or you can leave how many in the array out
            int[] score2 = new int[] { 55, 28, 28, 4040, 210, 100, 248, 98, 1, 10 }; // the array knowes how much it will need by the values you have declared.

            // seeing as they are all integers, you can also leave out the int as long as all of the items are the same literal type
            int[] score3 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
    }
}
