using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Card
    {
        public int CardValue { get; }
        public string CardSuit { get; }

        public Card()
        {
            CardValue = 0;
            CardSuit = "None";
        }
        
        public Card(int value, string suit)
        {
            if (value >= 1 && value <= 13)
                CardValue = value;
            else
                CardValue = 0;

            if (suit.Equals("clubs", StringComparison.OrdinalIgnoreCase))
                CardSuit = "Clubs";
            else if (suit.Equals("diamonds", StringComparison.OrdinalIgnoreCase))
                CardSuit = "Diamonds";
            else if (suit.Equals("hearts", StringComparison.OrdinalIgnoreCase))
                CardSuit = "Hearts";
            else if (suit.Equals("spades", StringComparison.OrdinalIgnoreCase))
                CardSuit = "Spades";
            else
                CardSuit = "None";

            if (CardValue == 0 || CardSuit == "None")
            {
                CardValue = 0;
                CardSuit = "None";
            }
        }

        public string Display()
        {
            string strValue = String.Empty;

            if (CardValue == 0)
            {
                return "No card to deal";
            }
            else
            {
                if (CardValue >= 2 && CardValue <= 10)
                    strValue = CardValue.ToString();
                else
                    switch (CardValue)
                    {
                        case 1:
                            strValue = "Ace";
                            break;
                        case 11:
                            strValue = "Jack";
                            break;
                        case 12:
                            strValue = "Queen";
                            break;
                        case 13:
                            strValue = "King";
                            break;
                    }

                return strValue + " of " + CardSuit;
            }
                
        }
    }
}
