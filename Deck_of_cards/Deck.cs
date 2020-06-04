using System.Collections.Generic;
using System;

namespace Deck_of_cards
{
    public class Deck
    {
        public List<Card> cards;
        public Deck()
        {
            cards = new List<Card>();
            cards.Add(new Card("Ace","Hearts",1));
            cards.Add(new Card("2","Hearts",2));
            cards.Add(new Card("3","Hearts",3));
            cards.Add(new Card("4","Hearts",4));
            cards.Add(new Card("5","Hearts",5));
            cards.Add(new Card("6","Hearts",6));
            cards.Add(new Card("7","Hearts",7));
            cards.Add(new Card("8","Hearts",8));
            cards.Add(new Card("9","Hearts",9));
            cards.Add(new Card("10","Hearts",10));
            cards.Add(new Card("Jack","Hearts",11));
            cards.Add(new Card("Queen","Hearts",12));
            cards.Add(new Card("King","Hearts",13));
            
            cards.Add(new Card("Ace","Spades",1));
            cards.Add(new Card("2","Spades",2));
            cards.Add(new Card("3","Spades",3));
            cards.Add(new Card("4","Spades",4));
            cards.Add(new Card("5","Spades",5));
            cards.Add(new Card("6","Spades",6));
            cards.Add(new Card("7","Spades",7));
            cards.Add(new Card("8","Spades",8));
            cards.Add(new Card("9","Spades",9));
            cards.Add(new Card("10","Spades",10));
            cards.Add(new Card("Jack","Spades",11));
            cards.Add(new Card("Queen","Spades",12));
            cards.Add(new Card("King","Spades",13));
            
            cards.Add(new Card("Ace","Clubs",1));
            cards.Add(new Card("2","Clubs",2));
            cards.Add(new Card("3","Clubs",3));
            cards.Add(new Card("4","Clubs",4));
            cards.Add(new Card("5","Clubs",5));
            cards.Add(new Card("6","Clubs",6));
            cards.Add(new Card("7","Clubs",7));
            cards.Add(new Card("8","Clubs",8));
            cards.Add(new Card("9","Clubs",9));
            cards.Add(new Card("10","Clubs",10));
            cards.Add(new Card("Jack","Clubs",11));
            cards.Add(new Card("Queen","Clubs",12));
            cards.Add(new Card("King","Clubs",13));
            
            cards.Add(new Card("Ace","Diamonds",1));
            cards.Add(new Card("2","Diamonds",2));
            cards.Add(new Card("3","Diamonds",3));
            cards.Add(new Card("4","Diamonds",4));
            cards.Add(new Card("5","Diamonds",5));
            cards.Add(new Card("6","Diamonds",6));
            cards.Add(new Card("7","Diamonds",7));
            cards.Add(new Card("8","Diamonds",8));
            cards.Add(new Card("9","Diamonds",9));
            cards.Add(new Card("10","Diamonds",10));
            cards.Add(new Card("Jack","Diamonds",11));
            cards.Add(new Card("Queen","Diamonds",12));
            cards.Add(new Card("King","Diamonds",13));
        }

        public Card Deal()
        {
            Card card = this.cards[0];
            this.cards.RemoveAt(0);
            return card;
        }

        public void Reset()
        {
            cards = new List<Card>();
            cards.Add(new Card("Ace","Hearts",1));
            cards.Add(new Card("2","Hearts",2));
            cards.Add(new Card("3","Hearts",3));
            cards.Add(new Card("4","Hearts",4));
            cards.Add(new Card("5","Hearts",5));
            cards.Add(new Card("6","Hearts",6));
            cards.Add(new Card("7","Hearts",7));
            cards.Add(new Card("8","Hearts",8));
            cards.Add(new Card("9","Hearts",9));
            cards.Add(new Card("10","Hearts",10));
            cards.Add(new Card("Jack","Hearts",11));
            cards.Add(new Card("Queen","Hearts",12));
            cards.Add(new Card("King","Hearts",13));
            
            cards.Add(new Card("Ace","Spades",1));
            cards.Add(new Card("2","Spades",2));
            cards.Add(new Card("3","Spades",3));
            cards.Add(new Card("4","Spades",4));
            cards.Add(new Card("5","Spades",5));
            cards.Add(new Card("6","Spades",6));
            cards.Add(new Card("7","Spades",7));
            cards.Add(new Card("8","Spades",8));
            cards.Add(new Card("9","Spades",9));
            cards.Add(new Card("10","Spades",10));
            cards.Add(new Card("Jack","Spades",11));
            cards.Add(new Card("Queen","Spades",12));
            cards.Add(new Card("King","Spades",13));
            
            cards.Add(new Card("Ace","Clubs",1));
            cards.Add(new Card("2","Clubs",2));
            cards.Add(new Card("3","Clubs",3));
            cards.Add(new Card("4","Clubs",4));
            cards.Add(new Card("5","Clubs",5));
            cards.Add(new Card("6","Clubs",6));
            cards.Add(new Card("7","Clubs",7));
            cards.Add(new Card("8","Clubs",8));
            cards.Add(new Card("9","Clubs",9));
            cards.Add(new Card("10","Clubs",10));
            cards.Add(new Card("Jack","Clubs",11));
            cards.Add(new Card("Queen","Clubs",12));
            cards.Add(new Card("King","Clubs",13));
            
            cards.Add(new Card("Ace","Diamonds",1));
            cards.Add(new Card("2","Diamonds",2));
            cards.Add(new Card("3","Diamonds",3));
            cards.Add(new Card("4","Diamonds",4));
            cards.Add(new Card("5","Diamonds",5));
            cards.Add(new Card("6","Diamonds",6));
            cards.Add(new Card("7","Diamonds",7));
            cards.Add(new Card("8","Diamonds",8));
            cards.Add(new Card("9","Diamonds",9));
            cards.Add(new Card("10","Diamonds",10));
            cards.Add(new Card("Jack","Diamonds",11));
            cards.Add(new Card("Queen","Diamonds",12));
            cards.Add(new Card("King","Diamonds",13));                
        }

        public void Shuffle()
        {
            int rand = 0;
            Card temp = this.cards[0];
            for (int i =0;i < this.cards.Count; i++)
            {
                Random num = new Random();
                rand = num.Next(0,this.cards.Count);
                temp = this.cards[i];
                this.cards[rand] = this.cards[i];
                this.cards[i] = temp;
            }
        }

    }
}