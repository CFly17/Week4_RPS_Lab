using System;
using System.Collections.Generic;
using System.Text;

namespace Week4_Lab14_RockPaperScissors
{
    //generate RPS method
    
    abstract class Player
    {
        
        public string Name { get; set; }

        public RPSEnum RPS { get; set; }

        public abstract RPSEnum GenerateRPS();



    }
}
