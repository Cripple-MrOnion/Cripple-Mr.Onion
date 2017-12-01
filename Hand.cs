using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCards
{
    public class Hand
    {
        
        public Hand(int [] hand)
        {
            
            for (int i = 0 ; i<10; i++)
            {
                


            }


          




        }

        //Bagel, two cards with values totalling 20
        public int bagel(int[] hand)
        {

            for (int i = 0; i<10; i++)
                for (int x = i+1; x < 10; x++)
                {
                    if (hand[i] + hand[x] == 20)
                        return 1;

                }
            return 0; 



        }//end bagal

        //Two-card Onion, two cards with values totalling 21
        public int two_card_onion(String []hand)
        {

            for (int i = 0; i < 10; i++)
                for (int x = i + 1; x < 10; x++)
                {
                    if (hand[i] == "Ace" && hand[x] == "Ten" || hand[x] == "Jack" || hand[x] == "Queen" || hand[x] == "King")
                        return 2;
                    else if (hand[i] == "Ten" || hand[i] == "Jack" || hand[i] == "Queen" || hand[i] == "King" && hand[x] == "Ace")
                        return 2;
                }
            return 0;

        }//end two_card_onion

        public int broken_flush(int []num, String[] suit)
        {



        }

        //Three-card Onion, three cards with values totalling 21
        public int three_card_onion(int[] hand)
        {
            for (int i = 0; i < 10; i++)
                for (int x = i + 1; x < 10; x++)
                   for (int k = x+1; k < 10; k++)
                    {
                        if(hand[i]+hand)



                    }
            return 0;


        }





    }
}
