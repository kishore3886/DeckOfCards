using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCards
{
    public class Card
    {
        public Card() { }   
        public Card(int value,Suites Suite) {

            this.value = value;
            this.Suite = Suite;            
        }
        //To enumerate Suites
        public enum Suites
        {
            Hearts=0,
            Diamonds=1,
            Clubs=2,
            Spades=3
        }

        public Suites Suite { get; set; }   

        public int value { get; set; }

        // To get name for special cards
     
        public string SpecialCard { get { 
                    
                string specialName = string.Empty;

                switch (value)
                {

                    case(14):
                        specialName = "ACE";
                        break;

                    case (13):
                        specialName = "King";
                        break;

                    case (12):
                        specialName = "Queen";
                        break;

                    case (11):
                        specialName = "Jack";
                        break;
                }
            
                return specialName;
            } 
        }

    }

}
