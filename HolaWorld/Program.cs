using System;

namespace HolaWorld
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //declare a string variable with no value
            string myName;
            //Request the user to enter their name
            Console.WriteLine("Please enter your name and press enter");
            //assign to the users input to the value of myName
            myName = Console.ReadLine();
            //Change the format of myName to uppercase and assign it to variable myNameUpper
            string myNameUpperCase = String.Format("Upper case: {0}", myName.ToUpper());
            //assign the new uppercase value of the string to myNameUpperCase
            Console.WriteLine(myNameUpperCase);
            //Change the format of myName to lower case and assign it to variable myNameUpper
            string myNameLowerCase = String.Format("Lower case: {0}", myName.ToLower());
            //assign the new uppercase value of the string to myNameLowerCase
            Console.WriteLine(myNameLowerCase);
            //trim empty spaces at the beginning and end of the string
            string myNameTrimmed = String.Format("Trimmed value : {0}", myName.Trim());
            Console.WriteLine(myNameTrimmed);
            //substring provides a specific part of the string
            string myNameSubString = String.Format("Substring value : {0}", myName.Substring(1, 2));
            Console.WriteLine(myNameSubString);

            Console.ReadKey();
        }
    }
}
