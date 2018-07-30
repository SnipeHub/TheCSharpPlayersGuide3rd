using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDecisionMakingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;

            Console.WriteLine("Please enter your score: ");
            string scoreAsText = Console.ReadLine();
            score = Convert.ToInt32(scoreAsText);

            // This if-statement is separate from the rest of them. Not because of the blank
            // line between this statement and the next block, but because that starts all
            // over with a brand new if-statement.
            if (score == 100)
            {
                Console.WriteLine("Perfect score! You win!");
            }

            // This checks each condition in turn, until it finds the first one that
            // is true, at which point, it executes the chosen code block, then jumps down
            // to after the end of the whole if/else code.
            if (score >= 90)
                Console.WriteLine("You got an A."); // remember we donbt need curly braces as we are only using one statement in each block.
            else if (score >= 80)
                Console.WriteLine("You got a B.");
            else if (score >= 70)
                Console.WriteLine("You got a C.");
            else if (score >= 60)
                Console.WriteLine("You got a D.");
            else
                Console.WriteLine("You got an F.");

            Console.ReadKey();
        }
    }
}
