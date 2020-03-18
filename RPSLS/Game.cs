using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables
        Player player1;
        Player player2;
        //constructor
        public Game()
        {

        }
        //member methods
        public void RunGame()
        {
            DisplayGameRules();
            CreatePlayers(SetNumberOfPlayers());
            player1.SetName();
            player2.SetName();
            while(player1.score < 2 && player2.score < 2)
            {
                CompareGestures(player1.ChooseGesture(), player2.ChooseGesture());
            }
            if (player1.score == 2)
            {
                Console.WriteLine($"{player1.name} is the WINNER!");
            }
            else if (player2.score == 2)
            {
                Console.WriteLine($"{player2.name} is the WINNER!");
            }
        }




        public void DisplayGameRules()
        {
            Console.WriteLine("Rock-Paper-Scissors-Lizard-Spock GAME RULES:\n");
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n");
        }
        
        public int SetNumberOfPlayers()
        {
            Console.WriteLine("1 player or 2 player?");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            return numberOfPlayers;
        }
        public void CreatePlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if (numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
            else
            {
                player1 = new Computer();
                player2 = new Computer();
            }
        }
        public void CompareGestures(string player1Choice, string player2Choice)
        {
            if (player1Choice == player2Choice)
            {
                Console.WriteLine("This round is a tie!");
            }
            else if (player1Choice == "Rock" && (player2Choice == "Scissors" || player2Choice == "Lizard"))
            {
                Console.WriteLine($"{player1.name} wins this round!");
                player1.score++;
            }
            else if (player1Choice == "Paper" && (player2Choice == "Rock" || player2Choice == "Spock"))
            {
                Console.WriteLine($"{player1.name} wins this round!");
                player1.score++;
            }
            else if (player1Choice == "Scissors" && (player2Choice == "Paper" || player2Choice == "Lizard"))
            {
                Console.WriteLine($"{player1.name} wins this round!");
                player1.score++;
            }
            else if (player1Choice == "Lizard" && (player2Choice == "Spock" || player2Choice == "Paper"))
            {
                Console.WriteLine($"{player1.name} wins this round!");
                player1.score++;
            }
            else if (player1Choice == "Spock" && (player2Choice == "Rock" || player2Choice == "Scissors"))
            {
                Console.WriteLine($"{player1.name} wins this round!");
                player1.score++;
            }
            else
            {
                Console.WriteLine($"{player2.name} wins this round!");
                player2.score++;
            }
        }
    }
}
