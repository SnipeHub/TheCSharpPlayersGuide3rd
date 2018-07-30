using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Everything up here, before the if-statement will always be executed.
            int score;

            Console.WriteLine("Enter your score: ");
            string scoreAsText = Console.ReadLine();
            score = Convert.ToInt32(scoreAsText);

            if (score == 100) // This will only execeute if the score is true
            {
                Console.WriteLine("Perfect! you Win!");
            }

            else if (score == 99)
            {
                Console.WriteLine("Missed it by THAT much."); // Good old get smart reference, anyone?
            }

            else if (score == 0)
            {
                Console.WriteLine("You must have been TRYING to get that bad of a score.");
            }

            else
            
                // This code gets executed when it is not.
                Console.WriteLine("Ah, come on! You can do better than that.");
                // Only one of these blocks will get executed.
                // you can also remove the curly braces if you have only one statement. You will need them if you have multiple statements.
            

            // Everything down here, after the if-statement will also always be executed.
            Console.ReadKey();
        }
    }
}
