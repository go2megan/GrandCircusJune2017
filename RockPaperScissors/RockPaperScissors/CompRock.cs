using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    //The Rock user has computerInput of the response r or rock all the time, name of "r" and returns computer input of rock
    //The class inherits name(username or the computers name) from the abstrack PlayerUser.cs
    class CompRock : PlayerUser
    {
        public string name;
        public string compName;
        private string inputPlayer;
        private string computerAnswer;
        public string choosePlayer;
    
        //constructor here: It's 11:44 on Tuesday I entered a lot of stuff to pair down here
        public CompRock(string choosePlayer, string name, string compName, string inputPlayer, string computerAnswer)
        {
            //ack! This vs base? choosePlayer
        }
        //public virtual string NamePlayers()
        //{
        //    return "Need a name";
        //}
        //public virtual string PlayerPick()
        //{

        //    return choosePlayer;
        //}
        //public virtual string UserInput()
        //{
        //    return inputUser;
        //}
        public virtual string ComputerInput(string choosePlayer)
        {
            if (choosePlayer == "R")
            {
                return computerAnswer = "R";
            }
            else
            {
            // figure out else statements
            }
        }

    }
}
