﻿using System;

namespace HolaWorld
{
    internal class Program
    {
        //Entry point of our program
        static void Main(string[] args)
        {
            //declaring a variable
            int num1;

            //declaring multiple variables at once
            int num3, num4, num5;

            //assigning a value to a variable
            num1 = 13;

            //declaring and initializing a variable in one go
            int num2 = 23;
            
            num2 = 100;
            
            //sum will be used to add the sum of the two integer variables
            //int sum = num1 + num2;

            //using concatination
            Console.WriteLine("num1 is " + num1);
            int sum = num1 + num2;
            Console.WriteLine("num1 " + num1 + " + num2 " + num2 + " is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            //adding at the end of the value specifies that we are working with a float
            //Without the f the program will think we are trying to write a double
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1 / f2 is " + fDiv);
            Console.Read();


        }
    }
}
