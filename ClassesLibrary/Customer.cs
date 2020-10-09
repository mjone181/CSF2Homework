using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Customer
    {
        //fields
        private string _customerId;
        private string _firstName;
        private string _lastName;
        private ContactInfo _contactInfo;

        //properties
        public string CustomerID
        {
            get { return _customerId; }
            set { _customerId = value; }
        }//end CustomerID

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

        public ContactInfo ContactInfo
        {
            get { return _contactInfo; }
            set { _contactInfo = value; }
        }//end ContactInfo

        //constructors
        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInfo)
        {
            CustomerID = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInfo = contactInfo;
        }//end FQCTOR

        public Customer() { }//end Customer

        //methods
        public override string ToString()
        {
            return string.Format("ID: {0}\n" +
                "First Name: {1}\n" +
                "Last Name: {2}\n" +
                "Contact Info: {3}\n", CustomerID, FirstName, LastName, ContactInfo);
        }//end ToString()

    }//end class

}//end namespace
