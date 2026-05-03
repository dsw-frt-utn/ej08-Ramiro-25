using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{
    internal class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return base.GetPrice();
        }
        public RetailSale(decimal price) : base(price) { }
    }
}
