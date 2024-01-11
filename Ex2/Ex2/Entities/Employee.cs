using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Entities
{
    public class Employee
    {
        public string Name { get; private set; }
        public int Hours { get; private set; }
        public double ValuePerHour { get; private set; }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment() => Hours * ValuePerHour;
    }
}
