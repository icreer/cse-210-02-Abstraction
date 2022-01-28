using System;

namespace Hilow
{
    /*************************************************************************
    This is th User Class. This class deals with any input from the user. 
    So there our 4 function in the User class:
    gamedifficalty - lets the user sellet there difficalty
    guess - deals with the user hi-low guess
    score - deals with caculating the score of the user
    displayscore - displayies the score of the user
    *************************************************************************/
    public class User
    {
        public bool userinput;
        public int playerscore;
        public void gamedifficalty()
        {
            Console.WriteLine("Please sellet your difficalt: esay[e], median(m), or hard(h)");
            string diffical = Console.ReadLine();
            if (diffical == "h" || diffical == "hard")
            {
                playerscore = 0;
            }
            else if (diffical == "m" || diffical == "median")
            {
                playerscore = 150;
            }
            else if (diffical == "e" || diffical == "esay")
            {
                playerscore = 300;
            }
            
        }
        public void guess ()
        {
            Console.Write("Higher or Lower: [h/l] ");
            string player = Console.ReadLine();
            if (player == "h")
            {
                userinput = true;
            }
            else if (player == "l")
            {
                userinput = false;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
        public int score(int card1, int card2)
        {
            if(userinput && card1<card2 || !userinput && card1 > card2)
            {
                playerscore = playerscore + 100;
            }
            else
            {
                playerscore = playerscore - 75;
                
            }
            displayscore();
            return playerscore;
        }
        public void displayscore()
        {
            Console.WriteLine($"Your score is: {playerscore}");
        }
    }
}