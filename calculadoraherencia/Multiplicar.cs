using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoraherencia
{
    internal class Multiplicar : Operacion
    {

        public int operar(double v1, double v2)
        {
            valor1 = v1;
            valor2 = v2;
            resultado = valor1 * valor2;
            return (int)resultado;
        }
    }
}
