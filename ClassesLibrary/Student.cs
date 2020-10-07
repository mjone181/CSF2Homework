using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        //Create fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //Create properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }//end FirstName

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }//end LastName

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }//end ID

        public float GPA
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        //Create constructors
        public Student (string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            GPA = gpa;
        }//end Student

        public Student() { }//end Student

        //Create methods
        public override string ToString()
        {
            return string.Format("First Name: {0}\n" +
                "Last Name: {1}\n" +
                "ID: {2}\n" +
                "GPA: {3:n1}",
                FirstName, LastName, ID, GPA);
        }//end ToString()

    }//end class
}//end namespace
