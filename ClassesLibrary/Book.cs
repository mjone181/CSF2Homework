using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //fields
        private string _title;
        private string _author;
        private int _numberOfPages;

        //properties
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }//end Title

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }//end Author

        public int NumberOfPages
        {
            get { return _numberOfPages; }
            set { _numberOfPages = value; }
        }//end NumberOfPages

        //constructors
        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }//end FQCTOR

        public Book() { }//end Book

        //methods
        public override string ToString()
        {
            return string.Format($"Title: {Title}\nAuthor: {Author}\nNumber of Pages: {NumberOfPages:n0}");
            return Title;
        }//end ToString()

        

    }//end class

}//end namespace
