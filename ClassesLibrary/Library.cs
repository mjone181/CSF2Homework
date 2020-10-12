using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library 
    {
        //fields        
        private string _libraryName;
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;

        //properties
        public List<Book> Books { get; set; }//end Books

        public string LibraryName
        {
            get { return _libraryName; }
            set { _libraryName = value; }
        }//end LibraryName

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }//end StreetAddress

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }//end City

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }//end State

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }//end Zip

        //constructors
        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }//end FQCTOR

        public Library() { }//end Library

        //methods
        public override string ToString()
        {
            //Need to create a foreach to add each individual book inside the list, and display that info.
            string booksNeeded = "";

            foreach(Book b in Books)
            {
                booksNeeded += b + "\n";
            }//end foreach

            return string.Format($"List of Books: {booksNeeded} \nName: {LibraryName}\nAddress: {StreetAddress}\nCity: {City}\nState: {State}\nZip: {Zip}");

        }//end ToString()

    }//end class
}//end namespace 
