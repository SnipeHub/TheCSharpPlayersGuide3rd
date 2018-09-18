using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationTry // Try it out! end of chp 14
{
    public enum MonthsOfYear { January = 1, Febuary = 2, March = 3, April = 4, May = 5, June = 6, July = 7, August = 8, September = 9, October = 10, November = 11, December = 12 };

    class Program
    {
        static void Main()
        {
            // intro
            Console.WriteLine("------| Our months of the year converter |------");
            Console.WriteLine();

            // Getting user input for entered number
            Console.Write("Please enter the month you want returned, enter a number from 1 to 12: ");
            string getUserInputString = Console.ReadLine();
            int monthInt = Convert.ToInt32(getUserInputString);

            // check to make sure the input is valid
            if (monthInt > 0 && monthInt <= 12)
            {
                // print out the month name, we also do the explicit convert from an int
                MonthsOfYear month = (MonthsOfYear)monthInt;
                Console.WriteLine($"You entered {getUserInputString}, the Month is: {month}.");
            }
            else // if none of the correct numbers are used, print error and start again
            {
                Console.WriteLine("You did not enter a valid number, there are only 12 options, please try again...");
                Console.WriteLine("Press enter to restart...");
                Console.ReadKey();
                Console.Clear();

                // loop back to start
               Program.Main();
            }
            

            Console.ReadKey();
        }
    }
}
