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
        Player playerOne;
        Player playerTwo;
        //constructor
        public Game()
        {

        }
        //member methods
        public void RunGame()
        {
            Computer computer = new Computer();
            Human human = new Human();
            human.ChooseGesture();
        }
    }
}
