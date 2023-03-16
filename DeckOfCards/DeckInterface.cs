using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    internal interface DeckInterface<T>
    {
        void shuffle(List<T> cards);
        T  dealOneCard(List<T> cards);

        void PrintCards(List<T> cards);
    }
}
