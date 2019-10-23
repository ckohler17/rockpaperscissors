using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        //member variables(Has A)
        public string player1;
        public string player2;
        public string responseToWhoIsPlayer;

        //constructor(Builder)
        public Game()
        {
            player1 = new Player();
            player2 = new Player();
        }

        //member methods(Can Do)
        public void RunGame()
        {

        }
        public void DisplayInstructions()
        {
            Console.WriteLine("Instructions for Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("Goal is to be the last player standing. Each person chooses either Rock, Paper, Scissors, Lizard or Spock and shows what they picked at the same time.");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
        }

        public void DetermineIfPlayerIsHumanOrComputer()
        {
            Console.WriteLine("Would you like to play against the computer? Please respond 'yes' or 'no'.");
            responseToWhoIsPlayer = Console.ReadLine();
        }
        public void DetermineRoundWinner(string gesture)
        {
            string player1gesture = player1.DetermineGesture();
        }
        public void DisplayWinner()
        {

        }


    }
}
