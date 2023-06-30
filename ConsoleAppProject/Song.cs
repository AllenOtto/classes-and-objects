using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject
{
    internal class Song
    {
        public string name;
        public string artist;
        public int duration;
        private string comment;

        public Song(string aName, string aArtist, int aDuration, string aComment ) {
            name = aName;
            artist = aArtist;
            duration = aDuration;
            Comment = aComment;
        }

        public string Comment { 
            get { return comment; }
            set { 
                if(value.Length < 20)
                {
                    comment = value;
                } else
                {
                    comment = "Niet comment";
                }
            }
        }
    }
}
