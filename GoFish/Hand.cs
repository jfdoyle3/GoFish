using System.Collections.Generic;
using System.Linq;

namespace GoFish
{
    public class Hand : Deck
    {
        public List<Card> _Hand = new List<Card>();

        public Hand(int card)
        {
            List<Card> p1 = new List<Card>();
            // p1.Add(shuffled[card]);
        }

        public int HandTotal(List<Card> hand)
        {
            int total = hand.Sum(face => face.Value);

            return total;
        }
    }
}