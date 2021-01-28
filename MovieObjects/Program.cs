using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MovieObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;

            while (again == true)
            {
                Movie a = new Movie("The Matrix", "scifi");

                List<Movie> movies = new List<Movie>();
                movies.Add(a);
                movies.Add(new Movie("Sicario", "drama"));
                movies.Add(new Movie("The Ritual", "horror"));
                movies.Add(new Movie("The Sound of Metal", "drama"));
                movies.Add(new Movie("2001: A Space Odyssey", "scifi"));
                movies.Add(new Movie("True Grit", "drama"));
                movies.Add(new Movie("Oculus", "horror"));
                movies.Add(new Movie("Soul", "animated"));
                movies.Add(new Movie("My Neighbor Totoro", "animated"));
                movies.Add(new Movie("Hereditary", "horror"));
                var movieList = movies.OrderBy(x => x.Name);
                Console.WriteLine("What genre of movie would you like to see? Please enter 'horror','drama,' 'animated,' or 'scifi'.");
                string input = Console.ReadLine();

                foreach (Movie m in movieList)
                {
                    if (input == m.Genre)

                    {
                        Console.WriteLine(m.Name);
                    }
                }
                again = GoAgain();
                if (again != true)
                {
                    Console.WriteLine("Enjoy your movie!");
                }
                static bool GoAgain()
                {
                    Console.WriteLine("Pick another genre? Y/N");
                    string response = Console.ReadLine();
                    string r = response.ToLower();
                    if (r == "y")
                    {
                        return true;
                    }
                    else if (r == "n")
                    {
                        return false;

                    }
                    else
                    {
                        Console.WriteLine("Sorry- I don't understand. Please try again.");
                        return GoAgain();
                    }
                }
            }
        }
    }
}

                    
                

            





        
    







