using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOCountries
{
    class Program
    {

        public static void Main(string[] args)
        {
            //bool run = true;
            //while (run == true)
            {
                Console.WriteLine("Welcome to the Coutries Maintenance Application");//Title of the program            
            }
            { 
                Console.WriteLine("Enter 1 to see a list of countries, enter 2 to add to the list, enter 3 to exit");
                string input = Console.ReadLine();
                Console.WriteLine("You entered: " +input);
            }

            ReadaFile r = new ReadaFile();
            WriteaFile w = new WriteaFile();
            Console.WriteLine(r.output);
            
        }
        

        //public static Boolean Continue()
        //{
        //    Boolean run;
        //    Console.WriteLine("Read more files? Y/N");
        //    String answer = Console.ReadLine();

        //    if ((answer == "Y") || (answer == "y"))
        //    {
        //        run = true;
        //    }
        //    else if ((answer == "N") || (answer == "n"))
        //    {
        //        run = false;
        //        Console.WriteLine("Thanks! Come back another time.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Oops! What was that? Y/N?");
        //        run = Continue();
        //    }
            ////return run;
        
    }
}