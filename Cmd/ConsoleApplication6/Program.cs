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
            // creates a variable that is the value of command up to the space, and after the space.
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
