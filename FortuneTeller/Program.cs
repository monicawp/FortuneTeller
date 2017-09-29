using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part one

            Console.WriteLine("Hello! Please enter your first name");
           string userfirstName = (Console.ReadLine().ToLower());

            Console.WriteLine("Thank you! Now please enter your last name");
            string userlastName = (Console.ReadLine().ToLower());

            Console.WriteLine("Great, now how old are you?");
            int userAge = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Interesting, now please enter your birth month as a number");
            int userbirthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Lets see, if you had to pick you favorite ROYGBIV color, what would it be?");
            Console.WriteLine("Enter \"Help\" if you do no know what ROYGBIV is");
            string userfavColor = (Console.ReadLine().ToLower());



            if ("help" == userfavColor)
            {
                Console.WriteLine("Choose from the colors, red, orange, yellow, green, blue, indigo, or violet");
                string userHelp = (Console.ReadLine().ToLower());
            }

            else
            {
                Console.WriteLine("Next question..");
                
            }

            Console.WriteLine("How many siblings do you have?");
            int userSiblings = int.Parse(Console.ReadLine());

            //Part two

            Console.WriteLine("What an interesting life you lead, type \"monica is the best\" for your fortune");
            string userCompliment = (Console.ReadLine().ToLower());

            // Well im giving you your fortune...I think I deserve some recognition..

            if (userCompliment == "monica is the best") 
            {
                Console.WriteLine("WHY THANK YOU, YOUR FORTUNE IS.....");
           }

            else
            {
                Console.WriteLine("You must compliment me for your fortune!!"); 
            }
           
            // If the age is odd or even RETIRE
            if (userAge % 2 == 0)
            {
                Console.WriteLine(userfirstName + " " + userlastName + " will retire in 50 years");
            
            }
            else
            {
                Console.WriteLine(userfirstName + " " + userlastName + " will retire in 10 years with a glorious pension!!");
            }

            //birth month MONEY
             
          














            //number of siblings

            if (userSiblings == 0)
            {
                Console.WriteLine("Your vaction will be lonley since you");
                Console.WriteLine("have no siblings.. but your get away home ");
                Console.WriteLine("will be in Miami, Florida!");
            }

            else if (userSiblings == 1)
            {
                Console.WriteLine("Your vacation home will be in the beautiful Venice, Italy");
            }

            else if (userSiblings == 2)
            {
                Console.WriteLine("Your beautiful vacation home will be on the beach in Cancun, Mexico!");
            }
            else if (userSiblings == 3)
            {
                Console.WriteLine("Your future vacation home will be in Athens, Greece!");
            }
        else if (userSiblings < 3)
            {
                Console.WriteLine("You and your many siblings will have a great time");
                Console.WriteLine("in your future home in The Bahamas!!!");
            }

            else if (userSiblings > 0 )
            {
                Console.WriteLine("You cant fool me... for lying your vacation home will be in Pittsburg, Pennsylvania.");
            }

            
        }
    }
}
