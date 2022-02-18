using System;

namespace HolaWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            Human joe = new Human("Joe","Loera","brown", 29);
            joe.IntroduceMyself();

            Human julie = new Human("Julie", "Delgadillo", "purple", 29);
            julie.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human jacob = new Human("Jacob", "Jacob");
            jacob.IntroduceMyself();

            Human richard = new Human("Richard", "Scott", 32);
            richard.IntroduceMyself();


            Console.ReadKey();
        }
    }
}