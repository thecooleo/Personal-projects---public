﻿using System;
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
            String create = command.Substring(command.IndexOf(" "), command.Length - 6), delete = create.Substring(1, create.Length - 1);

            // checks users command for KW
            if (command.Substring(0, command.IndexOf(" ")).Equals("create"))
            {
                try
                {
                    File.Create(create);
                    Console.WriteLine("You have success fully created :" + delete);
                }
                catch (Exception i)
                {
                    Console.WriteLine("File already exist.");
                }

            }
            else if (command.Substring(0, command.IndexOf(" ")).Equals("delete"))
            {
                try
                {
                    String s = "C:\\Users\\brodie\\desktop\\" + delete;
                    

                    File.Delete(s);
                    Console.WriteLine("File succefully delteted: " + delete);
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
