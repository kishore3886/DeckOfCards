using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    internal class DeckImplementation : DeckInterface<Card>
    {
        static int Count = 52; 
        Tools tools = new Tools();
        Card result;
        public Card dealOneCard(List<Card> cards)
        {
            //if the deck has 52 cards then shuffle once
            if (cards.Count == 52)
            {

                cards= tools.shuffleCards(cards);
            }

            var random = new Random();
            int index = random.Next(0, cards.Count);
            result= cards[index];
            cards.RemoveAt(index);
            return result;
        }

        public void shuffle(List<Card> cards)
        {
            List<Card> list = tools.shuffleCards(cards);
            Console.WriteLine(" \n--------------- printing shuffeld deck --------------------");
            PrintCards(list);
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
