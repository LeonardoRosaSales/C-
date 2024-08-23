using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remember
{
    internal class ConversorDeMoedas
    {
        public double IOF = 0.06;
        public double ValorDolar;
        public double ValorComprar;

        public double Resultado()
        {
            double valorTotalDolar = ValorDolar * ValorComprar;
            double resultado = valorTotalDolar + (valorTotalDolar * IOF);
            return resultado;
        }
    }
}
