using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsw2026Ej8
{
    public class Product
    {
        private long _code;
        private string _descripcion;
        private decimal _price;
        private decimal _total;

        public decimal GetPrice()
        {
            return _price;
        }
        public string GetDescripcion()
        {
            return _descripcion;
        }
        public void ModificarDescripcion(string descrip)
        {
            _descripcion = descrip;
        }
    }
}
