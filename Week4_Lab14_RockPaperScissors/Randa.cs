using System;

namespace Week4_Lab14_RockPaperScissors
{
    class Randa : Player
    {

        public Randa()
        {
            Name = "Randa";
        }

        public override RPSEnum GenerateRPS()
        {
            Random randomNumber = new Random();
            int randaSelection = randomNumber.Next(0, 3);
            switch (randaSelection)
            {
                case 0:
                    return RPSEnum.Paper;
                case 1:
                    return RPSEnum.Rock;
                case 2:
                    return RPSEnum.Scissors;
            }
            return GenerateRPS();
        }
    }
}
