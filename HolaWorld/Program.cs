﻿using System;

namespace HolaWorld
{

    class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Joe";
        static void Main(string[] args)
        {
            CheckHighscore(250, "Maria");
            CheckHighscore(315, "Michael");
            CheckHighscore(350, "Joe");

            Console.Read();
        }

        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);
            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still " + highscore +" and held by " + highscorePlayer);
            }
        }
    }
}
