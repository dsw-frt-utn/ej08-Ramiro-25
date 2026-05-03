using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{
    public class Sale
    {
        private decimal _price;

        public virtual decimal CalculateTotal()
        {
            return _price;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public Sale(decimal price)
        {
            _price = price;
        }

    }
}
