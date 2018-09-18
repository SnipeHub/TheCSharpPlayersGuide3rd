using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationsNumbers
{
    // we can assign specific values to our enum
    enum CarNames { Ferrari = 1, McLaren = 3, Lamborghini = 4, Dodge = 10, Renault = 2};

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------| Our Awesome Car List |------");
            Console.WriteLine("Here we define our enumeration");
            Console.WriteLine();

            int ferrariAsInt = (int)CarNames.Ferrari;
            Console.WriteLine($"Our first car up is {CarNames.Ferrari}. It's number is {ferrariAsInt}");
            Console.WriteLine();

            int mclarenAsInt = (int)CarNames.McLaren;
            Console.WriteLine($"Our enumeration is {CarNames.McLaren}. It's number is {mclarenAsInt}");
            Console.WriteLine();

            int lamboAsInt = (int)CarNames.Lamborghini;
            Console.WriteLine($"Our third car is the {CarNames.Lamborghini}. The number is {lamboAsInt}");
            Console.WriteLine();

            int dodgeAsInt = (int)CarNames.Dodge;
            Console.WriteLine($"Next car is the {CarNames.Dodge}. The number is {dodgeAsInt}");
            Console.WriteLine();

            int renaAsInt = (int)CarNames.Renault;
            Console.WriteLine($"Our last car on the list is the {CarNames.Renault}. The number is {renaAsInt}");
            Console.WriteLine();
        }
    }
}
