using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Roshambo : PlayerUser //store three (3) values for rock (r), paper, scissors
    {
        public string userChoice;
        public string rock;
        public string paper;
        public string scissors;
        public string computerAnswer;
        //It's now 12 a.m. and I need to put this down.  Too many constructurs here, maybe
        public Roshambo(string computerAnswer, string userChoice, string rock, string paper, string scissors)
        {
            //ack! This vs base? 
        }

        public virtual string PlayGame(string userChoice)
        {
            if (userChoice == "R" && computerAnswer == "R" || userChoice == "S" && computerAnswer == "S" || userChoice == "P" && computerAnswer == "P")
            {
                return "Tie";
            }
            else if (userChoice == "R" && computerAnswer == "S" || userChoice == "S" && computerAnswer == "P" || userChoice == "P" && computerAnswer == "R")
            {
                return "You win!";
            }
            else if (computerAnswer == "R" && userChoice == "S" || computerAnswer == "S" && userChoice == "P" || computerAnswer == "P" && userChoice == "R")
            {
                return "Computer wins!";
            }
        }


    }
}
