using System.Collections.Generic;

namespace Deck_of_cards
{
    public class Deck
    {
        public List<Card> Cards;
        public Deck()
        {
            for (int i=1;i<53;i++)
            {
                string stringVal = "";
                string suit = "";
                int val = 0;

                if (i<14)
                {
                    val = i;
                    suit = "Hearts";
                }
                else if (i < 27)
                {
                    val = i-13;
                    suit = "Diamonds";
                }

                else if (i < 37)
                {
                    val = i-26;
                    suit = "Spades";
                }
                else if (i < 52)
                {
                    val = i-36;
                    suit = "Clubs";
                }
                else
                {
                    val = 13/i - 13%i;
                }

                if (val==1)
                {
                    stringVal = "Ace";
                }

                if (val==11)
                {
                    stringVal = "Jack";
                }

                if (val==12)
                {
                    stringVal = "Queen";
                }

                Card card = new Card(stringVal,suit,val);
                // Cards.Add(card);

                if (i%13==0 && i/13==1)
                {
                    set = 1;
                }

                if (i%13==0 && i/13==2)
                {
                }

                if (i%13==0 && i/13==3)
                {
                }

            }

        }


    
        // public object Deal()
        // {
        //     object card = cards[0];
        //     cards.RemoveAt(0);
        //     return card;
        // }

        // public void Reset() => cards = new List<Card>()
        //     {
        //         

        // };
    }
}