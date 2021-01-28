using System;
using System.Collections.Generic;
using System.Text;

namespace MovieObjects
{
    class Movie
    {
        public string Name { get; set; }
        public string Genre { get; set; }


            public Movie(string Name, string Genre)
            {
            this.Name = Name;
            this.Genre = Genre;
            }
    }

}
