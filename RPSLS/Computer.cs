using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        Random randomGesture;

        public Computer(Random randomGesture)
        {
            this.randomGesture = randomGesture;
        }
        public override string ChooseGesture()
        {           
            int randomChoice = randomGesture.Next(0, 5);
            choice = Convert.ToString(gestures[randomChoice]);
            return choice;
        }
        public override void SetName()
        {
            name = "Computer";
        }
    }
}
