using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJN_GrandCircusJune2017
{
    class Hash_List_Collection
    {
        static void Main(string[] args)
        {
            {
                //Title of the program
                Console.WriteLine("Welcome to our C# Class.");
            }
            //Continue loop
            bool run = true;
            while (run == true)
            {
                //Asking user to pick an 'input' value of specific names.  
                //If more time would make the names a string array to show a list not a comma seperated sentence.
                Console.WriteLine("Let's learn a fun fact about these people in our class. Pick a name:");
                string input = int.Parse((Console.ReadLine());
                //Pass a name to the input 

                //Hashtable cTable = new Hashtable(input);
                //cTable.Add(100, "Jillane", "Rockford", "Sushi");
                //cTable.Add(101, "Stephanie", "Highland", "Seafood");
                //cTable.Add(102, "Christopher", "Cincinatti", "Tofu");
                //cTable.Add(103, "Tori", "Marne", "Chocolate");
                //cTable.Add(104, "Ryan", "Illinois", "BBQ");
                //cTable.Add(100, "Jillane");
                //cTable.Add(101, "Stephanie");
                //cTable.Add(102, "Christopher");
                //cTable.Add(103, "Tori");
                //cTable.Add(104, "Ryan");

                Classmate name1 = new Classmate()
                {
                    ID = 100,
                    Name = "Jillane",
                    City = "Rockford",
                    Food = "Sushi"
                };
                Classmate name2= new Classmate()
                {
                    ID = 101,
                    Name = "Stephanie",
                    City = "Highland",
                    Food = "Seafood"
                };
                Classmate name3 = new Classmate()
                {
                    ID = 102,
                    Name = "Christopher",
                    City = "Cincinatti",
                    Food = "Tofu"
                };
                Classmate name4 = new Classmate()
                {
                    ID = 103,
                    Name = "Tori",
                    City = "Marne",
                    Food = "Chocolate"
                };
                Classmate name5 = new Classmate()
                {
                    ID = 104,
                    Name = "Ryan",
                    City = "Illinois",
                    Food = "BBQ"
                };

                Dictionary<int, Classmate> dictionaryClassmate = new Dictionary<int, Classmate>(input)
                {
                    { name1.ID, name1 },
                    { name2.ID, name2 },
                    { name3.ID, name3 },
                    { name4.ID, name4 },
                    { name5.ID, name5 }
                };
                Classmate match = Classmate.Find((Classmate n) => { return n.ID = input; });
                //foreach (KeyValuePair<int, Classmate> nameKeyValuePair in dictionaryClassmate)
                //{
                //    Classmate name = nameKeyValuePair;
                //    Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", name.ID, name.Name, name.City, name.Food);
                //}
                //Continue loop
                run = Continue();
            }

        }
        public class Classmate
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
            public string Food { get; set; }

            internal static Classmate Find(Func<Classmate, bool> p)
            {
                throw new NotImplementedException();
            }
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
