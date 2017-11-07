using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // DISPLAY INTRODUCTION AND RULES OF THE GAMES
            WriteLine("Welcome to Cripple Mr.Onion Game\n");

            // PROMPT FOR HOW MANY PLAYERS
            Write("How many players ?  ");
            string userInput = ReadLine();
            int numPlayers = Convert.ToInt32(userInput);

            //  initialize players
            Player[] players = new Player[numPlayers];

            // PROMPT FOR EACH PLAYER NAME
            WriteLine();
            for (int i = 0; i < players.Length; i++)
            {
                Write($"Enter name for Player {i + 1 }:  ");
                string playerName = ReadLine();
                players[i] = new Player(playerName);
            }

            // START GAME 
            Game newGame = new Game();
            newGame.SetPlayers(players);
            newGame.StartGame();
        } // end method main
    } // end class Program
} // namespace CardClient 
