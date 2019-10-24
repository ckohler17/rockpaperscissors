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
        Player player1;
        Player player2;
        public string numberOfPlayers;

        //constructor(Builder)
        public Game()
        {
           
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

        public void DetermineNumberOfPlayers()
        {
            Console.WriteLine("How many players will there be? '1' or '2'?");
            numberOfPlayers = Console.ReadLine();
        }
        
        public void CreatePlayers(string numberOfPlayers)
        {
           if(numberOfPlayers == "1")
            {
                Player player1 = new Human();
                Player player2 = new Computer();
            } else if (numberOfPlayers == "2") {
                Player player1 = new Human();
                Player player2 = new Human();
            }
        
            
        }
        public void DisplayPlayerNames()
        {
            Console.WriteLine(player1.name + "vs" + player2.name);
        }
        public void CompareGestures()
        {

        }
        public void DetermineRoundWinner(string gesture)
        {
            string player1gesture = player1.DetermineGesture(Player gesture);
        }
        public void DisplayWinner()
        {

        }


    }
}



//Display Rules
//Choose 1 or 2 players
//    Choose player names
//    choose a gesture
//    compare gestures
//    determine round winner
//    score goes up
//    check for best 2 out of 3
//    display winner
//    play again?
