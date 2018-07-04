using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAllStringTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte littleByte = 255;
            Console.WriteLine(littleByte);

            short littleShort = 32000;
            Console.WriteLine(littleShort);

            int strongInt = 2147483640;
            Console.WriteLine(strongInt);

            long bigLong = 9000000000000000000;
            Console.WriteLine(bigLong);

            sbyte signedByte = -128;
            Console.WriteLine(signedByte);

            ushort unShortByte = 65500;
            Console.WriteLine(unShortByte);

            uint unInteger = 4200900280;
            Console.WriteLine(unInteger);

            ulong unLong = 18400000000000000000;
            Console.WriteLine(unLong);

            float floatBoat = 8723984.4654356F;
            Console.WriteLine(floatBoat);

            double preDouble = 298398.02893029300;
            Console.WriteLine(preDouble);

            decimal preDecimal = 29389120839123.9823098123M;
            Console.WriteLine(preDecimal);

            string message = "This is a string message!";
            Console.WriteLine(message);
        }
    }
}
