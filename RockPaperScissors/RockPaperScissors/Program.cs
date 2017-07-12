using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome! Let's play Rock, Paper, Scissors!");//Title of the program
            }
            bool run = true;
            while (run == true)

            {
                Console.WriteLine("Let's get introduced. Tell us your name here:");
                string inputPlayer = Console.ReadLine();
                
                Console.WriteLine("Hi " +inputPlayer+"!" + " You can play with one of two players. Pick enter an R for The Rock or B for Random Randy?");
                string choosePlayer = Console.ReadLine();

                Console.WriteLine("Great, you go first! Enter r for Rock, p for Paper, or s for Scissors.");
                string userChoice = Console.ReadLine();

                //Console.WriteLine(enter the object that defines a) the name of the person that won, and their name);
                // Having problems with the loop
                run = Continue(); // For a continue lopp

            }
            

        }

        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Shall we play again? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Thanks! Come back another time.");
            }
            else
            {
                Console.WriteLine("Oops! What was that? Y/N?");
                run = Continue();
            }
            return run;
        }
    }
}