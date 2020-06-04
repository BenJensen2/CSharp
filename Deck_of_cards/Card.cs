namespace Deck_of_cards
{
    public class Card
    {
        public string StringVal;
        public string Suit;
        public int Val;
        public string Name;

        public Card(string stringVal, string suit, int val)
        {
            StringVal = stringVal;
            Suit = suit;
            Val = val;
            // Name = "Monkeys";
            Name = $"{stringVal} of {suit}";

        }
    }
}