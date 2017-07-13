using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsGame
{
    class TheGame
    {
        string response;
        string computer;
        string computerPicks;
        string word;
        string userResponds;
        string winStatement;

        public TheGame(string response, string computer, string computerPicks, string word, string userResponds, string winStatement)
        {
        }

        public void ResponseInWords (string response)
        {
            if (response == "R" || response == "r")
            {
                word = "Rock";
            }
            else if (response == "S" || response == "s")
            {
                word = "Scissors";
            }
            else if (response == "P" || response == "p")
            {
                word = "Paper";
            }
        }

        public void WinStatement(string userResponds, string computerPicks, string randy)
        {
            if (computerPicks == "R" && userResponds == "R" || computerPicks == "R" && userResponds == "r")
            {
                string winStatement = "Tie";
            }
            else if (computerPicks == "R" && userResponds == "S" || computerPicks == "R" && userResponds == "s")
            {
                string winStatement = "You lose!";
            }
            else if (computerPicks == "R" && userResponds == "P" || computerPicks == "R" && userResponds == "p")
            {
                string winStatement = "You win!";
            }
            if (randy == "P" && userResponds == "R" || computerPicks == "R" && userResponds == "r")
            {
                string winStatement = "You lose!";
            }
            else if (randy == "R" && userResponds == "S" || computerPicks == "R" && userResponds == "s")
            {
                string winStatement = "You lose!";
            }
            else if (randy == "S" && userResponds == "P" || computerPicks == "R" && userResponds == "p")
            {
                string winStatement = "You lose!";
            }

        }
    }
}