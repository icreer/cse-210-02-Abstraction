
using System;

namespace Hilow
{
    /*****************************************************************************************
    Hi-Low Game
    By Isaac Creer
    CSE-210

    This is the highlow game for CSE-210. 
    The basic of the game is to guess if the next card drawn is higher or lower than the 
    previous card.
    
    *****************************************************************************************/
    /*****************************************************************************************
    The program class job is to hold the main fucntion and to get the program to the Startgame
    class.
    *****************************************************************************************/
    public class Program
    {
        
        public static void Main()
        {
            Startgame game = new Startgame();
            game.gameplay();
           
        } 

            
    }
}

    

