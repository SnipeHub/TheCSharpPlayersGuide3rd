using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsCalculatePlayerScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int getPlayerScore = CalculatePlayerScore();
            Console.WriteLine($"Your score is: {getPlayerScore}");
            Console.WriteLine();

            DoSomething();

            Console.ReadKey();
        }

        static int CalculatePlayerScore()
        {
            int livesLeft = 3;
            int underlingsDestroyed = 22;
            int minionsDestroyed = 6;
            int bossesDestroyed = 2;

            // of the player is out of lives, they lose all of their points.
            if (livesLeft == 0)
            {
                return 0; // when return is used, it will holt the flow of execution and goes back to where the method was called from. In this case, no score is calculated and the score will be 0.
            }

            // Otherwise, the player gets 10 points per underling destroyed, 100 points
            // per minion, and 1000 points per boss.
            return underlingsDestroyed * 10 + minionsDestroyed * 100 + bossesDestroyed * 1000;
        }

        // even when a methods type is void, you don't need the return keyword anywhere, but it can still be used alone to return early.
        static void DoSomething() // You can’t make the return type of a method be var. You must always explicitly state the type.
        {
            int aNumber = 1;

            if (aNumber == 2)
            return;

            Console.WriteLine("This only gets printed if the 'return' statement wasn't executed.");
        }
    }
}
