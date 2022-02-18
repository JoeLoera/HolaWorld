using System;

namespace HolaWorld
{

    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of Box
            Box box = new Box();
            //box.length = 3;
            box.SetLength(-4);
            box.height = 4;
            box.width = 5;
            Console.WriteLine("Box volume is " + box.GetVolume());
            box.DisplayInfo();
        }
    }
}