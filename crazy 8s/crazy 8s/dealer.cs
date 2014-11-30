using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crazy_8s
{
    class dealer
    {
        public static void handoutcards(int[][] cards, int[] player, string[] suit)
        {
            int temp;
            int temp2;
            Random random = new Random();
            for (int i = 0; i < player.Length; i++)
            {

                //create two random intigers storing them in variables
                temp = random.Next(4);
                temp2 = random.Next(13);

                // for use in while loop
                bool handed = false;

                //while loop where the player actually gets his card
                while (handed == false)
                {

                    // 0 is the default value for a card that has been handed out. 
                    if (cards[temp][temp2] == 0)
                    {
                        // if the card the randoms chose is used, re roll duh card. niiiiigaaaaaaaaaaaaaaaaaaaaaaaaaaaa
                        temp = random.Next(4);
                        temp2 = random.Next(13);


                    }
                    else
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
                }///while loop
            }///forloop


        }///handoutcards function
        public static void playcard(){
            
    }
    }
}
