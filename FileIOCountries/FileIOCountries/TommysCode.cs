using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FIleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Tommy\Documents\Visual Studio 2015\Projects\Code Examples\FIleIO\FIleIO\file.txt";

            StreamWriter writer;
            StreamReader reader = new StreamReader(filePath);
            string input;
            try
            {
                string line = reader.ReadToEnd();
                input = reader.ReadToEnd();
                Console.WriteLine(input);
                Console.WriteLine(line);
                while (false)
                {
                    if (line == null)
                    {
                        break;
                    }
                    if (line.Contains("good"))
                    {
                        Console.WriteLine(line);
                    }
                    else if (line.Contains("was"))
                    {
                        Console.WriteLine("Hello world");
                    }
                    //  Console.WriteLine(line); // print line
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            try
            {
                writer = new StreamWriter(filePath);
                writer.Write("Word ");
                writer.WriteLine("word 2");
                writer.WriteLine("Line");
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}