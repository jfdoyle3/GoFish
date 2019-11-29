using System;

namespace GoFish
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card(11,0);
            
            switch(card.Value)
            {
                case 11:
                    Console.WriteLine("{0}{1}",card.RoyalFace(0), card.SuitSym());
                    break;
                default:
                    Console.WriteLine("{0}{1}", card.Value, card.SuitSym());
                    break;

            }
        }
    }
}
