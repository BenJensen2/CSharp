using System;

namespace Deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck fresh = new Deck();
            Card dealt = fresh.Deal();
            Console.WriteLine(dealt.Name); // Not sure why won't print Name
            Console.WriteLine(fresh.cards.Count);
            fresh.Reset();
            Console.WriteLine(fresh.cards.Count);
            fresh.Shuffle();
            Console.WriteLine(fresh.cards[17].Name);
            fresh.Shuffle();
            Console.WriteLine(fresh.cards[17].Name);
            fresh.Shuffle();
            Console.WriteLine(fresh.cards[17].Name);
            // foreach (var card in fresh.cards)
            // {
            //     Console.WriteLine(card.Name + " of " + card.Suit + " : " + card.Val);
            // }
            Console.WriteLine("Hello World!");
        }
    }
}
