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
            //convert the string to uppercase
            string groguUpperCase = String.Format("Upper case: {0}", grogu.ToUpper());
            //Print the string groguUpperCase
            Console.WriteLine(groguUpperCase);
            //convert the string to lowercase
            string groguLowerCase = String.Format("Lower case: {0}", grogu.ToLower());
            //Print the groguLowerCase string variable
            Console.Write(groguLowerCase);
            //Trim the groguTrim variable
            string groguTrim = String.Format("Trim: {0}", grogu.Trim());
            //print the trimmed version of the string. Remove white space before and after the string
            Console.WriteLine(groguTrim);
            //Substring
            string groguSubString = String.Format("SubString: {0}", grogu.Substring(3,5));
            Console.WriteLine(groguSubString);
        }   
    }
}
