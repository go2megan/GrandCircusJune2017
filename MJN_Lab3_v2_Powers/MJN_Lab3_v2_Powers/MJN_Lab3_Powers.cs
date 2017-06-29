using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJN_Day3_SqCubeArrayMethod
{
    public class MJN_Day3_SqCubeArrayMethod
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Learn your squares and cubes!");            
                //do 
                {
                int x;
                Console.WriteLine("Enter an integer here to see the Square and Cubed root:");
                x = int.Parse(Console.ReadLine());
                    //x--;   -- Code Breaking Here
                    //} while (x >= 1);  -- Code Breaking Here
                    int XEqualsOne = DecrementX(x);
                int Squared = ValueSquared(x);
                int Cubed = ValueCubed(x);
                Console.Write("Number" + x + "Squared" + Squared +"Cubed" + Cubed + '\n');
            }
            run = Continue();
        }
        public static int DecrementX(int x, int y)
        {
            int XEqualsOne = ((x--)=y);
            return XEqualsOne;
        }
        public static int ValueSquared(int x)
        {
            int Squared = (x * x);
            return Squared;
        }
        public static int ValueCubed(int x)
        {
            int Cubed = ((x * x) * x);
            return Cubed;
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
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("Hmm. There was an error here it seems.");
                run = Continue();
            }
            return run;
        }
    }
}
