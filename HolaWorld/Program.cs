using System;

namespace HolaWorld
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecondString = "13";
            //parse converts a string to it's 32 bit equivalent
            //This will create an int out of 15
            int num1 = Int32.Parse(myString);
            //parse converts a string to it's 32 bit equivalent
            //This will create an int out of 13
            int num2 = Int32.Parse(mySecondString);
            int result = num1 + num2;
            

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
