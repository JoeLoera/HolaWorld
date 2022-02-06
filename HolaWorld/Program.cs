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
            Console.Read();
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
