using DeckOfCards;


BuildDeck buildDeck = new BuildDeck();
buildDeck.CreateDeck();
//print the deck
buildDeck.PrintDeck();
// Display options for user
while (true)
{
    Console.WriteLine("------------------------------Choose from options 1 or 2--------------------------------------------------");
    Console.WriteLine("Select \n1.Shuffle\n2.DealOneCard\n");

    int input;
    if (Int32.TryParse(Console.ReadLine(), out input))
    {
        switch (input)
        {
            case 1:

                buildDeck.ShuffelCards(buildDeck.cards);
                break;
            case 2:
                Card c = new Card();
                c = buildDeck.DealOneCard();
                Console.WriteLine("\n"+c.Suite + " " + c.value + " " + c.SpecialCard);
                break;

            default:
                Console.WriteLine("Invalid Input\n");
                break;
        }
    }
    else { Console.WriteLine("Invalid Input\n"); }
}

