using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8
{
    public static class ProductExtension
    {
        public static string ToProductCode(this string code)
        {
            if (code is null)
            {
                return "SIN-CODIGO";
            }

            code.Trim();

            code = code.ToUpper();

            code.Replace(' ', '-');
            return code;
        }

    }
}