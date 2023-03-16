using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    internal class Tools
    {


        public void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Suite + " " + card.value + " " + card.SpecialCard);
            }
        }

        public List<Card> shuffleCards(List<Card> cards)
        {
            Random random = new Random();

            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
            return cards;
        }

    }
}
