using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJNorton_Day1Lab_Perim
{
    class PerimeterCalculator
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            float length;
            float width;

            Console.WriteLine("Enter Length:");

            length = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width:");

            width = float.Parse(Console.ReadLine());

            Console.WriteLine("Area " + (length * width));
            Console.WriteLine("Perimeter " + ((length * 2) + (width * 2)));
            Console.WriteLine("Continue? (y/n)");
            Console.ReadLine();
            
            
        }
    }
}

