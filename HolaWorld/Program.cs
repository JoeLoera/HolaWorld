using System;

namespace HolaWorld
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //Print a byte value. Ranges between 0 to 255
            byte myByte = 25;
            Console.WriteLine(myByte);
            //Print an sbyte value. Ranges between -128 to 127
            sbyte mySByte = -25;
            Console.WriteLine(mySByte);
            //Print an int value. Ranges between -2,147,483,648 to -2,147,483,647
            int myInt = 1234;
            Console.WriteLine(myInt);
            //Print an uint value. Ranges between 0 to 4294967295
            uint myUInt = 4294967293;
            Console.Write(myUInt);
            //Print a short value. Ranged between -32,768 to 32,767
            short myShort = 32762;
            Console.WriteLine(myShort);
            //Print a ushort value. 0 to 65535
            ushort myUShort = 65400;
            Console.WriteLine(myUShort);
            //Print a long value. -9223372036854775808 to 9223372036854775807
            long myLong = -9223372036854775807;
            Console.WriteLine(myLong);
            //Print ulong value 0 to 18446744073709551615
            ulong myULong = 18446744073709551611;
            Console.WriteLine(myULong);
            //Print float value. -3.402823e38 to 3.402823e38
            float myFloat = 3.402824f;
            Console.WriteLine(myFloat);
            //Print double value
            double myDouble = -12.1231250;
            Console.WriteLine(myDouble);
            //Print char value Unicode symbols used in text
            char myChar = 'J';
            Console.WriteLine(myChar);
            //Print bool value
            bool myBool = false;
            Console.WriteLine(myBool);
            //Print object
            //Print string
            string myString = "Joseph Loera";
            Console.WriteLine(myString);
            string numText = "23";

            int myNumFromText = int.Parse(numText);
            Console.WriteLine(myNumFromText);
            Console.ReadLine();
        }
    }
}
