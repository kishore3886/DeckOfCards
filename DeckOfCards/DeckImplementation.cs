using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    internal class DeckImplementation : DeckInterface<Card>
    {
        Card card = new Card();

        public Card dealOneCard(List<Card> cards)
        {
            var random = new Random();
            int index = random.Next(0, cards.Count);
            return cards[index];
        }

        public void shuffle(List<Card> cards)
        {
            Random random = new Random();

            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
            Console.WriteLine(" \n--------------- printing shuffeld deck --------------------");
            PrintCards(cards);
        }
     
        public void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Suite + " " + card.value + " " + card.SpecialCard);
            }
        }
    }
}
