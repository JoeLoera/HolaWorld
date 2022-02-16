using System;

namespace HolaWorld
{

    class Program
    {
       static void Main(string[] args)
        {
            for (int counter = 0; counter < 50; counter+=5)
            { 
                Console.WriteLine(counter);
            }
            Console.WriteLine("For loop is done");
            Console.Read();
        }
    }
}
