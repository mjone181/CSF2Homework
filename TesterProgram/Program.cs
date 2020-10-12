using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;
namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //making a new Student class for testing purposes and filling its variables.
            Console.WriteLine("Student Class testing:");
            Student s1 = new Student();
            s1.FirstName = "John";
            s1.LastName = "Brown";
            s1.ID = "123456789";
            s1.GPA = 4.0f;

            //Display Student class to the screen.
            Console.WriteLine(s1);
            Console.WriteLine();

            //making a new Vehicle class for testing purposes and filling its variables.
            Console.WriteLine("Vehicle Class testing:");
            Vehicle v1 = new Vehicle();
            v1.Make = "Toyota";
            v1.Model = "Tacoma";
            v1.Year = 2008;
            v1.Weight = 3980;

            //Display Vehicle class to the screen.
            Console.WriteLine(v1);
            Console.WriteLine();

            //making a new Login class for testing purposes and filling its variables.
            Console.WriteLine("Login Class testing:");
            Login l1 = new Login();
            l1.Username = "FonzieWonzie";
            l1.Password = "Thisismypassword";

            //Display Login class to the screen.
            Console.WriteLine(l1);
            Console.WriteLine();

            //making a new ContactInfo class for testing purposes and filling its variables.
            Console.WriteLine("ContactInfo Class testing:");
            ContactInfo c1 = new ContactInfo("12680 BOIIIII Avenue", "Domino City", "Kansas", "66666", "555-1343", "bigboi@gmail.com");            

            //Display ContactInfo class to the screen.
            Console.WriteLine(c1);
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //making a new Customer class for testing purposes and filling its variables.
            Console.WriteLine("Customer Class testing:");
            Customer cu1 = new Customer("12345F", "Joe", "Brown", c1);        
            
            //Display Customer class to the screen.
            Console.WriteLine(cu1);

            //making a new CreditCardAccount class for testing purposes and filling its variables.
            Console.WriteLine("CreditCardAccount Class testing: ");
            CreditCardAccount cr1 = new CreditCardAccount(123456789, cu1, 1337000, false, 1.00m);

            //Display CreditCardAccount to the screen.
            Console.WriteLine(cr1);
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //making a new Book class for testing purposes and filling its variables.
            Console.WriteLine("Book Class testing: ");
            Book b1 = new Book("How to be POGGERS", "Kappa", 1337);

            //Display Book to the screen.
            Console.WriteLine(b1);
            Console.WriteLine();

            //making a new Library class for testing purposes and filling its variables.
            Console.WriteLine("Library Class Testing:");
            List<Book> books = new List<Book>() {b1};              
            Library li1 = new Library( books,"Generic Library", "12898 Generic St.", "Kansas City", "Kansas", "66210");

            //Display Library to the screen.
            Console.WriteLine(li1);
            Console.WriteLine();

            //making a new Song class for testing purposes and filling its variables.
            Console.WriteLine("Song Class Testing:");
            Song so1 = new Song("Jon Bovi", "Prayer on a Livin'", 251);

            //Display Song to the screen.
            Console.WriteLine(so1);
            Console.WriteLine();

            //Making a new Artist class for testing purposes and filling its variables.
            Console.WriteLine("Artist Class Testing: ");
            Song[] tracks = { so1 };
            Artist a1 = new Artist(tracks, "Jon Bovi", "Classic Rock");

            //Display Artist to the screen.
            Console.WriteLine(a1);
            Console.WriteLine();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            //Make a new MotorHome class for testing purposes and filling its variables.
            Console.WriteLine("MotorHome Class Testing: ");
            MotorHome m1 = new MotorHome("Winnebago", "Vista", 2020, 16000.00f, 3);

            //Display MotorHome to the screen.
            Console.WriteLine(m1);
            Console.WriteLine();

            //Make a new Truck class for testing purposes and filling its variables.
            Console.WriteLine("Truck Class Testing: ");
            Truck t1 = new Truck("Toyota", "Tacoma", 2010, 3980, 1120);

            //Display Truck to the sceen.
            Console.WriteLine(t1);
        }//end Main()

    }//end class
}//end namespace
