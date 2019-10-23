using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player
    {
        //member variables(Has A)
        public int score;
        public string random;
        public string gesture;
        public List<string> gestures;

        //constructor(Builder)
        public Player()
        {
            score = 0;            
            gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };

        }

        //member methods(Can Do)
        public abstract void DetermineGesture();
        

    }
}
