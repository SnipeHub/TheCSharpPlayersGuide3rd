using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAveforeach // Tryout for end of chp 13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[10] { 33, 23, 1, 56, 768, 0, 99, 169, 17, 10 };

            int currentMinimum = Int32.MaxValue;

            foreach (int number in scores)
            {
                if (number < currentMinimum) // damn, I was close, had a bit too much going on.
                {
                    currentMinimum = number;
                }
                //Console.WriteLine($"Minimum: {currentMinimum}");
            }
            Console.WriteLine($"Minimum: {currentMinimum}"); // place this outside the foreach, so it will give you only the minimum answer. If you oput it inside, it still works, but will print out each min value it goes through
            Console.WriteLine();

            // determine the average value of the array
            int total = 0;

            foreach (int number in scores) // I like foreach, a lot easier to work with compared to using for
            {
                total += number; // += sum of the total
            }
            float average = (float)total / scores.Length; // all numbers totaled and / by how many numbers

            Console.WriteLine($"Average: {average}");
            Console.ReadKey();
        }
    }
}
