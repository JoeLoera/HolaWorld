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
            
            //When coding and writing if statements, we should always aim to make the code more legible and easy to read/understand
            if (isRegistered && userName != "" && userName.Equals("admin")) 
            {
                    Console.WriteLine("Hi there, registered user");
                    Console.WriteLine("Hi there "+ userName);
                    Console.WriteLine("Hi there, admin");
             
            }
            Console.Read();
        } 
    }
}
