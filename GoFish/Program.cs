using System;

namespace GoFish
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            Console.WriteLine("{0}{1}",card.Value,card.SuitSym());
            Console.ReadKey();

        }
    }
}
