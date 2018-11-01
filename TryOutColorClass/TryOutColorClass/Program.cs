using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryOutColorClass
{
    class Program
    {
        /// <summary>
        /// Tests the Ball and color classes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create two different balls of different colors and sizes.
            Ball bigRed = new Ball(new Color(255, 0, 0), 5);
            Ball littlePurple = new Ball(new Color(255, 0, 255), 3);

            // Throw the big red ball around a few times.
            bigRed.Throw();
            bigRed.Throw();
            bigRed.Throw();
            Console.WriteLine("Big Red Ball Thrown: " + bigRed.GetTimesThrown());

            // Throws the little purple ball around.
            littlePurple.Throw();
            littlePurple.Throw();
            Console.WriteLine("Little Ball thrown: " + littlePurple.GetTimesThrown());

            // Pop the little purple ball and make sure that the throw
            // count doesn't keep going up if the ball has been popped.
            littlePurple.Pop(); // this will reset to zero, halting the increment method
            littlePurple.Throw();
            Console.WriteLine(littlePurple.GetTimesThrown());

            Console.ReadKey();
        }
    }
}
