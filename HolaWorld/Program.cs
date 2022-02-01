using System;

namespace HolaWorld
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //defining the variables variables
            int age = 29;
            string name = "Joseph";
            string color = "red";

            //1.string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old");
            
            //2. string formatting
            //string formatting uses index
            Console.WriteLine("String Formatting");
            //Here, the curly brackets are represent index {0} being the first, {1} being the second
            //{0} is the name {1} is the age variable
            Console.WriteLine("Hello my name is {0}, I am {1} years old and my favorite color is {2}", name, age, color);

            //3.String interpolation
            //string Interpolation uses $ at the start which wiill allow us to write our
            //variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");

            //4. Verbatim strings.
            //verbatim strings start with @ and tells the compiler to take the string
            //literally and ignore and spaces and escape characters like LineBreak - \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
            Nullam faucibus, nisi ut tincidunt tempus, orci lacus accumsan magna, in iaculis ligula nulla 
            vitae risus. Morbi in urna id ipsum blandit egestas eu ac ex. Integer et lorem et magna euismod 
            blandit. Ut lobortis quis orci non aliquet. Nam dolor lacus, dictum et dictum sed, 
            scelerisque ac ante. Donec porttitor nulla at tortor facilisis eleifend. Vivamus feugiat 
            ligula ultricies lectus finibus fermentum
            vitae nec tellus. In tristique dui ut ex consectetur, id porttitor enim luctus.");

            //instead of using \\ to wrute file paths we can use verbatim strings to make it easier
            // if you remove the @ you will receive an error because \U \A and \D are not valid escape characters
            Console.WriteLine(@"C:\Users\joelo\OneDrive\Pictures\Saved Pictures\20255840.jpg");

            //with verbatim strings even valid escape characters won't work
            Console.WriteLine(@"Even if we use \n , it will not create a line break!");
        }
    }
}
