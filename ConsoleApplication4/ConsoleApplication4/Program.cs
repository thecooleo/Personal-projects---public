using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//package consolapplication4
namespace ConsoleApplication4
{
    //classes
    class Program
    {
        
        static void Main(string[] args)
        {
            //System.out.println("");
            Console.WriteLine("this is how you print a line in c#");

            //Scanner in = new Scanner(System.in);
            //float f = in.nextFloat();
            int f = Convert.ToInt32(Console.ReadLine());
            // Convert.toInt32 changes the input from String to integer value.
            //Consol.ReadLine() grabs String input from the user, dont type .read or you will get a binary equvilant to what they type in
            bool z = (3 > 2);
            // booleans are bools in c#. Deal with it. (this is the same as saying flase, 3>2 is evaluated as false and therefore false is assigned to the bool. this only works because of the brackets);

            if (4 > 5)
            {
                //code that happens if evaluated as true
            }
            else if (4 < 5)
            {
                // code that happens if this condition is true, cannot run if anything in this if statement before it is evaluated as true because the rest of the statement is skipped over
            }
            else { 
            // what happens if none of the conditions (in this if structure)are evaluted as true
            }


            // i++ is the same as : i=i+1;
            for (int i = 0; i < 5; i ++)
            {
                // this loop basically runs as long as the second condition is true(i<5)
                // loop runs through once, when i=0, then everytime it runs through whatever you set to happen in the third statement will happen (i++)
               // int i = 0 is just creating a variable to use to loop though, i could create the variable elsewhere and exclude this bit of code
                // So if i had this exact loop and instead of these comments wrote Consol.WriteLine()
            }


            int five = 5;
            int six = 6;
            while (six > five)
            {
                five--;
                //same as five = five -1;
                //like a for loop. will run though as long as condition is true. every time a loop is re-run through it will re-evaluate condition
            }
            Method(six);// look down a few lines for some code that says "static void Method
        }
        static void Method(int recivedVariable)
        {
            // by typing the code above, i have moved the code over to a new method. I have named this method Method;
            //  this code is outside of the {} for the main method, but still inside the class "Program"
            // (int recivedVariable) is a paramater, its a value for a variable sent from another method, if you look at the call, the arguements (six) was being sent. you cannot acceess variables from main from here, you have to send them like this (for all intents and purposes)
        }
    }
}
