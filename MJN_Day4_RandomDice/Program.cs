using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_RandomNum
{
    class Day4_RandomNum
    {
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to the GCC Casino!");
            }
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Let's play craps! How many sides of a dice do you want to use?");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("Roll the dice? (y/n)");
                int mathDice = DiceSides(input);//Take the sides of the dice
                int total = Random(input);//Randomize the dice and return the results for each side
                Console.WriteLine(total);
                run = Continue();
            }
            // pass input from main to the newly named method, then have the method return a variable total that does the math off of input
        }
         public static int Random(int input) // Take the input and then random it
        {
            Random rng = new Random();
            { 
            Console.WriteLine(rng.Next(1, 21));
            Console.WriteLine(rng.Next(0, 10));
            Console.WriteLine(rng.Next(0, 10));
            Console.WriteLine(rng.Next(0, 10));
            }
        } return Random;
           
        // public static int DiceSides(int input)//Do some math with the Dice sides
        //{
        //    int mathDice = input
        //    foreach (int i = 2; i <= input; i++)
        //    {
        //        total = total * i;
        //    }
        //    return mathDice;
        }
       
        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Meh. K. Bye.");
            }
            else
            {
                Console.WriteLine("What was that?");
                run = Continue();
            }
            return run;
        }
    }
}
