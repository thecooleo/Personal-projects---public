using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            // promts the user for a command and grabs input
            Console.WriteLine("Enter a command: ");
            String command = Console.ReadLine();
            //create 2 strings, first is useless, second just re formats the first, couldnt get it to work without doing this. will work on making more efficiant later. :c
            String start = command.Substring(0, command.IndexOf(" ")), end = command.Substring(command.IndexOf(" ") + 1);

            // checks users command for KW
            if (start.Equals("create"))
            {
                try
                {
                    File.Create(end);
                    Console.WriteLine("You have success fully created :" + end);
                }
                catch (Exception i)
                {
                    Console.WriteLine("File already exist.");
                }

            }
            else if (start.Equals("delete"))
            {
                try
                {
                    File.Delete("C:\\Users\\brodie\\desktop\\" + end);
                    Console.WriteLine("File succefully delteted: " + end);
                }
                catch (Exception zzz)
                {
                    Console.WriteLine("Exception: " + zzz);
                }

            }




            Console.Read();
        }
    }
}
