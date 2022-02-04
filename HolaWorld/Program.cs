using System;

namespace HolaWorld
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //ask the user to enter a string
            Console.WriteLine("Enter a string here: ");
            //read the input form the user
            string input = Console.ReadLine();
            //Ask the user to select a character to search for
            Console.WriteLine("Select a character to search: ");
            //Read the character input to search
            char searchInput = Console.ReadLine()[0];
            //Gets the index of the character from the string.
            int searchIndex = input.IndexOf(searchInput);
            //Print the Index as a search result on console.
            Console.WriteLine("Index of character {0} in string is {1}", searchInput, searchIndex);

            Console.WriteLine("Enter first name: ");
            //read the first name
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            //Read the last name
            string lastName = Console.ReadLine();

            //Concatinate the firstName and lastName variable and assign that to fullName variable.
            string fullName = string.Concat(firstName, " ", lastName);
            //Prints the full name on the console.
            Console.WriteLine("Your full name is {0}", fullName);
            Console.ReadKey();
        }
    }
}
