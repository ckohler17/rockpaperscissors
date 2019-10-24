using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Computer : Player
    {
        //member variables(Has A)

        //constructor(Builder)
        
        

        //member methods(Can Do)
        public override void DetermineGesture()
        {
            Random random = new Random();
            int index = random.Next(gestures.Count);
            Console.WriteLine(gestures[index]);
            gesture = Console.ReadLine();
        }

        public override void ChooseName()
        {
            name = "Ralph";
        }

    }

    }

