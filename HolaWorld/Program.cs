using System;

namespace HolaWorld
{

    class Program
    {
       static void Main(string[] args)
        {
            //condition ? first_expressiom : second_expression;
            //condition has to be either true or false
            //The conditional operator is right - associative
            //the expression a ? b: c? d:e
            //is evaluated as a ? b: (c ? d : e),
            //not as (a? b : c) ? d: e.
            //The conditional operator cannot be overloaded

            int temperature = 200;
            string stateOfMatter;

            if (temperature < 0)

                stateOfMatter = "solid";
            else
                stateOfMatter = "liquid";

            Console.WriteLine("State of matter is {0}", stateOfMatter);

            temperature += 30;

            //in short:
            stateOfMatter = temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("State of matter is {0}", stateOfMatter);

            //challenge - add the gas state of matter to the options
            stateOfMatter = temperature > 100 ? "gas" : temperature < 0 ? "solid" : "liquid";
            Console.WriteLine("Stateo of matter is {0}", stateOfMatter);

            Console.ReadKey();
            
        }
    }
}
