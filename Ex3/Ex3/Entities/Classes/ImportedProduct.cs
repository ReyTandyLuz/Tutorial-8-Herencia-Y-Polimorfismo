using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Entities.Classes
{
    public sealed class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice() => CustomsFee + Price;
        public override string PriceTag() => $"{Name} $ {TotalPrice():n2} (Custom fee $ {CustomsFee:n2})";
    }
}
