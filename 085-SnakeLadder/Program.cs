using System;

namespace _085_SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to snake ladder Game");
            int   Start_Position = 0;
            int Current_Position = 0;
          
            Random random = new Random();

            int Dice_No = random.Next(1, 7);
            int Player_Choice = random.Next(1, 4);
            Console.WriteLine("Player roll dice and dice no is :  " + "   " +Dice_No);
        
            switch (Player_Choice)
            {
                    ///
                    ///  we using 1 for no play
                    ///
                case 1:
                    Console.WriteLine("Player is not playing ");
                    Current_Position += 0;
                    Console.WriteLine("Current position of player is :" + "  " + Current_Position);
                    break;

                    //
                    // we using 2 for ladder 
                    //
                    
                case 2:
                    Console.WriteLine("player is go for ladder");
                    Current_Position += Dice_No;
                    Console.WriteLine("Current position of player is :" + "  " + Current_Position);
                    break;

                    //
                    // we are using 3 for sanke point 
                    //
                case 3:
                    Console.WriteLine("Player go for Snake point ");
                    Console.WriteLine("Current position of player is :" + "  " + Current_Position);
                    break;
            
            }
        }
    }
}
