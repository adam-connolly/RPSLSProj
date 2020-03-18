using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        //member variables
        int input;
        //member methods
        public override void ChooseGesture()
        {

            Console.WriteLine("Pick a gesture to play:");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {gestures[i]}");
            }
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    choice = gestures[0];
                    break;
                case "2":
                    choice = gestures[1];
                    break;
                case "3":
                    choice = gestures[2];
                    break;
                case "4":
                    choice = gestures[3];
                    break;
                case "5":
                    choice = gestures[4];
                    break;
                default:
                    Console.WriteLine("That is not a valid gesture. Please select again.");
                    ChooseGesture();
                    break;
            }
        }
        public override void SetName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }
    }
}
