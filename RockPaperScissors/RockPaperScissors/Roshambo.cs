using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Roshambo //store three (3) values for rock (r), paper, scissors and return whether the user is a winner
    {
        public string userChoice;
        private string theComputer;

        public Roshambo(string userName, string userChoice, string theComputer)
        {
            this.userChoice = userChoice;
            this.theComputer = theComputer;

        }
        public string Winner(userName, theComputer)
        {
            if (userChoice == "R" && theComputer == "R" || userChoice == "S" && theComputer == "S" || userChoice == "P" && theComputer == "P")
            {
                return "Tie";
            }
            else if (userChoice == "R" && theComputer == "S" || userChoice == "S" && theComputer == "P" || userChoice == "P" && theComputer == "R")
            {
                return "You win!";
            }
            else if (theComputer == "R" && userChoice == "S" || theComputer == "S" && userChoice == "P" || theComputer == "P" && userChoice == "R")
            {
                return "Computer wins!";
            }

        }

        internal void Winner(object userChoice)
        {
            throw new NotImplementedException();
        }
    }
}
