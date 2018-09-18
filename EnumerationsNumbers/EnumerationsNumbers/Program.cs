using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationsNumbers // just a play around for myself, another way of doing it, if using user input, the previous way I did it is still correct if you just want to return the enum values
{
    // we can assign specific values to our enum
    public enum CarNames { Ferrari = 1, McLaren = 2, Lamborghini = 3, Dodge = 5, Renault = 4};

    class Program
    {
        static void Main()
        {
            Console.WriteLine("------| Our Awesome Car List |------");
      
            Console.WriteLine();
            Console.WriteLine("Please enter a number between 1 to 5: ");
            string numberString = Console.ReadLine();
            int carNumber = Convert.ToInt32(numberString);

            // check if entry input is valid
            if (carNumber > 0 && carNumber <= 5)
            {
                CarNames _carName = (CarNames)carNumber; // explicit convert from number
                Console.WriteLine($"You chose number {numberString} and the car is: {_carName}");
            }
            else
            {
                // if incorrect input, restart
                Console.WriteLine("You did not enter a valid number, please enter a number between 1 and 5.");
                Console.WriteLine("Press enter to restart...");
                Console.ReadKey();
                Console.Clear();

                Program.Main();
            }

            Console.ReadKey();
        }
    }
}
