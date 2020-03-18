using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        public override string ChooseGesture()
        {
            //choice = "Lizard";
            Random randomGesture = new Random();
            int randomChoice = randomGesture.Next(1, 6);
            choice = Convert.ToString(gestures[randomChoice - 1]);
            return choice;
        }
        public override void SetName()
        {
            name = "Computer";
        }
    }
}
