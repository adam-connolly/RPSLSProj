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
        public int ChooseGesture()
        {
            
            Console.WriteLine("Pick a gesture to play:");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine($"{i+1}. {gestures[i]}");
            }
            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                    return input;
                case "2":
                    return input;
                case "3":
                    return input;
                case "4":
                    return input;
                case "5":
                    return input;
                default:
                    Console.WriteLine("Please make another selection");
                    return ChooseGesture();
            }
        }

    }
}
