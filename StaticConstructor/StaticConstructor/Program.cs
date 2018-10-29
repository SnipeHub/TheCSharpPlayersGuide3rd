using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Something
    {
        // When your class is first used, the CLR runtime that is executing your code will pause for a second and look
        // to see if a class has a static constructor.If it does, it will run it(once and never again during the
        // application’s lifetime).
        public static int sharedNumber;

        static Something()
        {
            sharedNumber = 3;
        }
    }
}
