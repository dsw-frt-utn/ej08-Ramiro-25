using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{
    internal class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return base.GetPrice() - (base.GetPrice() * 0.1m);
        }
        public WholesaleSale(decimal price) : base(price) { }
    }
}
