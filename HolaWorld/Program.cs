using System;

namespace HolaWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What's the temperature like?");
            string temperature = Console.ReadLine();
            int numTemp = int.Parse(temperature);

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
