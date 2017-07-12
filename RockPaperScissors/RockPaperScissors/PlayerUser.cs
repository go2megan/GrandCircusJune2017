using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    //This class will simply define that its other children need to return a name, a userinput and computerinput
    abstract class PlayerUser
    {//This may need to be protected string
     // Having trouble on Abstract here with squigly brackets.  Pick up here later Wednesday

        public virtual string NamePlayers()
        {
            //return "Need a name";
        }
        public virtual string PlayerPick()
        {
            //return choosePlayer;
        }
        public virtual string UserInput()
        {
            //return inputUser;
        }
        public virtual string ComputerInput()
        {
            //return userChoice;
        }

    }
}
