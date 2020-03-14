using System;
using System.Linq;

namespace GoFish
{
    public class Input
    {
        public static string UserInput()
        {
            string choice = Console.ReadLine();

            string outNum = new String(choice.Where(Char.IsDigit).ToArray());

            for (int i = 0; i < outNum.Length; i++)
            {
                Console.WriteLine("{1}. Numbers: {0}", outNum[i], i);
            }

            //  Console.WriteLine("From my Input:  {0}",resultString);
            //Console.WriteLine("\n-----------------------------\n");
            //Console.WriteLine("Roll Count: {0}", rollCount);

            return outNum;
        }
    }
}