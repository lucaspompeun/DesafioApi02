using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi02.Model
{
    public class JurosCompostos
    {
        public decimal ValorInicial { get; set; }
        public double TaxaJuros { get; set; }
        public int Meses { get; set; }
    }
}
