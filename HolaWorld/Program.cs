using System;

namespace HolaWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            Human joe = new Human("Joe","Loera","brown", 29);
            joe.IntroduceMyself();

            Human julie = new Human("Julie", "Delgadillo", "purple", 1);
            julie.IntroduceMyself();

            Console.ReadKey();
        }
    }
}