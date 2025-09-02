using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos.uteis
{
    public class CalcularIMC
    {
        public decimal Imc(decimal altura, decimal peso)
        { return peso / (altura * altura); }

    }
}
