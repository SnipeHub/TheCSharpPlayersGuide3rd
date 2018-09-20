using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int usersNumber = GetNumberFromUser();
            Console.WriteLine($"You entered {usersNumber}");
            Console.WriteLine();
        }

        static int GetNumberFromUser()
        {
            int userNumber = 0;

            while (userNumber < 1 || userNumber > 10)
            {
                Console.Write("Enter a number between 1 and 10: ");
                string usersResponse = Console.ReadLine();
                userNumber = Convert.ToInt32(usersResponse);
            }

            return userNumber;
        }
    }
}
