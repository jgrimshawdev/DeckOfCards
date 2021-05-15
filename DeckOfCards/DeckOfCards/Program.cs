using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Card card = new Card();

            deck.Shuffle();

            if (deck.IsValid())
            {
                for (int i = 0; i <= 52; i++)
                {
                    card = deck.DealOneCard();
                    
                    Console.WriteLine(card.Display());
                }
            }
        }
    }
}
