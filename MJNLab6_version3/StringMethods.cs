using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJN_GrandCircusJune2017_StringsMethods
{
    class StringsMethods
    {
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome the Pig Latin Translator!");//Title of the program
            }
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Enter a word to translate to Pig Latin:");
                //Pass the value input to the format to the split to the output pig latin
                string input = Console.ReadLine();
                string sentence = ToFormat(input);
                string word = ToSplit(sentence);
                string pigLatin = ToPigLatin(word);
                Console.WriteLine("Your word becomes " + pigLatin + " in Pig Latin.");
                run = Continue();
            }
        }
        public static string ToFormat(string input)
        {
            string [] sentence = input.ToString();
            //Had ToLower, replacedw it with ToString to try and account for punctutations and special characters. Didn't work.
        }return sentence;

        public static string ToSplit(string sentence)
        {
            string [] word = Regex.Split(sentence);
            //Try to pass each word to the Pig Lating one after the other. Theory.
        }return word;

        public static string [] ToPigLatin(string word)
        {
            string firstLetter,
                   restOfWord,
                   vowels = "AEIOUaeio";
            int currentLetter;

            foreach (string [] word) // Tried to make the word passed an array without an index # referenced here.
            {
                firstLetter = word.Substring(0, 1);
                restOfWord = word.Substring(1, word.Length - 1);
                currentLetter = vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    word = restOfWord + firstLetter + "ay"; //Should have maybe done the formatting here to accomplish the format wanted above
                }
                else
                {
                    word = word + "way";
                }
            }
            return word;
        }

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
     
    }
}
