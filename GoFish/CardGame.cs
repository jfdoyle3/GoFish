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
            // int rounds = 5;
           // int playr = 1;
          //  Console.WriteLine("Player {0} Cards", playr);
            //Console.ReadKey();
            // Do While Loop here to find winner
            // For Loop tempt to test match and display methods
            Round(10);
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
                    Console.WriteLine("\n\n\nchose: {0} from {1}", turn[0], turn[1]);
                    Match(turn[0], turn[1]);

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
        public void Match(int card1, int ply)
        {
            for (int card = 0; card < hands[ply].Count; card++)
            {
                if (card1 == hands[ply][card].Value)
                {
                   // Console.WriteLine("No Match..Drawing a card from the deck and continuing.");
                    Console.WriteLine("Found a Match . removing");
                    break;
                   
                   
                }
                //else
                //{
                //    Console.WriteLine("Found a Match . removing");
                //    Console.ReadKey();
                //    hands[ply].RemoveAt(card);
                    
                //}
            }
           // DrawCard(ply);
           
        }
        public void DrawCard(int ply)
        {
            Card topCard = shuffled[0];
            shuffled.RemoveAt(0);
            hands[ply].Add(topCard);
        }
    }
}