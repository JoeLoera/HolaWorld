using System;

namespace HolaWorld
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //declare a string variable with no value
            string grogu;
            //Print on the console "Please eneter your name and press enter"
            Console.WriteLine("Please enter your name and press enter: ");
            //assign the entered string to variable grogu
            grogu = Console.ReadLine();
            //Print the new entered value of grogu
            Console.WriteLine(grogu);
            //Converts the grogu string to uppercase
            Console.WriteLine(grogu.ToUpper());
            //Convert the grogu string to lowercase
            Console.WriteLine(grogu.ToLower());
            //Trim the white space before and after the string
            Console.WriteLine(grogu.Trim());
            //Still having an issue with the substring
            string groguSubString = String.Format("Substring value : {0}", groguSubString.Substring) (0,5);


        }
    }
}
