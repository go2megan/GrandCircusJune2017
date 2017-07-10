using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;
using ContinueOn;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application.");//Title of the program
            Console.WriteLine("There are a number of movies in our list.");//Title of the program
            Console.WriteLine("Pick from these categories: animated, drama, comedy, scifi, horror.");//Title of the program
            string category = Console.ReadLine();
        }      
        {
            List<Movie> movies = new List<Movie>();
            Movie m = new Movie("Silence of the Lambs", "horror");
            movies.Add(m);
            Movie n = new Movie("Saw", "horror");
            movies.Add(n);
            Movie o = new Movie("IT", "horror");
            movies.Add(o);
            Movie p = new Movie("Moana", "animated");
            movies.Add(p);
            Movie q = new Movie("Cars", "animated");
            movies.Add(q);
            Movie r = new Movie("Monsters, Inc.", "animated");
            movies.Add(r);
            Movie s = new Movie("A River Runs Through It", "drama");
            movies.Add(s);
            Movie t = new Movie("Hope Floats", "drama");
            movies.Add(t);
            Movie u = new Movie("Terms of Endearment", "drama");
            movies.Add(u);
            Movie v = new Movie("Office Space", "comedy");
            movies.Add(v);
            Movie w = new Movie("Wedding Crashers", "comedy");
            movies.Add(w);
            Movie x = new Movie("The Internship", "comedy");
            movies.Add(x);

            foreach (Movie cj in movies)
            {
                string cat = cj.getCategory();
                if (cat == categoryEntered)
                {
                    Console.WriteLine(cj.getTitle() + category);
                }
            //bool run = true; ---For a continue loop
            //while (run == true) ---For a continue loop

            // run = Continue();
            }
        }
    }
}
