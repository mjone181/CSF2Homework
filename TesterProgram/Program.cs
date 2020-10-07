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
        }
    }
}
