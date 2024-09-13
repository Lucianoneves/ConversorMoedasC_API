using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorC
{
    internal class ConversorMoedas
    {
        public decimal ValorDolarEmReais { get; private set; }

        public decimal ConverterReaisParaDolares(decimal valorReais, decimal cotacaoDolar)
        {
            if (cotacaoDolar <= 0)
            {
                throw new ArgumentException("Cotação inválida.");
            }

            // A conversão é feita dividindo o valor em reais pela cotação do dólar
            return valorReais / cotacaoDolar;
        }
    }
}

