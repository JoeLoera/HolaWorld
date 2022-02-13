using System;

namespace HolaWorld
{

    class Program
    { 
        static void Main(string[] args)
        {
            int age = 19;
            switch (age) 
            {
                case 15:
                    Console.WriteLine("Too young to party in the club");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }
            //if statement version
            if (age == 15)
            {
                Console.WriteLine("To young to party in the club");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("Hold old are you then?");
            }

            string username = "Frank";

            switch (username)
            {
                case "Joe":
                    Console.WriteLine("username is Joe");
                    break;                
                case "root":
                    Console.WriteLine("username is root");
                    break;
                default:
                    Console.WriteLine("username is unknown");
                    break;



            }

            Console.ReadLine();
        }
    }
}
