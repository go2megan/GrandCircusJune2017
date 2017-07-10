using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueOn

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