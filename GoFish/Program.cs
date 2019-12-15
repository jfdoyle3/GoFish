using System;
using System.Collections.Generic;
using System.Linq;

namespace GoFish
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Basic Game Run //
             CardGame cardGame = new CardGame();
             cardGame.Playgame();
            ////////////////////

           
            //List<Card> h = new List<Card>();
            //  Deck deck = new Deck();
            // var shuffled=deck.Shuffle();
            //var topCards = shuffled.Take(5);
            //Console.WriteLine("Top 5 cards");

            //foreach (var cards in topCards)
            //{
            //    Console.WriteLine("{0}{1}",cards.Value,cards.SuitSym());
            //}

            //Console.WriteLine("removing top card");
            //var topCard = shuffled[0];
            //shuffled.RemoveAt(0);
            //h.Add(topCard);


            //Console.WriteLine("Card in H is {0}{1}",h[0].Value,h[0].SuitSym());
            //Console.WriteLine("new top of deck");

            //foreach (var cards in topCards)
            //{
            //    Console.WriteLine("{0}{1}", cards.Value, cards.SuitSym());
            //}

        }
    }
}