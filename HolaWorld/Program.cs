using System;

namespace HolaWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            Human sissy = new Human();
            sissy.firstName = "Sissy";
            sissy.lastName = "Wagner";
            sissy.IntroduceMyself();

            Human franz1 = new Human();
            franz1.firstName = "Franzil";
            franz1.lastName = "Ryan";
            franz1.IntroduceMyself();

            Console.ReadKey();
        }
    }
}