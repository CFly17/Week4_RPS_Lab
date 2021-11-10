using System;
using System.Collections.Generic;
using System.Text;

namespace Week4_Lab14_RockPaperScissors
{
    class RPSApp
    {
        //the second 'UserPlayer' initializes it
        public UserPlayer Player { get; set; } = new UserPlayer();

        //We leave this property blank since we want the user to select who they play against
        public Player Opponent { get; set; }

        public RPSApp()
        {
            //Later on, we can replace this line with code that allows us to choose Randa or Rocky
            Player = new UserPlayer();
            Opponent = new Rocky();
        }
    }
}
