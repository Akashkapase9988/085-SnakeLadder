using System;

namespace _085_SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake ladder Game");
            int Start_Position = 0;
            Random random = new Random();

            int Dice_No = random.Next(1, 7);
            Console.WriteLine("Player roll dice and dice no is :  " + "   " +Dice_No);

        }
    }
}
