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

            //create the arrays of each suit
            int[] hearts = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            int[] diamonds = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            int[] clubs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            int[] spade = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            //create the deck
            int[][] cards = { hearts, diamonds, clubs, spade };

            //calls methods to get adn output the players hand. send which array you want to modify, they are global arrays.
            handoutcards(cards, player2, suitp2);
            sortcards(player2);
            outputcards(player2, suitp2);


            handoutcards(cards, player1, suitp1);
            sortcards(player1);
            outputcards(player1, suitp1);

            //read so the consol doesnt close. ghetto fix but works c:
            Console.Read();
        }

        // one of the sort methods we used in levacs class
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


        //
        private static void handoutcards(int[][] cards, int[] player, string[] suit)
        {

            Random random = new Random();
            for (int i = 0; i < player.Length; i++)
            {

                //create two random intigers storing them in variables
                int temp = random.Next(4);
                int temp2 = random.Next(13);

                // for use in while loop
                bool handed = false;

                //while loop where the player actually gets his card
                while (handed==false)
                {

                    // 0 is the default value for a card that has been handed out. 
                    if (!(cards[temp][temp2] == 0))
                    {

                        player[i] = cards[temp][temp2];
                        cards[temp][temp2] = 0;
                        
                        
                        // choose the suit of the card
                        if (temp == 0)
                        {
                            suit[i] = "spades";
                        }
                        else if (temp == 1)
                        {
                            suit[i] = "clubs";
                        }
                        else if (temp == 2)
                        {
                            suit[i] = "diamonds";
                        }
                        else if (temp == 3)
                        {
                            suit[i] = "hearts";
                        }

                        handed = true;
                        
                    }
                    else if (cards[temp][temp2]==0)
                    {
                        // if the card the randoms chose is used, re roll duh card. niiiiigaaaaaaaaaaaaaaaaaaaaaaaaaaaa
                        temp = random.Next(4);
                        temp2 = random.Next(13);
                        Console.WriteLine("pooooop on s stick BOIS");
                    }
                }///while loop
            }///forloop


        }///handoutcards function

        private static void outputcards(int[] player, string[] suit)
        {
            for (int i = 0; i < player1.Length; i++)
            {
                //if the card number is one, say it as ace,if its 11 its jack etc etc. 
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

        }///outputcards function
    }///program class
}///namespace
