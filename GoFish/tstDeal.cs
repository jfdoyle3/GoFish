using System;
using System.Collections.Generic;

namespace GoFish
{
    internal class tstDeal
    {
        public static void tDeal()
        {
            int players = 2;
            int hand = 4;
            List<int> cards = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<List<int>> hands = new List<List<int>>();

            for (int plyr = 0; plyr < players; plyr++)
            {
                List<int> crdDealt = new List<int>();

                for (int crd = 0; crd < hand; crd++)
                {
                    crdDealt.Add(cards[crd]);
                    cards.Remove(cards[crd]);
                }
                hands.Add(crdDealt);
            }
            for (int player = 0; player < hands.Count; player++)
            {
                Console.Write("Player {0}: ", player);
                for (int plHands = 0; plHands < hands[player].Count; plHands++)
                {
                    Console.Write("{0},", hands[player][plHands]);
                }
                Console.WriteLine();
            }
        }
    }
}