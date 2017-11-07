using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.tridentQ;
            pictureBox3.Image = Properties.Resources.heart10;
            pictureBox4.Image = Properties.Resources.doveA;
            pictureBox5.Image = Properties.Resources.spade3;
            pictureBox6.Image = Properties.Resources.club5;
            pictureBox7.Image = Properties.Resources.diamond2;
            pictureBox8.Image = Properties.Resources.tridentJ;
            pictureBox9.Image = Properties.Resources.trident8;
            pictureBox10.Image = Properties.Resources.doveJ;
            pictureBox11.Image = Properties.Resources.heartA;



        }





        /*





        public class Card
        {
            private string face;
            private string suit;


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
            private string[] hface;
            private string[] hsuit;
            private int[] num;
            public Deck()
            {
                string[] faces = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                                 "Nine", "Ten", "Jack", "Queen", "King" };

                string[] suits = { "Hearts", "Clubs", "Diamonds", "Spades", "Roses", "Axes", "Tridents", "Doves" };

                deck = new Card[num_cards];
                hface = new string[num_cards];
                hsuit = new string[num_cards];
                num = new int[num_cards];
                currentCard = 0;
                ran = new Random();
                for (int count = 0; count < deck.Length; count++)
                {
                    deck[count] = new Card(faces[count % 13], suits[count / 13]);

                    hface[count] = faces[count % 13];

                    hsuit[count] = suits[count / 13];


                }//end for count




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


                    string tm = hface[first];
                    hface[first] = hface[second];
                    hface[second] = tm;

                    tm = hsuit[first];
                    hsuit[first] = hsuit[second];
                    hsuit[second] = tm;



                }//end for

            }//end Shuffle





            public Card Deal()
            {


                if (currentCard < 10)
                {

                    return deck[currentCard++];
                }//end if currentCard
                else
                    return null;

            }//end Deal






            public string DealFace()
            {


                if (currentCard < 11)
                {





                    return hface[currentCard - 1];
                }//end if currentCard
                else
                    return null;

            }//end DealFace









            public string DealSuit()
            {


                if (currentCard < 11)
                {

                    return hsuit[currentCard - 1];
                }//end if currentCard
                else
                    return null;

            }//end DealSuit




            public int Rank()
            {
                int[] num = new int[10];
                if (currentCard < 11)//turn into switch statment at some point 
                {
                    if (hface[currentCard - 1] == "Ace")
                        num[currentCard - 1] = 1;
                    if (hface[currentCard - 1] == "Two")
                        num[currentCard - 1] = 2;
                    if (hface[currentCard - 1] == "Three")
                        num[currentCard - 1] = 3;
                    if (hface[currentCard - 1] == "Four")
                        num[currentCard - 1] = 4;
                    if (hface[currentCard - 1] == "Five")
                        num[currentCard - 1] = 5;
                    if (hface[currentCard - 1] == "Six")
                        num[currentCard - 1] = 6;
                    if (hface[currentCard - 1] == "Seven")
                        num[currentCard - 1] = 7;
                    if (hface[currentCard - 1] == "Eight")
                        num[currentCard - 1] = 8;
                    if (hface[currentCard - 1] == "Nine")
                        num[currentCard - 1] = 9;
                    if (hface[currentCard - 1] == "Ten" || hface[currentCard - 1] == "Jack" || hface[currentCard - 1] == "Queen" || hface[currentCard - 1] == "King")
                        num[currentCard - 1] = 10;
                    return (num[currentCard - 1]);
                }



                else
                    return -1;




            }//end Rank
            */

            /*
            static void Main(string[] args)
            {

                Deck deck1 = new Deck();
                deck1.Shuffle();
                for (int i = 0; i < 10; i++)
                {
                    //Console.Write(deck1.Deal());
                    Console.Write("{0,-19}", deck1.Deal());
                    Console.Write("{0,-19}", deck1.DealFace());
                    Console.Write("{0,-19}", deck1.DealSuit());
                    Console.Write("{0,-19}", deck1.Rank());

                    Console.WriteLine(deck1.currentCard);

                    if ((i + 1) % 5 == 0)
                        Console.WriteLine();


                }



                Console.ReadLine();


            }







    






        }//end deck


    */


    }//end form1
}//end namespace
