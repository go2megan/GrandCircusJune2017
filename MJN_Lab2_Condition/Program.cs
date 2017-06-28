using System;

namespace MJN_Lab2_Condition
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name; // the user's name
            int i; //the value the user enters
            string answer = "y";
            {
                Console.WriteLine("Hi! What is your name?");
                name = Console.ReadLine();
            }
            while (answer == "y")
            {
                {
                    Console.WriteLine("Hi " + name + "! Let's play a game.");
                    Console.WriteLine("Enter a number from 1 - 100 and I'll show you a trick:");
                    i = int.Parse(Console.ReadLine());
                }
                {
                    {
                        if (i % 2 != 0 && i < 60) // Odd condtions
                            Console.WriteLine(i + " is an Odd number");
                        else if (i % 2 != 0 && i >= 60) //Has errors because 64 prints odd and even
                            Console.WriteLine(i + " is an Odd number over 60");

                    }

                    {
                        if (i % 2 == 0 && i > 25) // Even conditions
                            Console.WriteLine(i + " is an Even number");
                        else if (i % 2 == 0 && i >= 2)
                            Console.WriteLine(i + " is and Even number between 2 and 25");
						else if (i % 2 == 0 && i <= 25)
							Console.WriteLine(i + " is and Even number between 2 and 25");

                    }

                    {
                        Console.WriteLine("Play again (y/n)?");
                        answer = Console.ReadLine();
                        //if (answer == "y")
                        //Console.WriteLine("Enter a number from 1 - 100 and I'll show you a trick:");
                        //i = int.Parse(Console.ReadLine());
                        //else (answer == "n")
                        //break;
                    }
                }
            }
        }

    }
}
