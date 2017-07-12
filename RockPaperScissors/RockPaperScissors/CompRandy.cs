using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    //The class inherits name(username or the computers name) from the abstrack PlayerUser.cs
    //This class will return the name (username) of "a" and returns Randy;
    //This class will do either a case statement of a if statement to loop and randomize a 1 and 3 chance of winning against the user, 
    //This calls randomize and return the comptuer input

    class CompRandy : PlayerUser
    {
        public string name;
        public string compName;
        private string inputPlayer;
        private string computerAnswer;

        //constructor here:
        public CompRandy(string name, string compName, string inputPlayer, string computerAnswer)
        {
            //ack! This vs base? choosePlayer
        }

        //public virtual string NamePlayers()
        //{
        //    //return name;
        //}
        //public virtual string PlayerChoice()
        //{
        //    //return choosePlayer;
        //}
        //public virtual string UserInput()
        //{
        //    //return inputUser;
        //}
        public virtual string ComputerInput()
        {
            if (choosePlayer == "B")
            {
                //somehow bring the Roshambo CS here ... Need Help
            }
            else
            {
                // figure out else statements
            }
        }

    }
}
