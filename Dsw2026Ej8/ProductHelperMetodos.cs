using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        public void ObtenerEtiquetaProducto(long code, string descripcion, decimal price)
        {

            Console.WriteLine($"[{code}]{descripcion} - {price}\n");
        }

        public string CrearResumenVenta(long productCode, string productDescription, int Quantity, decimal unitPrice)
        {

            var Producto = new { productCode, productDescription, Quantity, Total = Quantity * unitPrice };


            if (Quantity > 0)
            {
                return $"[{productCode}]-{productDescription}-{Producto.Total}";

            }
            return $"[{productCode}]-{productDescription}-0";
        }

        public string CompararCopias(int originalValue, Product product)
        {
            int copia = originalValue;
            copia++;
            var copia2 = product;
            copia2.ModificarDescripcion("Probando");
            return $"{originalValue}-{copia}-{product.GetDescripcion()}";

        }
    }
}
