// Class is doing shuffling deck , dealing cards, number of players, keeping score.
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
            int rounds = 2;
           // int playr = 1;
          //  Console.WriteLine("Player {0} Cards", playr);
            //Console.ReadKey();
            // Do While Loop here to find winner
            // For Loop tempt to test match and display methods
            Round(rounds);
        }

        //public void PlayerTurn()
        //{
        //    CardDisplay(player1, cardState);
        //}
        public void Round(int round)
        {
            for (int rounds = 0; rounds < round; rounds++)
            {
                for (int plr = 0; plr < hands.Count; plr++)
                {

                    CardDisplay(plr, 1);
                    dynamic turn = UserInput(plr);
                    var card1 = hands[0][0].Value;
                    var card2 = hands[1][0].Value;
                    bool cardMatch = Match(card1, card2);

                    Console.WriteLine("{0}",cardMatch);
                    

                    //Console.WriteLine("\nPick a Card to match");
                    //int cardNumber = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Pick Player to match with");
                    //int plyrMatch = Convert.ToInt32(Console.ReadLine());
                    //int chosenCard = hands[plr][cardNumber].Value;
                    //Console.WriteLine("\n\n\nchose: {0} from {1}",chosenCard,plyrMatch);
                    //Console.ReadKey();
                    // Match(chosenCard, plyrMatch);
                }
            }
        }

        public void CardDisplay(int player, int state)
        {
            // Console.Clear();

            Console.Write("Player {0}: ", player);
            for (int plHands = 0; plHands < hands[player].Count; plHands++)
            {
                if (state == 0)
                    Console.Write("{0} ", hands[player][plHands].FaceDown());
                else
                    Console.Write("{0}{1} ", hands[player][plHands].Value, hands[player][plHands].SuitSym());
            }
            Console.WriteLine();
            Console.Write("           ");
            for (int idx = 0; idx < hands[0].Count; idx++)
                Console.Write("{0}  ", idx);

            //Console.WriteLine("\n\nPlayer Hands:");

            //for (int plyrhnd=0; plyrhnd<hands.Count; plyrhnd++)
            //   Console.WriteLine("Player {0} Hand Count: {1}",plyrhnd,hands[plyrhnd].Count);
        }

        public dynamic UserInput(int plr)
        {
            Console.WriteLine("\nPick a Card to match");
            int cardNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick Player to match with");
            int plyrMatch = Convert.ToInt32(Console.ReadLine());
            int chosenCard = hands[plr][cardNumber].Value;
            int[] userInput = new int[2];
            userInput[0] = chosenCard;
            userInput[1] = plyrMatch;
            Console.WriteLine("Returning the input array");
            Console.ReadKey();
            return userInput;
        }

        // Match: Player asking card1 to player#
        public bool Match(int card1, int card2)
        {
            if (card1 == card2)
                return true;
            else
                return false;
        }
        public void DrawCard(int ply)
        {
            Card topCard = shuffled[0];
            shuffled.RemoveAt(0);
            hands[ply].Add(topCard);
        }
    }
}