using System;

namespace HolaWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please eneter your username");
            userName = Console.ReadLine();
            if (isRegistered) 
            {
                Console.WriteLine("Hi there, registered user");
                if (userName != "")
                {
                    Console.WriteLine("Hi there, " + userName);
                    if (userName.Equals("admin"))
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
            }
            Console.Read();
        } 
    }
}
