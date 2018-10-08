using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceBag
{
    class Program // Chp 17 Pg 110 try it out! Die Rolling
    {
        static void Main(string[] args)
        {
            Random randomGen = new Random();

            // Gets the number of die to roll here
            Console.WriteLine($"Please enter number of 6d dice to roll: ");
            int count = Convert.ToInt32(Console.ReadLine());

            // Simulate a die roll for each of the dice that were requested.
            int total = 0;
            for (int index = 0; index < count; index++)
            {
                // The Next method is a part of the Random class. You can
                // call it if you have a Random typed object, which we do.
                int roll = randomGen.Next(6) + 1;
                total += roll;

                // We print out the individual die rolls, one at a time. 
                // The way these are being printed out (2+3+4+6=15), I have
                // it print out an extra plus, only if we're not on the last
                // one.
                if (index != count - 1)
                {
                    Console.Write(roll + "+");
                }
                else
                {
                    Console.Write(roll);
                }
            }

            // Print the sum.
            Console.WriteLine("=" + total);

            Console.ReadKey();
        }
    }
}
