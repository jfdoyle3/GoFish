using System;

namespace GoFish
{
    public class Card
    {
        public int Value;
        public int Suit;
        private string faceDown = "##";
        private string[] Suits = { "S", "H", "C", "D" };
        private string[] royalFace = { "J", "Q", "K", "A"};
        private string[] joker = { "j1", "j2" };
        // public bool Ace;
        //public int Ace;


        // Need to add in J Q K A , replacing 11,12,13,14 or 11 (Ace) : All Faces are 10
        // Ace to be a Bool method True for High / False for Low :  either 
        // Need to add Jokers (J1 and J2)

        public Card()
        {
            Random newCard = new Random();
            Random newSuit = new Random();
            this.Value = newCard.Next(2, 15);
            this.Suit = newSuit.Next(0, 4);
        }
        public Card(int Value, int Suit)
        {
            this.Value = Value;
            this.Suit = Suit;
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


    }
}
