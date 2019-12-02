using System;
using System.Collections.Generic;

namespace GoFish
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CardGame cardGame = new CardGame();
            cardGame.Playgame(cardGame);

        }
    }
}