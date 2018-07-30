using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifRealtionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;

            Console.WriteLine("Please enter your age!: ");
            string scoreAsText = Console.ReadLine();
            score = Convert.ToInt32(scoreAsText);

            /*if (score != 53) // != this means not equal too.
            {
                // This code will be executed, as long as the score is not 100.
                Console.WriteLine("You can't lie to a computer, the computer knows all! Please try again!");
            }
            */
            if (score == 53)
            {
                Console.WriteLine("Happy Birthday! You are now 53 years old, whoohooo!");
            }

            else if (score > 60)
            {
                // this will only be executed if the score is more than 60.
                Console.WriteLine("Ok, your not that old, geez!");
            }

            else if (score < 53)
            {
                // This will only be executed if the score is less than 53.
                Console.WriteLine("Yeah, you wish you were that young!");
            }

            Console.ReadKey();
        }
    }
}
