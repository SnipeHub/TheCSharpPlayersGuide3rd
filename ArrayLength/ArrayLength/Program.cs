using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[101];

            int totalThingsInArray = scores.Length;
            Console.WriteLine($"There are {totalThingsInArray} things in the array.");
        }
    }
}
