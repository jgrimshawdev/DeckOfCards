using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Deck
    {
        private List<Card> DeckOfCards = new List<Card>();

        public Deck()
        {
            InitializeDeck();
        }

        void InitializeDeck()
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            DeckOfCards.Clear();

            for (int i = 0; i <= 3; i++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    Card newCard = new Card(value, suits[i]);
                    DeckOfCards.Add(newCard);
                }
            }
        }

        public void Shuffle()
        {
            InitializeDeck();
            
            Random rand = new Random();

            for (int currentLoc = 0; currentLoc < DeckOfCards.Count; currentLoc++)
            {
                SwapCards(currentLoc, rand.Next(0, 51));
            }
        }

        private void SwapCards(int currentLoc, int newLoc)
        {
            Card tempCard = new Card(DeckOfCards[newLoc].CardValue, DeckOfCards[newLoc].CardSuit);

            DeckOfCards[newLoc] = DeckOfCards[currentLoc];
            DeckOfCards[currentLoc] = tempCard;
        }

        public Card DealOneCard()
        {
            if (DeckOfCards.Count > 0)
            {
                Card card = new Card(DeckOfCards[0].CardValue, DeckOfCards[0].CardSuit);

                DeckOfCards.RemoveAt(0);

                return card;
            }
            else
            {
                Card card = new Card();

                return card;
            }
        }

        public bool IsValid()
        {
            foreach (Card card in DeckOfCards)
            {
                if (card.CardValue == 0)
                    return false;
            }

            return true;
        }
    }
}
