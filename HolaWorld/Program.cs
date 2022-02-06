using System;

namespace HolaWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            string friend1 = "Frank";
            string friend2 = "Kevin";
            string friend3 = "Julie";

            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            Console.Read();
        }
        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi " + friendName + ", my friend!");
        }
    }
}
