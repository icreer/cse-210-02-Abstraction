using System;

namespace Hilow
{
    /***********************************************************************************************
    The start game class has the job of orgnizing the card and user class.
    There two function in this class gameplay and playagain.
    Gameplay main job is contorl game play as long as the user wants to play and has a score above 0.
    ************************************************************************************************/
    public class Startgame
    {
       public bool playgame = true;
       public int card1;
       public int card2;
       public int playforfun;
       Card havefun = new Card();
       User person = new User();
       
       /******************************************************************
        The gameplay fuction calls the other fuction in other classes in 
        the order that they need to be called in. The main key part of 
        the the gameplay fuction is thw wile look that is in it. This lets
        the player play the game till either they say they don't want to play
        anymore or if there score gets to zero.
       ******************************************************************/
       public void gameplay()
       {
           person.gamedifficalty();
           card1 = havefun.Drawcard();
           while (playgame)
           {
             Console.WriteLine();
             havefun.Displaycardstart(card1); 
             person.guess();
             card2 = havefun.Drawcard();
             havefun.Displaycard2(card2);
             playagain();
             card1 = card2;
             
           }
           endgame();
       }
       /*****************************************************************
       This playagain fucntion job is to make sure that the player wants to
       play again and call the score function and check that the score is not
       zero. The key part of this funtion is a if and else if statements that
       check is a player want to keep playing and there score being grater then zero
       *****************************************************************/
       public void playagain()
       {
           playforfun = person.score(card1,card2);
           if (playforfun > 0 )
           {
                Console.Write("Play agin? [y/n]");
                string yesorno = Console.ReadLine();
                if (yesorno == "y")
                {
                    playgame = true;
                }
                else if (yesorno == "n" )
                {
                    playgame = false;
                    Console.WriteLine($"Thank Your for playing your final scrore is {playforfun}.");
                }
           }
           else
           {
               Console.WriteLine("Sorry you lost");
           }
          
       }
       /****************************************************************
       This endgame fuction is to give a player a nice messeage at the
       end of their game play.
       ****************************************************************/
       public void endgame()
       {
           Console.WriteLine("Thanks for playing my Hi-Low game");
       }

    }
}