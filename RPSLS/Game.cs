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
        int roundNumber;
        Random randomGesture;

        //constructor
        public Game()
        {
            randomGesture = new Random();
            roundNumber = 1;
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
                
                Console.WriteLine($"Round {roundNumber}\n");
                Console.WriteLine($"{player1.name}: {player1.score}\n{player2.name}: {player2.score}\n");
                CompareGestures(player1.ChooseGesture(), player2.ChooseGesture());
                roundNumber++;
            }
            Console.WriteLine($"{player1.name}: {player1.score}\n{player2.name}: {player2.score}\n");
            if (player1.score == 2)
            {
                Console.WriteLine($"{player1.name} WINS the game!");
            }
            else if (player2.score == 2)
            {
                Console.WriteLine($"{player2.name} WINS the game!");
            }
        }




        public void DisplayGameRules()
        {
            Console.WriteLine("Rock-Paper-Scissors-Lizard-Spock GAME RULES:\n");
            Console.WriteLine("Rock crushes Scissors\n" +
                "Scissors cuts Paper\n" +
                "Paper covers Rock\n" +
                "Rock crushes Lizard\n" +
                "Lizard poisons Spock\n" +
                "Spock smashes Scissors\n" +
                "Scissors decapitates Lizard\n" +
                "Lizard eats Paper\n" +
                "Paper disproves Spock\n" +
                "Spock vaporizes Rock\n");
        }
        
        public int SetNumberOfPlayers()
        {
            Console.WriteLine("1 player or 2 player?");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    int numberOfPlayers = Convert.ToInt32(userInput);
                    return numberOfPlayers;
                case "2":
                    numberOfPlayers = Convert.ToInt32(userInput);
                    return numberOfPlayers;
                default:
                    numberOfPlayers = Convert.ToInt32(userInput);
                    return numberOfPlayers;
            }
            
        }
        public void CreatePlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new Computer(randomGesture);
            }
            else if (numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
            else
            {
                player1 = new Computer(randomGesture);
                player2 = new Computer(randomGesture);
            }
        }
        public void CompareGestures(string player1Choice, string player2Choice)
        {
            if (player1Choice == player2Choice)
            {
                Console.WriteLine("This round is a tie!\n");
            }
            else if (player1Choice == "Rock" && (player2Choice == "Scissors" || player2Choice == "Lizard"))
            {
                Console.WriteLine($"{player1.name} wins this round!\n");
                player1.score++;
            }
            else if (player1Choice == "Paper" && (player2Choice == "Rock" || player2Choice == "Spock"))
            {
                Console.WriteLine($"{player1.name} wins this round!\n");
                player1.score++;
            }
            else if (player1Choice == "Scissors" && (player2Choice == "Paper" || player2Choice == "Lizard"))
            {
                Console.WriteLine($"{player1.name} wins this round!\n");
                player1.score++;
            }
            else if (player1Choice == "Lizard" && (player2Choice == "Spock" || player2Choice == "Paper"))
            {
                Console.WriteLine($"{player1.name} wins this round!\n");
                player1.score++;
            }
            else if (player1Choice == "Spock" && (player2Choice == "Rock" || player2Choice == "Scissors"))
            {
                Console.WriteLine($"{player1.name} wins this round!\n");
                player1.score++;
            }
            else
            {
                Console.WriteLine($"{player2.name} wins this round!\n");
                player2.score++;
            }
        }
    }
}
