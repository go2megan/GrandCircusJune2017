using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOCountries
{
    class WriteaFile
    {
        public void WriteFile(string input)
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

        }
    }
}
