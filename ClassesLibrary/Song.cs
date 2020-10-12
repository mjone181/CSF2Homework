using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Song
    {
        //fields
        private string _artist;
        private string _title;
        private int _lengthInSeconds;
        //properites
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }//end Artist

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }//end Title

        private int LengthInSeconds
        {
            get { return _lengthInSeconds; }
            set { _lengthInSeconds = value; }
        }//end LengthInSeconds

        //contstuctors
        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }//end FQCTOR

        public Song() { }//end Song

        //methods
        public override string ToString()
        {
            return string.Format($"Artist: {Artist}\nTitle: {Title}\nLength: {LengthInSeconds} seconds.");
        }//end ToString()

    }//end class
}//end namespace
