using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferences
{
    class Program
    {
        static void Main(string[] args)
        {
            // One interesting thing about reference types is that you can have them reference nothing at all. This is called a null reference. Just assign a value of null.
            string message = null;

            // we create a new array and assign numbers
            int[] numbers = new int[] { 1, 2, 4, 8, 16, 32, 64, 128 };

            // We have now reassigned numbers variable to null. The array is no longer being referecnced, therefore it has become inaccessible, and isolated on the heap. Eventually it will be garbaged collected.
            numbers = null;

            // your program will crash if you try to do something with it if its value is null.
            int[] number = null;
            number[3] = 6; // This crashes, since numbers doesn't reference anything.

            // To address this, you can do a simple check to see if a reference type is null first:
            if(number != null)
            {
                number[3] = 6;
            }


            // try out questions (my answers)

            // 1. False Y
            // 2. True  Y
            // 3. True  Y
            // 4. False Y
            // 5. True  Y
            // 6. True  N SHOULD BE FALSE
            // 7. True  N False
            // 8. True  Y
            // 9. False Y
        }
    }
}
