using System;
using System.Collections.Generic;

namespace Deck_of_cards
{
    public class Player
    {
        string Name;
        public List<Card> Hand;
        public object Draw(cards)
        {
            Random num = new Random();
            int index = num.Next(0,cards.Length);
            int result = cards[index];
            return result;
        }
    }
}