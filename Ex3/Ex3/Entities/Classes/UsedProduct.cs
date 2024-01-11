using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Entities.Classes
{
    public sealed class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; private set; }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string PriceTag() => $"{Name} (used) $ {Price:n2} (Manufacture date: {ManufacturedDate.ToString("dd/MM/yyyy")})";
    }
}
