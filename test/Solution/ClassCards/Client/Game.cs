using ClassCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Client
{
    public class Game
    {
        private int currentCardIndex;
        private Deck playerDeck;
        private Player[] arrayPlayers;
        private Cards discardedCards;

        /// <summary>Constructor, initializes and shuffles the deck</summary>
        public Game()
        {
            currentCardIndex = 0;
            playerDeck = new Deck();
            playerDeck.Shuffle();
            discardedCards = new Cards();
        }

        /// <summary>Sets players as an array of Player objects</summary>
        public void SetPlayers(Player[] newPlayers)
        {
            arrayPlayers = newPlayers;
        }

        /// <summary>deal hands to the players </summary>
        private void Deal()
        {
            for (int i = 0; i < arrayPlayers.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arrayPlayers[i].PlayerHand.Add(playerDeck.GetCard(currentCardIndex++));
                }
            }
        } // end method Deal

        public void StartGame()
        {
            Deal();
            int currentPlayer;
            Card currentCard = playerDeck.GetCard(currentCardIndex++);


            for (currentPlayer = 0; currentPlayer < arrayPlayers.Length; currentPlayer++)
            {

                WriteLine("\n------------------------------------------------------------");
                WriteLine($"Player { currentPlayer + 1}");
                WriteLine($"{arrayPlayers[currentPlayer].PlayerName}’s Current hand: \n");

                int counter = 1;
                foreach (Card card in arrayPlayers[currentPlayer].PlayerHand)
                {
                    WriteLine($"{counter}: {card}");
                    counter++;
                }

                WriteLine();
                Write("How many cards you want to discard (0-4)? ");
                string userInput = ReadLine();
                int answer = Convert.ToInt32(userInput);

                if (answer > 0 && answer <= 4)
                {
                    Write("Choose cards to discard (1-10, Separated by Space): ");
                    string input = ReadLine();
                    string[] tokens = input.Split(' ');
                    int[] arrayChoices = Array.ConvertAll(tokens, int.Parse);
                    int choice;
                    int delta;

                    WriteLine();
                    for (int i = 0; i < arrayChoices.Length; i++)
                    {
                        int size = arrayPlayers[currentPlayer].PlayerHand.Count;
                        delta = 10 - size;

                        choice = arrayChoices[i];
                        currentCard = arrayPlayers[currentPlayer].PlayerHand[choice - delta - 1];
                        arrayPlayers[currentPlayer].PlayerHand.RemoveAt(choice - delta - 1);
                        discardedCards.Add(currentCard);

                        WriteLine($"Discarding: {currentCard}");
                    }
                    WriteLine();

                    Card newCard;
                    bool cardAvailable;

                    for (int i = 0; i < arrayChoices.Length; i++)
                    {
                        do
                        {
                            newCard = playerDeck.GetCard(currentCardIndex++);
                            cardAvailable = !discardedCards.Contains(newCard);

                            if (cardAvailable)
                            {
                                foreach (Player allPlayers in arrayPlayers)
                                {
                                    if (allPlayers.PlayerHand.Contains(newCard))
                                    {
                                        cardAvailable = false;
                                        break;
                                    }
                                }
                            }
                        } while (!cardAvailable);

                        WriteLine($"New Card: {newCard}");
                        arrayPlayers[currentPlayer].PlayerHand.Add(newCard);
                    }
                    counter = 1;
                    WriteLine("\n------------------------------------------------------------");
                    WriteLine($"Player { currentPlayer + 1}");
                    WriteLine($"{arrayPlayers[currentPlayer].PlayerName}’s New hand: \n");
                    foreach (Card card in arrayPlayers[currentPlayer].PlayerHand)
                    {
                        WriteLine($"{counter}: {card}");
                        counter++;
                    }
                }
                if (answer > 0)
                {
                    Write("\nPress any key to continue...");
                    ReadKey(true);

                }
            }
        } // end method StartGame
    } // end class Game
} // namespace ClassCards
