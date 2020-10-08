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
            Student s1 = new Student();
            s1.FirstName = "John";
            s1.LastName = "Brown";
            s1.ID = "123456789";
            s1.GPA = 4.0f;

            //Display Student class to the screen.
            Console.WriteLine(s1);

            Console.WriteLine();

            //making a new Vehicle class for testing purposes and filling its variables.
            Vehicle v1 = new Vehicle();
            v1.Make = "Toyota";
            v1.Model = "Tacoma";
            v1.Year = 2008;
            v1.Weight = 3980;

            //Display Vehicle class to the screen.
            Console.WriteLine(v1);

            Console.WriteLine();

            //making a new Logn class for testing purposes and filling its variables.
            Login l1 = new Login();
            l1.Username = "FonzieWonzie";
            l1.Password = "Thisismypassword";

            //Display Login class to the screen.
            Console.WriteLine(l1);
            
        }//end Main()

    }//end class
}//end namespace
