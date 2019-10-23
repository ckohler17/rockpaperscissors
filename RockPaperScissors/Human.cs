using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Player
    {
        //member variables(Has A)

        //constructor(Builder)
        public Human()
        {
            
        }

        //member methods(Can Do)

        public override void DetermineGesture()
        {
            Console.WriteLine("Please enter either 'rock' 'paper' 'scissors' 'lizard' or 'spock'");
            public string gesture = Console.ReadLine();
        }

    }
}
