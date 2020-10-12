using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class MotorHome : Vehicle
    {
        //fields
        private int _numberOfBeds;

        //properties
        public int NumberOfBeds
        {
            get { return _numberOfBeds; }
            set { _numberOfBeds = value; }
        }//end NumberOfBeds

        //constructors
        public MotorHome(string make, string model, int year, float weight, int numberOfBeds):base(make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }//end FQCTOR

        //methods
        public override string ToString()
        {
            return string.Format($"Make: {Make}\nModel: {Model}\nYear: {Year}\nWeight: {Weight}\nNumber of Beds: {NumberOfBeds}");
        }//end ToString()

    }//end class
}//end namespace
