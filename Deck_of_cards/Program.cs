using System;

namespace Deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck fresh = new Deck();
            foreach (var card in fresh.Cards)
            {
                Console.WriteLine(card.StringVal + " of " + card.Suit + " : " + card.Val);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
