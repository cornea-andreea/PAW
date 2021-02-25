using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1052_S1
{
    class Movie
    {
        string name;
        int rating;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public override string ToString()
        {
            return "movie " + name + " has rating " + rating;
        }
    }
}
