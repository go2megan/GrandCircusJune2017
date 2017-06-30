using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJN_Day4_FactorialsForMethods
{
    class ForMethodFactorial
    {
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to the Factorial Calculator!");
            }
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Enter an integer that's greater than 0 but less than 10:");
                long input = long.Parse(Console.ReadLine());
                long total = FactorialM(input);
                Console.WriteLine("The factorial of " + input + " is " + total);
                run = Continue();
            }
            // pass input from main to the new method Factorial M, then have the method return a variable total that does the math off of input
        }
        public static long FactorialM(long input)
        {
            long total = 1;
            for (long i = 1; i <= input; i++)
            {
                total = total * i;
            }
            return total;
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

