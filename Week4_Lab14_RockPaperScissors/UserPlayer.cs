using System;
using System.Collections.Generic;
using System.Text;

namespace Week4_Lab14_RockPaperScissors
{
    class UserPlayer : Player
    {
        public UserPlayer()
        {
            Console.WriteLine("What's your name?");
            Name = Console.ReadLine();
        }

        //User should be able to select R, P or S
        //All else should try again
        //Since this is subclassed, we MUST fill in a value for this abstract method:
        public override RPSEnum GenerateRPS()
        {
            Console.WriteLine("Choose: [R]ock, [P]aper or [S]cissors?\nEnter a letter here:");
            string answer = Console.ReadLine().ToLower();

            switch (answer)
            {
                case "r":
                    return RPSEnum.Rock;
                case "R":
                    return RPSEnum.Rock;
                case "p":
                    return RPSEnum.Paper;
                case "P":
                    return RPSEnum.Paper;
                case "s":
                    return RPSEnum.Scissors;
                case "S":
                    return RPSEnum.Scissors;
                default:
                    Console.WriteLine("I'm sorry, try a valid response.");
                    return GenerateRPS();
            }
        }
    }
}
