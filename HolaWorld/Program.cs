using System;

namespace HolaWorld
{
    internal class Program
    {
        //Entry point of our program
        static void Main(string[] args)
        {
            //declaring a variable
            int num1;
            //assigning a value to a variable
            num1 = 13;

            //declaring and initializing a variable in one go
            int num2 = 23;

            //sum will be used to add the sum of the two integer variables
            int sum = num1 + num2;

            //using concatination
            Console.WriteLine("num1 is " + num1);
            Console.WriteLine("num1 " + num1 + " + num2 " + num2 + " is " + sum);
            Console.Read();


        }
    }
}
