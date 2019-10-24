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
            DisplayInstructions();
            DetermineNumberOfPlayers();
            CreatePlayers();
            player1.ChooseName();
            player2.ChooseName();
            DisplayPlayerNames();
                while (player1.score < 2 && player2.score < 2)
                {
                    player1.DetermineGesture();
                    player2.DetermineGesture();
                    CompareGestures();
                }
            DisplayWinner();
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
            if(numberOfPlayers != "1" && numberOfPlayers != "2")
            {
                Console.WriteLine("Sorry, I do not recognize that number.");
                DetermineNumberOfPlayers();
            }
            
        }
        
        public void CreatePlayers()
        {
           if(numberOfPlayers == "1")
            {
                player1 = new Human();
                player2 = new Computer();
            } else if (numberOfPlayers == "2") {
                player1 = new Human();
                player2 = new Human();
            }
            
        
            
        }
        public void DisplayPlayerNames()
        {
            Console.WriteLine(player1.name + " vs " + player2.name);
        }
        public void CompareGestures()
        {
            if (player1.gesture == "rock" && (player2.gesture != "rock" && player2.gesture != "paper" && player2.gesture != "spock")){
                Console.WriteLine(player1.name + " wins this round!");
                player1.score++;
                
            } else if (player1.gesture == "paper" && (player2.gesture != "paper" && player2.gesture != "scissors" && player2.gesture != "lizard")){
                Console.WriteLine(player1.name + " wins this round!");
                player1.score++;
                
            } else if (player1.gesture == "scissors" && (player2.gesture != "scissors" && player2.gesture != "rock" && player2.gesture != "spock")){
                Console.WriteLine(player1.name + " wins this round!");
                player1.score++;
                
            } else if (player1.gesture == "lizard" && (player2.gesture != "lizard" && player2.gesture != "rock" && player2.gesture != "scissors")){
                Console.WriteLine(player1.name + " wins this round!");
                player1.score++;
                
            } else if (player1.gesture == "spock" && (player2.gesture != "spock" && player2.gesture != "lizard" && player2.gesture != "paper")){
                Console.WriteLine(player1.name + " wins this round!");
                player1.score++;
                
            } else if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("This round is a tie.");
            } else
            {
                Console.WriteLine(player2.name + " wins this round!");
                player2.score++;
            }
        }
       
        
    public void DisplayWinner()
        {
            if(player1.score > player2.score)
            {
                Console.WriteLine(player1.name + " is the winner!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(player2.name + " is the winner!");
                Console.ReadLine();
            }
        }


    }
}




