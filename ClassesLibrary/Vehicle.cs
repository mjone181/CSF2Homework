using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Vehicle
    {
        //Create fields
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        //Create properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }//end Make

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }//end Model

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }//end Year

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }//end Weight

        
        //Create constructors
        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }//end Vehicle

        public Vehicle() { }//end Vehicle

        //Create methods
        public override string ToString()
        {
            return string.Format("Make: {0}\n" +
                "Model: {1}\n" +
                "Year: {2:n1}\n" +
                "Weight: {3:n2}", Make, Model, Year, Weight);
        }//end ToString()

    }//end class
}//end namespace
