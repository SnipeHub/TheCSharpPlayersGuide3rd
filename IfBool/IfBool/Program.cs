using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfBool
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 45; // Ideally, this would change as the player progresses through the game.

            int pointsNeededToPass = 100;

            bool levelComplete;

            if (score >= pointsNeededToPass)
                levelComplete = true;
            else
                levelComplete = false;

            if (levelComplete)
            {
                Console.WriteLine("You've beaten the level!");
            }
        }
    }
}
