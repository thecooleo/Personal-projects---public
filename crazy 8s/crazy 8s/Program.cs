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
        public static string[] suitp1 = new string[8];
        public static int[] player2 = new int[8];
        public static string[] suitp2 = new string[8];
        static void Main(string[] args)
        {
            
            
            int[] hearts = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            int[] diamonds = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            int[] clubs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            int[] spade = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };

            int[][] cards = { hearts, diamonds, clubs, spade };

            handoutcards(cards,player2,suitp2);


            sortcards(player2);
            
            outputcards(player2,suitp2);

        
        }

        public static void sortcards(int[] A)
        {
            for (int n = 1; n <= A.Length - 1; n++)
            {
                int temp = A[n];
                int j = n - 1;
                while (j >= 0 && A[j] > temp)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = temp;
            }
        }

        private static void handoutcards(int[][] cards,int[] player,string []suit)
        {
            Random random = new Random();
            for (int i = 0; i < player.Length; i++)
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
                            suit[i] = "hearts";
                        }
                        else if (temp == 1)
                        {
                            suit[i] = "diamonds";
                        }
                        else if (temp == 2)
                        {
                            suit[i] = "clubs";
                        }
                        else if (temp == 3)
                        {
                            suit[i] = "spades";
                        }
                        player[i] = cards[temp][temp2];
                        cards[temp][temp2] = 0;
                        handed = true;
                    }
                }
            }///forloop


        }///handoutcards function

        private static void outputcards(int[] player,string[]suit)
        {
            for (int i = 0; i < player1.Length; i++)
            {

                if (player[i] == 1)
                {
                    Console.WriteLine("ace of " + suit[i]);
                }
                else if (player[i] == 11)
                {
                    Console.WriteLine("jack of " + suit[i]);
                }
                else if (player[i] == 12)
                {
                    Console.WriteLine("queen of " + suit[i]);
                }
                else if (player[i] == 13)
                {
                    Console.WriteLine("king of " + suit[i]);
                }
                else
                {
                    Console.WriteLine(player[i] + " of " + suit[i]);
                }
            }
            Console.Read();
        }///outputcards function
    }///program class
}///namespace
