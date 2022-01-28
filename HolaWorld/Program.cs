using System;

namespace HolaWorld
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            //explicit conversion
            // cast double to int;
            myInt = (int)myDouble;

            //type conversion
            //Converts myDouble to a string
            string myString = myDouble.ToString(); //13.37
            //Converts myFloat to a string
            string myFloatString = myFloat.ToString(); //13.37
            //Converts bool sunIsShining to a string
            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();


            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
}
