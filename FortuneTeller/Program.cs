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
           string userfirstName = (Console.ReadLine());

            Console.WriteLine("Thank you! Now please enter your last name");
            string userlastName = (Console.ReadLine());

            Console.WriteLine("Great, now how old are you?");
            string userAge = (Console.ReadLine());

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
            string userSiblings = (Console.ReadLine());

            //Part two

            Console.WriteLine("What an interesting life you lead, type \"monica is the best\" for your fortune");
            string userCompliment = (Console.ReadLine().ToLower());

            // Well im giving you your fortune...I think I deserve some recognition..

            if (userCompliment == "monica is the best") 
            {
                Console.WriteLine("Thank you, now press enter");
           }

            else
            {
                Console.WriteLine("You must compliment me for your fortune!!"); 
            }




        }
    }
}
