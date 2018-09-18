using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations  // chp 14
{
    // you define your enumeration inside the namespace
    // Enumerations are used when we need to define a set of specific known variables, like the days of the week
    public enum DaysOfWeek {Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday}; // enum's can also be defined in their own file, coming in chp 18

    class Program
    {
        static void Main(string[] args)
        {
            // back inside your main method, you can now create variables that have your DaysOfWeek type
            //DaysOfWeek today; // we now create a new type variable 'today', which works just like any other variable

            // We now need to assign that new variable a value, we do so by using the '.' dot operator or member access operator.
            // This means that you use the . operator to use something that is a part of something else.
            //today = DaysOfWeek.Tuesday; // as you can see when you type the '.' operator, intellisense will show you all the values in our enumeration!

            Console.WriteLine("------| Welcome to Enumerations |------");
            Console.WriteLine();

            // this will also work like any other variable, even in an 'if' statement
            DaysOfWeek today = DaysOfWeek.Wednesday;
            //DaysOfWeek yesterday = DaysOfWeek.Saturday;

            if (today == DaysOfWeek.Wednesday)
            {
                Console.WriteLine($"Today is {today}");
            }

            // Enumerations force the computer (and programmers) to use only specific, named (“enumerated”) values.
            // It prevents tons of errors, and makes your code more readable.


            OtherTypes();
        }

        static void OtherTypes()
        {
            // by default, C# is wrapping our enumeration around an underlying type, which is the 'int' type, though it is possible to choose a different integer type
            // when you create an enumeration, each item in your list is assigned a number, starting at 0.
            Console.WriteLine("\n");
            Console.WriteLine("------| Assigning other types |------");
            Console.WriteLine();

            int dayAsInt = (int)DaysOfWeek.Thursday;
            DaysOfWeek today = (DaysOfWeek)dayAsInt; // Both of these require an explicit cast.

            int dayAsIntOurDay = (int)DaysOfWeek.Friday;
            DaysOfWeek ourDay = (DaysOfWeek)dayAsIntOurDay;

            Console.WriteLine($"This is an explicit cast, {today} has a value of: {dayAsInt}");

            Console.WriteLine($"{ourDay} is number: {dayAsIntOurDay}");
        }
    }
}
