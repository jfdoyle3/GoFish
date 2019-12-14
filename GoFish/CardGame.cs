// Class is doing shuffling deck , dealing cards, number of players, keeping score.
using System;
using System.Collections.Generic;

namespace GoFish
{
    public class CardGame
    {
        public List<List<Card>> hands = new List<List<Card>>();
        private Deck deck = new Deck();
        public List<Card> shuffled;

        public CardGame()
        {
            this.shuffled = deck.Shuffle();
        }

        public List<List<Card>> Deal(int players, int hand)
        {
            for (int plyr = 0; plyr < players; plyr++)
            {
                List<Card> cDealt = new List<Card>();

                for (int crd = 0; crd < hand; crd++)
                {
                    cDealt.Add(shuffled[crd]);
                    shuffled.Remove(shuffled[crd]);
                }
                hands.Add(cDealt);
            }

            return hands;
        }

        public void Playgame()
        {
            List<List<Card>> hands = Deal(2, 5);
            // int rounds = 5;
            Console.WriteLine("Player 1 Turn");
            Console.ReadKey();
            int state = 0;
            int player = 0;
            CardDisplay(player,state);
            Console.WriteLine();

        }
        public void CardDisplay(int player, int state)
        {
            Console.Clear();
         
                Console.Write("Player {0}: ", player + 1);
                for (int plHands = 0; plHands < hands[player].Count; plHands++)
                {
                  if (state==0)
                    Console.Write("{0} ", hands[0][plHands].FaceDown());
                  else
                    Console.Write("{0}{1} ", hands[0][plHands].Value, hands[0][plHands].SuitSym());
                }

        }
    }
}