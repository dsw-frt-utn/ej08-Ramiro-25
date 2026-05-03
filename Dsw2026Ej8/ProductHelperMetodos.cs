using EJ8;
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
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {

            int contador = 0;
            double suma = 0;

            if (nota1.HasValue && nota1.Value >= 0 && nota1.Value <= 10)
            {
                suma = nota1.Value;
                contador++;
            }
            if (nota2.HasValue && nota2.Value >= 0 && nota2.Value <= 10)
            {
                suma = nota2.Value;
                contador++;
            }
            if (nota3.HasValue && nota3.Value >= 0 && nota3.Value <= 10)
            {
                suma = nota3.Value;
                contador++;
            }
            if (contador != 0)
            {
                return suma / contador;
            }
            else
            {
                return 0;
            }


        }

        public decimal ObtenerImporteFinal(Sale sale)
        {

            return sale.CalculateTotal();

        }
        public string NormalizarCodigoProducto(string code)
        {
            return code.ToProductCode();
        }
    }
}
