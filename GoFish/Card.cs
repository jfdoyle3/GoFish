using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;

namespace GoFish
{
    public class Card
    {
        public int Value;
        public int Suit;
        private string faceDown = "##";
        private string[] Suits = { "S", "H", "C", "D" };
       // private string[] royalFace = { "J", "Q", "K"};
        private object[] joker = { "j1", "j2",15,16 };
        private object[] ace = { "A", 1, 11, 14 };
        private Dictionary<int, string> royalFace = new Dictionary<int, string>()
        {
            {11,"J"},
            {12,"Q"},
            {13,"K"}
        };

        public Card()
        {
            Random newCard = new Random();
            Random newSuit = new Random();
            this.Value =newCard.Next(2, 14);
            this.Suit = newSuit.Next(0, 4);
            Display(this.Value);
        }
        public Card(int Value, int Suit)
        {
            this.Value = Value;
            this.Suit = Suit;
            Display(this.Value);
        }
        public string SuitSym()
        {
            return this.Suits[this.Suit];
        }
        public string FaceDown()
        {
            return this.faceDown;
        }
        public string RoyalFace(int royalValue)
        {
         return this.royalFace[royalValue];
        }
        public string Ace()
        {
            return this.ace[0].ToString();
        }
        public void Display(int value)
        {
            //string output;
           // return maps.TryGetValue(royalFace, out output) ? output : "default";
            //switch (value)
            //{
            //    case 11:
            //         Console.WriteLine("{0}{1}", this.RoyalFace(0), this.SuitSym());
            //        //return RoyalFace(0);
            //        break;
            //    case 12:
            //        Console.WriteLine("{0}{1}", this.RoyalFace(1), this.SuitSym());
            //        break;
            //    case 13:
            //        Console.WriteLine("{0}{1}", this.RoyalFace(2), this.SuitSym());
            //        break;
            //    case 14:
            //    case 1:
            //        Console.WriteLine("{0}{1}", this.Ace(), this.SuitSym());
            //        break;
            //    default:
            //        Console.WriteLine("{0}{1}", this.Value, this.SuitSym());
            //        break;
            //}
        }
    }
}