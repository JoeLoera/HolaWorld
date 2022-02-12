using System;

namespace HolaWorld
{

    class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Please eneter your username");
            username = Console.ReadLine();
            Console.WriteLine("Please eneter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("----------------------------------");
        }

        public static void Login()
        {
            Console.WriteLine("Please eneter your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please eneter your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("login successful");
                }
                else
                {
                    Console.WriteLine("login failed, wrong password. Restart program");
                }

            }
            else
            {
                Console.WriteLine("Login failed, wrong username. Restart program");
            }
        }
    }
}
