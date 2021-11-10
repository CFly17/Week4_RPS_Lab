using System;
using System.Collections.Generic;
using System.Text;

namespace Week4_Lab14_RockPaperScissors
{
    class Rocky : Player
    {
        
        public Rocky()
        {
            Name = "Rocky";
        }
        public override RPSEnum GenerateRPS()
        {
            return RPSEnum.Rock;
        }
    }
}
