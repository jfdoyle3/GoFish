﻿// Class is doing shuffling deck , dealing cards, number of players, keeping score.
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
            // need a Jagged List/Array to put/remove any amount of cards on the Table in any position/cell/index.
            // need a Jagged List/Array to have any amount of players from 1 - 52 / Hand amount 1 - 52 cards.

            //List<List<Card>>  outer List: Players  /  inner List: Hands

            //List A: Loop A:  Make new List B -> Loop B: Add items to List B :End Loop B -> Add ListB to List A : End Loop A
            // Need to pass card by Index to Players  ..   All players Index 0 from the deck the 1,2,3 .. etc
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

            // int handTotal = 0;
            // List<int> handTotals = new List<int>();

            for (int player = 0; player < hands.Count; player++)
            {
                Console.Write("Player {0}: ", player);
                for (int plHands = 0; plHands < hands[player].Count; plHands++)
                {
                    //Console.Write("{0}{1},", hands[player][plHands].Value, hands[player][plHands].SuitSym());
                    Console.Write("{0} ", hands[player][plHands].FaceDown(), player);
                }

                Console.WriteLine();
            }
            UserInput();
        }

        public void UserInput()
        {
            string input = Console.ReadLine();
            Console.WriteLine("You Type {0}",input);
        }
    }
}