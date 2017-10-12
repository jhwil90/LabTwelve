using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rock, Paper, Scissors game!");
            Console.WriteLine("Whats your name?");
            string name = Console.ReadLine();

            

            RockJets Opponent1 = new RockJets();
            HumanOpp Human = new HumanOpp();
            RandomSharks Opponent2 = new RandomSharks();


            string Player1 = Opponent1.generateRoshambo();
            string Player2 = Opponent2.generateRoshambo();
            string Player3 = Human.generateRoshambo();


            Console.WriteLine("Rock, paper, or scissors? (R/P/S):");
            Console.ReadLine();

            //insert arguments for winner 
            if (Player3 == Player1 || Player3 == Player2 || Player1 == Player2)
            {
                Console.WriteLine("It's a tie!");
            }

            else if (Player3 == "Rock" && Player2 == "Scissors" || Player3 == "Rock" && Player1 == "Scissors" || Player3 == "Scissors" && Player2 == "Paper" || Player3 == "Scissors" && Player1 == "Paper")
            {
                Console.WriteLine("You win!");
            }

            else if (Player2 == "Rock" && Player3 == "Scissors" || Player2 == "Rock" && Player1 == "Scissors" || Player2 == "Scissors" && Player3 == "Paper" || Player2 == "Scissors" && Player1 == "Paper")
            {
                Console.WriteLine("Player two wins!");
            }

            else if (Player1 == "Rock" && Player2 == "Scissors" || Player1 == "Rock" && Player3 == "Scissors" || Player1 == "Scissors" && Player2 == "Paper" || Player1 == "Scissors" && Player3 == "Paper")
            {
                Console.WriteLine("Player three wins!");
            }
            string userChoice = Console.ReadLine();
            Console.WriteLine("Would you like to play again? Y or N?");
            Console.ReadLine();
            if (userChoice == "Y")
            {
                Console.WriteLine("Rock, paper, or scissors? (R/P/S):");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Thanks for playing!");

            }
           
        }
        
}
    
}
            

            
            
            






