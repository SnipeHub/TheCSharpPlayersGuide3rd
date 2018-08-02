using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestingIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int shields = 50;
            int armor = 20;

            if (shields <= 0)
            {
                if (armor <= 0)
                    Console.WriteLine("Your shields and armor are both zero! You're dead!");
                else
                    Console.WriteLine("Shields are gone, but armor is keeping you alive!");
            }
            else
            {
                Console.WriteLine("You still have shields left, The world is safe.");
            }
        }
    }
}
