using System;

namespace HolaWorld
{

    class Program
    {
 
        static void Main(string[] args)
        {
            //WriteSomething(); method cannot be called from out main method because our main method is static. WriteSomething(); method must also be static
            WriteSomething();
            WriteSomethingSpecific("I am an argument");
        }
        //access modifier (static) return type method name (parameter, 1 parameter 2 )
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
    }
}
