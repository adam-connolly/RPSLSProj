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
        public void DisplayGameRules()
        {
            Console.WriteLine("Rock-Paper-Scissors-Lizard-Spock GAME RULES:\n");
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n");
        }
        public void RunGame()
        {
            DisplayGameRules();
            CreatePlayers(SetNumberOfPlayers());
            player1.SetName();
            player2.SetName();
            player1.ChooseGesture();
            player2.ChooseGesture();
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
    }
}
