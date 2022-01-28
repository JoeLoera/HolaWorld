using System;

namespace HolaWorld
{
    internal class Program
    {
    
        static void Main(string[] args)
        {
            //string variable 
            string myName = "Joseph";
            
            //string variable contatination
            string message = "My name is " + myName;

            //message.ToUpper(); converts message to uppercase
            string capsMessage = message.ToUpper();

            //message.ToLower(); converts the string message to lowercase
            string lowerCaseMessage = message.ToLower();

            
            Console.WriteLine(lowerCaseMessage);
            Console.Read();
        }
    }
}
