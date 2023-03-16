using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    internal class BuildDeck
    {
        public List<Card> cards= new List<Card>();
        DeckImplementation DI= new DeckImplementation();
        public void CreateDeck() { 
            
            
            for(int i = 0; i < 52; i++) 
            {
                Card.Suites suite = (Card.Suites)(Math.Floor((decimal)i / 13));
                int value = i % 13 + 2;
                cards.Add(new Card(value, suite));             
            }        
        }

        //shuffels and prints the cards
        public void ShuffelCards(List<Card> cards){
            DI.shuffle(cards);
        }

        //pick a card in random and return
        public Card DealOneCard()
        {
            Card card = (Card)DI.dealOneCard(cards);
            return card;
        }

        public void PrintDeck()
        {
            Console.WriteLine(" --------------- Welcome To DeckOfCards By Kishore ----------------------");

            Console.WriteLine(" --------------- printing initial deck ----------------------");
            DI.PrintCards(cards);
        }

    }
}
