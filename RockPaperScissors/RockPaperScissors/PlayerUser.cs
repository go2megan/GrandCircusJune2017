//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RockPaperScissors
//{
//    //This class will simply define that its other children need to return a name, a userinput and computerinput
//    abstract class PlayerUser
//    {
//        //ints
//        public string userChoice;
//        public string theComputer;
//        public string aComputer;

//        //constructors
//        public PlayerUser(string userChoice, string theComputer, string aComputer)
//        {
//            this.userChoice = userChoice;
//            this.theComputer = theComputer;
//            this.aComputer = aComputer;
//        }

//        private virtual string AComputer(string aComputer)
//        {
//            if (aComputer == "r" || aComputer == "R")
//            {
//                return "Rock";
//            }
//            else if (aComputer == "b" || aComputer == "B")
//            {
//                return "Randy";
//            }
//        }

//        private virtual string UsersChoice(string userChoice)
//        {
//            if (userChoice == "R" || userChoice == "r")
//            {
//                return "R";
//            }
//            if (userChoice == "P" || userChoice == "p")
//            {
//                return "P";
//            }
//            if (userChoice == "S" || userChoice == "s")
//            {
//                return "S";
//            }

//        }

//        //public virtual string ComputersChoice(string theComputer)
//        {
//            return theComputer;
//        }

//    }
//}
