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
        //this is your main method, in c# you dont have to specify public, it is deafualt
        static void Main(string[] args)
        {
            Console.WriteLine("this is how you print a line in c#");
            //System.out.println("this is how you print a line in java");
            

            int f = Convert.ToInt32(Console.ReadLine());
            //how to gain input from the user
            //if you were gaining input for a String, you would not have to convert. if it was a double, do Convert.toDouble instead            
            // Convert.toInt32 changes the input from String to integer value.
            //Consol.ReadLine() grabs String input from the user, dont type .read or you will get a binary equvilant to what they type in 
            
            
            bool z = (3 > 2);
            //in java this would be boolean z = (2>3);
            // booleans are bools in c#. Deal with it. (this is the same as saying flase, 3>2 is evaluated as false and therefore false is assigned to the bool. this only works because of the brackets);
            // would this be evaluated true or false? : 
            
            if (4 > 5)
            {
                //code that happens if evaluated as true
                // would this code run? : 
            }
            else if (4 < 5)
            {
                // code that happens if this condition is true, cannot run if anything in this if statement before it is evaluated as true because the rest of the statement is skipped over
                // would this code run? : 
            }
            else
            {
                // what happens if none of the conditions (in this if structure)are evaluted as true
                // would the program get to this code? : 
            }


            // i++ is the same as : i=i+1;
            for (int i = 0; i < 5; i++)
            {
                // this loop basically runs as long as the second condition is true(i<5)
                // loop runs through once, when i=0, then everytime it runs through whatever you set to happen in the third statement will happen (i++)
                // int i = 0 is just creating a variable to use to loop though, i could create the variable elsewhere and exclude this bit of code
                // So if i had this exact loop and instead of these comments wrote Consol.WriteLine("hi!!!!!") the loop will run 5 times
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
            // ignore static it doesnt matter to you and wont for a while
            // by typing the code above, i have moved the code over to a new method. I have named this method Method; veiw this as one of those books that says "turn to page 53 for the rest of the story". this is what you are telling the computer
            // void is the return type. when this method is done running it will return to the Main method, void means do not return anything and just continue off where you left off, you can return any data type (if you had a method called calcAvg you could send it numbers to average and have it return the value to the main method, the value is set to whatever variable you set it to when you call it, for example: double avg = calcAvg(num1,num2,num3)) (i created a method that will do this below so you can get an idea )
            //  this code is outside of the {} for the main method, but still inside the class "Program"
            // (int recivedVariable) is a paramater, its a value for a variable sent from another method, if you look at the call, the arguements (six) was being sent. you cannot acceess variables from main from here, you have to send them like this (for all intents and purposes)
            int[] bob = new int[4];
            // this is an array, it can hold as many values as you want, as you can see, i set this ones extent to 4
            bob[0] = 5;
            // this is how you set one of the values in the array, the index positions start at 0 and count up untill you reach the extent, meaning this one would have bob[0] to bob[3]... extents are number of total slots not the ending position so sinse it starts at 0 sinse its 4 long its got 0,1,2,3
            int[] bob2 = { 2, 3, 3, 2, 1, 2, 3, 1, 1 };
            // you can also make one this way, this extent is set to the amount of numbers in the "{}" and each value is seperated by a comma.  
            String[] IPs = { "192.168.0.1","192.168.0.2"};
            //example of when this would be usefull.

        }
    }
}
