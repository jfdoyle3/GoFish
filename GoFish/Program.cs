using System;

namespace GoFish
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card(1,0);
            
            switch(card.Value)
            {

                case 11:
                    Console.WriteLine("{0}{1}",card.RoyalFace(0), card.SuitSym());
                    break;
                case 12:
                    Console.WriteLine("{0}{1}", card.RoyalFace(1), card.SuitSym());
                    break;
                case 13:
                    Console.WriteLine("{0}{1}", card.RoyalFace(2), card.SuitSym());
                    break;
                case 14:
                case 1:
                    Console.WriteLine("{0}{1}", card.Ace(), card.SuitSym());
                    break;
                
                default:
                    Console.WriteLine("{0}{1}", card.Value, card.SuitSym());
                    break;

            }
        }
    }
}
