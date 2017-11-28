using ClassCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Player
    {
        public string PlayerName { get; private set; }
        public Cards PlayerHand { get; private set; }

        /// <summary>Constructor</summary>
        public Player(string name)
        {
            PlayerName = name;
            PlayerHand = new Cards();
        }

    } // end class Player
} // namespace 
