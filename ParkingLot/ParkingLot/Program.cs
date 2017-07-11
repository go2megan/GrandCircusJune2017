using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Program
    {
        public static void Main(string[] args)
        {
            {
                //Title of the program
                Console.WriteLine("Welcome to our Grand Circus Parking Lot");
            }
            bool run = true;
            while (run == true)
            {

                Console.WriteLine("Let's find a spot. Is your vehicle a car, truck, bus, or motorcycle?");
                string type = Console.ReadLine();
                Spot s = new Spot(type);
                s.SmallSpot(type);
                s.MediumSpot(type);
                s.LargeSpot(type);
                Places p = new Places(type);
                //p.CycleSpot();

                PrintPlaces();
                run = Continue(); // Ask the user to start over 
            }
        }

        private static void PrintPlaces()
        {
            Console.WriteLine(Places.getPlaces);

           
        }

        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Find spots again? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("See you again, soon?");
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