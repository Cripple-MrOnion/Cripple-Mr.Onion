using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCards
{
    class Cards : CollectionBase
    {
        public void Add(Card nCard)
        {
            List.Add(nCard);
        }

        public void Remove(Card oCard)
        {
            List.Remove(oCard);
        }

        public Card this[int cIndex]
        {
            get
            {
                return (Card)List[cIndex];
            }

            set
            {
                List[cIndex] = value;
            }


        }

        public void CopyTo(Cards initialCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                initialCards[index] = this[index];
            }

        }


    } //  end class Cards
}
