using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOCountries
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to the Coutries Maintenance Application");//Title of the program            
            }

            {
                Console.WriteLine("Enter 1 to see a list of countries, enter 2 to add to the list, enter 3 to exit");
                string input = Console.ReadLine();


                ReadaFile r = new ReadaFile ();
                r.ReadaFile(input);
                WriteFiles w = new WriteFiles();

            }

        }

        public static ReadaFile(string input)
        {
            if (input == "1")
            {
                string filePath = @"C:\Users\go2me\Downloads\readCountries.txt";
                StreamReader reader = new StreamReader(filePath);
                string file = reader.ReadToEnd();
                input = reader.ReadToEnd();
                //Console.WriteLine(file);

                try
                {
                    { 
                        if (reader == null)
                        {
                            Console.WriteLine("empty file");
                        }
                        else if (reader != null)
                        {
                            Console.WriteLine("The contents of the are:" + reader);
                        }
                        return;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void WriteaFile(string input)
        {
            if (input == "2")
            {
                string filePath = @"C:\Users\go2me\Downloads\readCountries.txt";
                StreamWriter writer = new StreamWriter(filePath);

                try
                {
                    writer = new StreamWriter(filePath);
                    writer.Write("France");
                    writer.WriteLine("Spain");
                    writer.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

         run = Continue(); // For a continue loop
        }
        

        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Read more files? Y/N");
            String answer = Console.ReadLine();

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Thanks! Come back another time.");
            }
            else
            {
                Console.WriteLine("Oops! What was that? Y/N?");
                run = Continue();
            }
            return run;
        }
    }
}