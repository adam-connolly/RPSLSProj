using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        public override void ChooseGesture()
        {
            Random randomGesture = new Random();
            int randomChoice = randomGesture.Next(gestures.Count);
            choice = gestures[randomChoice - 1];
        }
        public override void SetName()
        {
            name = "Computer";
        }
    }
}
