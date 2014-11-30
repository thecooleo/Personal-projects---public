using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace crazy_8s
{
    class Program{
        public static int facecardnum;
        public static String facecardsuit;
    
        public static int[] player1 = new int[8];
        public static string[] suitp1 = new string[8];
        public static int[] player2 = new int[8];
        public static string[] suitp2 = new string[8];
        static void Main(string[] args)
        {

            //create the arrays of each suit
            int[] hearts = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int[] diamonds = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int[] clubs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int[] spade = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            //create the deck
            int[][] cards = { hearts, diamonds, clubs, spade };

            begin(cards);
            
            
            
            
            
            //read so the consol doesnt close. ghetto fix but works c:
            Console.Read();
        }

        // one of the sort methods we used in levacs class
        public static void sortcards(int[] elements,int left,int right)
        {

            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }///while

            // Recursive calls
            if (left < j)
            {
                sortcards(elements, left, j);
            }

            if (i < right)
            {
                sortcards(elements, i, right);
            }
        }


        
        

        public static void outputcards(int[] player, string[] suit)
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

        public static void begin(int[][] cards)
        {
            Console.WriteLine("ONLY PLAYER 1 LOOK AT THE SCREEN FOR NEXT 10 SECONDS!");
            dealer.handoutcards(cards, player1, suitp1);
            sortcards(player1, 0, player1.Length - 1);
            outputcards(player1, suitp1);

            Console.WriteLine("THESE ARE YOUR CARDS PLAYER 1. ");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("ONLY PLAYER 2 LOOK AT THE SCREEN FOR NEXT 10 SECONDS!");
            dealer.handoutcards(cards, player2, suitp2);
            sortcards(player2, 0, player2.Length - 1);
            outputcards(player2, suitp2);

            Console.WriteLine("THESE ARE YOUR CARDS PLAYER 2. ");
            Thread.Sleep(5000);
            Console.Clear();
        }
    }///program class
}///namespace
