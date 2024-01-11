using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Entities
{
    public class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }    

        public OutSourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment() => base.Payment() + AdditionalCharge;
    }
}
