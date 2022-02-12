using System;

namespace HolaWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            if (int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else 
            {
                numTemp=0;
                Console.WriteLine("Value entered was not a number. 0 set as temperature");
            }
            if (numTemp < 70)
            {
                Console.WriteLine("We NEED a coat!");
            }
            else if (numTemp == 70)
            {
                Console.WriteLine("Coat optional!");
            }
            else
            {
                Console.WriteLine("It is warm, we definitely don't need a coat!");
            }

            Console.ReadKey();
        } 
    }
}
