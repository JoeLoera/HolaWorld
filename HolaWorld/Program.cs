using System;

namespace HolaWorld
{

    class Program
    {
       static void Main(string[] args)
        {
           int counter = 0;
           string enteredText = "";
           while (enteredText.Equals(""))
            {
                Console.WriteLine("Please press eneter to increase the amount by one and anything else" + " + enter if you want to finish counting");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine("Currrent people count is {0}", counter);
            }
            Console.WriteLine("{0} people are inside the bus. Press Enter to close the program", counter);
            Console.Read();
        }
    }
}
