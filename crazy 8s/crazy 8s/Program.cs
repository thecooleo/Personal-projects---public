using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crazy_8s
{
    class Program
    {
        public static int[] player1 = new int[8];
        public static string[] suit = new string[8];
        public static int[] player2 = new int[8];
        static void Main(string[] args)
        {






            int[] hearts = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            int[] diamonds = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            int[] clubs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            int[] spade = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };

            int[][] cards = { hearts, diamonds, clubs, spade };

            handoutcards(cards);
            //sortcards();
            outputcards();
            //outputcardsNoEditing();
            


        }

        private static void sortcards()
        {
            for (int i = 0; i < player1.Length-1; i++)
            {
                if (player1[i+1] > player1[i])
                {
                    int temp = player1[i];
                    player1[i] = player2[i+1];
                    player1[i+1] = temp;

                }
            }
        }

        private static void outputcardsNoEditing()
        {
            for (int i = 0; i < player1.Length; i++)
            {
                Console.WriteLine(player1[i] + " of " + suit[i]);
            }
            Console.Read();
        }///outputcards with not edditing method

       

        private static void handoutcards(int[][] cards)
        {
            Random random = new Random();
            for (int i = 0; i < player1.Length; i++)
            {
                int temp = random.Next(4);
                int temp2 = random.Next(13);
                bool handed = false;

                while (!handed)
                {
                    if (cards[temp][temp2] != 0)
                    {

                        if (temp == 0)
                        {
                            suit[i] = "diamonds";
                        }
                        else if (temp == 1)
                        {
                            suit[i] = "hearts";
                        }
                        else if (temp == 2)
                        {
                            suit[i] = "clubs";
                        }
                        else if (temp == 3)
                        {
                            suit[i] = "spades";
                        }
                        player1[i] = cards[temp][temp2];
                        cards[temp][temp2] = 0;
                        handed = true;
                    }
                }
            }///forloop


        }///handoutcards function

        private static void outputcards()
        {
            for (int i = 0; i < player1.Length; i++)
            {

                if (player1[i] == 1)
                {
                    Console.WriteLine("ace of " + suit[i]);
                }else if (player1[i] == 11)
                {
                    Console.WriteLine("jack of " + suit[i]);
                }else if (player1[i] == 12)
                {
                    Console.WriteLine("queen of " + suit[i]);
                }
                else if (player1[i] == 13)
                {
                    Console.WriteLine("king of " + suit[i]);
                }
                else
                {
                    Console.WriteLine(player1[i] + " of " + suit[i]);
                }
            }
            Console.Read();
        }///outputcards function
    }///program class
}///namespace
