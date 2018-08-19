using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSwitchStatement
{
    class Program
    {
        static void Main()
        {
            // The if/else if method
            int menuChoice = 3;

            if (menuChoice == 1)
                Console.WriteLine("You chose option #1.");
            else if (menuChoice == 2)
                Console.WriteLine("You chose option #2. I like that one too!");
            else if (menuChoice == 3)
                Console.WriteLine("I can't believe you chose option #3.");
            else if (menuChoice == 4)
                Console.WriteLine("You can do better than 4....");
            else if (menuChoice == 5)
                Console.WriteLine("5? Really? That's what you went with?");
            else
                Console.WriteLine("Hey! That wasn't even an option!");

            SwitchMethod();
        }

        // Here is the switch way which works the same as above
        static void SwitchMethod()
        {
            int menuChoice = 5;

            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("You chose option #1");
                    break; // you must have a break at the end of each case
                case 2:
                    Console.WriteLine("You chose option #2. I like that one too!");
                    break;
                case 3:
                    Console.WriteLine("I can't believe you chose option #3.");
                    break;
                case 4:
                    Console.WriteLine("You can do better than 4....");
                    break;
                case 5:
                    Console.WriteLine("5? Really? That's what you went with?");
                    break;
                default: // this acts like a catch-all for anything other than the specific situations of the other case labels
                    Console.WriteLine("Hey! That wasn't even an option!");
                    break;

                    // you also can't write arbitrary logic like "case < 10:" or "case x < 10:" you will have to fall back to if statements instead.
                    // Also not all types can be used in a switch, the ones that can be used are: bool, string, and any of the integral types including char. Also enumerations
            }
        }
    }
}
