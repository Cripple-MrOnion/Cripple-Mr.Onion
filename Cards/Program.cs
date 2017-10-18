using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Card
    {
        private string face;
        private string suit;
        private string[] faces;
        private string[] suits; 
        public Card(string cardFace, string cardSuit)
        {
            face = cardFace;
            suit = cardSuit;
        }

        public override string ToString()
        {
            return face + " of " + suit;
        }

        



    }//end card object
        public class Deck
        {

            private Card[] deck; 
            private int currentCard;
            private const int num_cards = 104;
            private Random ran;


            public Deck()
            {
                string[] faces = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                                 "Nine", "Ten", "Jack", "Queen", "King" };

                string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades", "Roses", "Axes", "Tridents", "Doves" };

                deck = new Card[num_cards];
           
                currentCard = 0;
                ran = new Random();
            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(faces[count % 13], suits[count / 13]);

               



            }
            }//end Deck object







            public void Shuffle()
            {
                currentCard = 0;
                for (int first = 0; first < deck.Length; first++)
                {
                    int second = ran.Next(num_cards);
                    Card temp = deck[first];
                    deck[first] = deck[second];
                    deck[second] = temp;


               



                }

            }

            public Card Deal()
            {

           
            if (currentCard < 104)
            {
                
                return deck[currentCard++];
            }
            else
                return null;

            }


       


        public void Rank()
            {
               


            }
            



            static void Main(string[] args)
            {

                Deck deck1 = new Deck();
                //deck1.Shuffle();
                for (int i = 0; i < 104; i++)
                {
                //Console.Write(deck1.Deal());
                    Console.Write("{0,-19}", deck1.Deal());
                Console.Write("{0,-19}", );
                Console.WriteLine(deck1.currentCard);
                if ((i + 1) % 4 == 0)
                        Console.WriteLine();

                }



                Console.ReadLine();


            }//end main

        }//end deck
   // }//end card
}//end namespace
