using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class TheComputer
    {
        string computer;
        string userResponds;
        string computerPicks;
        string randy;

        public TheComputer(string computer, string userResponds, string computerPicks, string Randy)
        {
            this.computer = computer;
 
        }
        public void GetComputer(string computer)
        {
            if (computer == "A")
            {
                computer = "Rocky"; //Rock returns "r" all the time
                computerPicks = "R"; //R for Rock 
            }
            else if (computer == "B")
            {
                computer = "Randy"; //Returns random
                computerPicks = "B"; // trigger randsom response
            }

        }

        public void RandomizeComputer(string computerPicks)
        {
            if (computerPicks == "B" && userResponds == "R" || computerPicks == "B" && userResponds == "r")
            {
                string randy = "P";
            }
            else if (computerPicks == "B" && userResponds == "P" || computerPicks == "B" && userResponds == "p")
            {
                string randy = "S";
            }
            else if (computerPicks == "B" && userResponds == "S" || computerPicks == "B" && userResponds == "S")
            {
                string randy = "R";
            }
        }
    }
}
