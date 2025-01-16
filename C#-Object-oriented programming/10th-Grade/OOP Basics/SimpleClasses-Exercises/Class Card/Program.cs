using System;
using System.Collections.Generic;

namespace Class_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card one = new Card("A", "Spades");
            Card two = new Card("J", "Diamonds");
            Card three = new Card("Q", "Clubs");
            Card four = new Card("10", "Hearts");

            List<Card> cards = new List<Card> {one, two, three, four };
            foreach(Card card in cards)
            {
                card.Print();
            }
            
        }
    }
}
