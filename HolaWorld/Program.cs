//When a system is being used, it is highlighted. When it is not in use, it is greyed out.
//Removing System will cause errors because it will not recognize console
//We must include using System; namespace in order to use Console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HolaWorld
{
    internal class Program
    {
        //starting point of our program
        static void Main(string[] args)
        {
            //Changing the color properties of the console
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Hello Joe");
            Console.WriteLine("C# is cool!");
            Console.Read();
        }
    }
}
