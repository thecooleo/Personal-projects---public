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
            Console.WriteLine("Enter a command: ");
            String command = Console.ReadLine();
            int e = command.IndexOf(" ");
            int z = command.Length - 6;

            String create = command.Substring(e, z);

            
            if (command.Substring(0, e).Equals("create"))
            {
                try
                {
                    File.Create(create);
                    Console.WriteLine("You have success fully created :" + command.Substring(e, z));
                }
                catch (Exception i)
                {
                    Console.WriteLine("File already exist.");
                }

            }
            else if (command.Substring(0, e).Equals("delete"))
            {
                File.Delete("C:\\Users\\brodie\\desktop\\"+"fuck.txt");
            }
            
            
            
            
            Console.Read();
        }
    }
}
