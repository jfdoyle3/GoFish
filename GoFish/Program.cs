using System;
using System.Collections.Generic;

namespace GoFish
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           // Basic Game Run //
            CardGame cardGame = new CardGame();
            // cardGame.Playgame();
            ////////////////////

            //List<List<Card>> plyr=cardGame.Deal(2,5);

            // Console.WriteLine("{0}{1}",plyr[0][0].Value, plyr[0][0].SuitSym());



            Console.WriteLine("Input something!!");
            string input = Input.UserInput();

            Console.WriteLine(input);

        }
    }
}