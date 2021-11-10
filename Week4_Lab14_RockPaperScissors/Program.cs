using System;

namespace Week4_Lab14_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!\n");
            bool goOn = true;
            Rocky r = new Rocky();
            Randa rr = new Randa();
            UserPlayer p = new UserPlayer();
            Console.WriteLine();

            while (goOn == true)
            {
                Console.WriteLine("Who would you like to play against?\n[1] Rocky the Regular\n\tor\n[2] Randa the Ruthless");
                int userSelection = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine("You have chosen Rocky as an opponent. Prepare for battle!\n");
                        RPSEnum myResult = p.GenerateRPS();
                        Console.WriteLine($"You have chosen {myResult}.\nAnd now for your opponent...");
                        RPSEnum rockyResult = r.GenerateRPS();
                        Console.WriteLine($"Rocky chose {rockyResult}! What a surprise!");
                        BattleMethod(myResult, rockyResult);
                        Continue();
                        break;
                    case 2:
                        Console.WriteLine("You have chosen Randa as an opponent. Prepare for battle!\n");
                        RPSEnum myResult2 = p.GenerateRPS();
                        Console.WriteLine($"You have chosen {myResult2}.\nAnd now for your opponent...");
                        RPSEnum randaResult = rr.GenerateRPS();
                        Console.WriteLine($"Randa chose {randaResult}!");
                        BattleMethod(myResult2, randaResult);
                        Continue();
                        break;
                    default:
                        Console.WriteLine("Try 1 or 2.");
                        break;
                }
            }
            //Continue method
            goOn = Continue();

        }

        public static void BattleMethod(RPSEnum player1, RPSEnum player2)
        {
            if (player1 == player2)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((player1 == RPSEnum.Rock && player2 == RPSEnum.Scissors) ||
                    (player1 == RPSEnum.Scissors && player2 == RPSEnum.Paper) ||
                    (player1 == RPSEnum.Paper && player2 == RPSEnum.Rock))
            {
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Would you like to go against another player? [y]es/[n]o");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "y" || userAnswer == "yes")
            {
                return true;
            }
            else if (userAnswer == "n" || userAnswer == "no")
            {
                Console.WriteLine($"No problem. Enjoy the rest of your day!");
                return false;
            }
            else
            {
                Console.WriteLine($"Sorry, '{userAnswer}' is not a valid response.");
                Console.WriteLine("Please enter 'y' to continue or 'n' to exit.");
                Continue();
            }
            return true;
        }
    }
}
