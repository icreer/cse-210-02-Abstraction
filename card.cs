using System;

namespace Hilow
{
    /*************************************************************
    This is the Card class. This class deals with any realed to 
    the cards. There are 3 fucntion:
    Drawcard - just draws a card
    Displaycardstart - Just  displays the informaiton of card1
    Displaycard2 - Just displays the information of card2
    *************************************************************/
    public class Card
    {
        public int _value;
        public int Drawcard()
        {
           Random newnumber = new Random();
           _value = newnumber.Next(1,14);
           return _value;
            
        }
        public void Displaycardstart(int card1)
        {
            Console.WriteLine($"The card is : {card1}");
            
        }
        public void Displaycard2(int card2)
        {
            Console.WriteLine($"Next card was:{card2}");
        }
         
    }

}