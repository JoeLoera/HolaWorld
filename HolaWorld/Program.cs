using System;

namespace HolaWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            //One way to use the method and print the result
            //int result = Add(15, 31);
            //Console.WriteLine(result);
            //Console.Read();

            //Another way to get a result using the Add method I created
            Console.WriteLine(Add(15, 31));
            //You can also use the method multiple times:
            Console.WriteLine(Add(Add(1,4), Add(1, 5)));
            
            //Challenge, create a method that multiplies 2 numbers together and print the result
            Console.WriteLine(Multiple(23, 4));
            //Create a method that divides two numbers
            Console.WriteLine(Divide(46,2));
            Console.Read();

        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiple(int num1, int num2)
        { 
            return (num1 * num2);
        }
        public static double Divide(int num1, int num2)
        { 
        return num1 /num2;
        }
    }
}
