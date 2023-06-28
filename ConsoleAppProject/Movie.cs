using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    internal class Movie
    {
        public string title;
        public string leadCast;
        public string rating;

        public Movie(string aTitle, string aLeadCast, string aRating)
        {
            title = aTitle;
            leadCast = aLeadCast;
            rating = aRating;
        }
    }
}
