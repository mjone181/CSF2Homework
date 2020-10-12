using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Artist : Song
    {
        //fields       
        private string _title;
        private string _genre;

        //properties
        public Song[] Tracks { get; set; }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }//end Title

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }//end Genre

        //constructors
        public Artist(Song[] tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }//end FQCTOR

        //methods
        public override string ToString()
        {
            string tracksNeeded = "";

            foreach (Song s in Tracks)
            {
                tracksNeeded += s + "\n";
            }//end foreach

            return string.Format($"Tracks: {tracksNeeded} \nTitle: {Title}\nGenre: {Genre}");
        }//end ToString()

    }//end class
}//end namespace
