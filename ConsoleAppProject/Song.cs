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
        public static int songCount = 0;

        public Song(string aName, string aArtist, int aDuration, string aComment ) {
            name = aName;
            artist = aArtist;
            duration = aDuration;
            Comment = aComment;
            songCount++;
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

        public int GetSongCount => songCount;
    }
}
