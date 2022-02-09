using System;

namespace HolaWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is it sunny today? {0}", !isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            //increment that takes effect in the next line
            Console.WriteLine("num is {0}", num++);
            //pre increment that happens just before
            Console.WriteLine("num is {0}", ++num);

            //decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            //predecrement
            Console.WriteLine("num is {0}", --num);

            int result;

            result = num1 + num2;
            Console.WriteLine("result of num1 + num 2 is {0}", result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num 2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num 2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num 2 is {0}", result);
            result = num1 % num2;
            Console.WriteLine("result of num1 % num 2 is {0}", result);

            //relational and type operators

            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("Result of num1 < num2 {0}", isLower);

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Result of num1 == num2 {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("Result of num1 != num {0}", isEqual);

            //conditional operators
            bool isLowerandSunny;
            isLowerandSunny = isLower && isSunny;
            //is only true if both conditions are true
            Console.WriteLine("result of isLower && isSunny is {0}", isEqual);

            //condition 1 or 2 
            isLowerandSunny = isLower || isSunny;
            //Console reflects true if either of the two conditions is true
            // || is for or
            Console.WriteLine("result of isLower || isSunny is {0}", isLowerandSunny);

            Console.ReadKey();

        } 
    }
}
