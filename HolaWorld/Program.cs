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

            if (numTemp < 70) {
                Console.WriteLine("We NEED a coat!");
            }
            if (numTemp == 70)
            {
                Console.WriteLine("Coat optional!");
            }
            if (numTemp > 70)
            {
                Console.WriteLine("It is warm, we definitely don't need a coat!");
            }
        } 
    }
}
