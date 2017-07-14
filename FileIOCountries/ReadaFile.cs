using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOCountries
{
    class ReadaFile
    {
        //ic bool output { get; internal set; }

        public void ReadFile(string input)
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
    }
}
