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
        private string rating;
        readonly private string[] values = { "G", "PG", "PG-13", "R", "NR" };

        public Movie(string aTitle, string aLeadCast, string aRating)
        {
            title = aTitle;
            leadCast = aLeadCast;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            
            set {
                if(values.Contains(value))
                {
                    rating = value;
                } else {
                    rating = "NR";
                }
            }
        }
    }
}
