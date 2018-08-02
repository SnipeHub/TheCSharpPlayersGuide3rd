using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // The '!' means the logical opposite of what is supplied to it.
            int score = 100;
            int pointsNeededToPass = 45;
            bool levelComplete = (score >= pointsNeededToPass);
            int oldHighScore = 105;

            if (levelComplete)
            {
                Console.WriteLine("You've beaten the level!");
            }

            if (!(score > oldHighScore))
            {
                Console.WriteLine("Not greater then your previous");
            }

            // this is effectively the same as the !
            if (score <= oldHighScore)
            {

            }
        }
    }
}
