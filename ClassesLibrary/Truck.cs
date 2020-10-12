using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Truck : Vehicle
    {
        //fields
        private float _loadCapacityLbs;

        //properties
        public float LoadCapacityLbs
        {
            get { return _loadCapacityLbs; }
            set { _loadCapacityLbs = value; }
        }//end LoadCapacity

        //constructors
        public Truck(string make, string model, int year, float weight, float loadCapacityLbs):base(make, model, year, weight)
        {
            LoadCapacityLbs = loadCapacityLbs;
        }//end FQCTOR

        public Truck() { }//end Truck
        //methods
        public override string ToString()
        {
            return string.Format($"Make: {Make}\nModel: {Model}\nYear:{Year}\nWeight: {Weight}\nLoad Capacity: {LoadCapacityLbs}");
        }//end ToString()

    }//end class
}//end namespace
