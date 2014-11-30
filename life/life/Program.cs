using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace life
{
    class Program
    {
        static void Main(string[] args)
        {


            bool chosen=false;
            while (!chosen)
            {


                String choice = ask();
                if (choice.Equals("Y"))
                {
                    Console.WriteLine("PRAISE GABEN!: YOU WIN INTERNET POINTS!");
                    chosen = true;
                    Console.Read();
                }
                else if (choice.Equals("N"))
                {
                    Console.WriteLine("DIE SATAN");
                    chosen = true;
                    Console.Read();
                }
                else
                {
                    Console.WriteLine("NOT A VALID OPTION FUCKER!!!!");

                }
            }
        }
        static String ask()
        {
            Console.WriteLine("Gaben is love,gaben is life: Y/N?");


            String choice = Console.ReadLine();
            
            choice = choice.ToUpper();
            return choice;
        }
    }
}
