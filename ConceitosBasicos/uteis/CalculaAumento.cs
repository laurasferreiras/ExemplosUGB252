using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos.uteis
{
    public class CalculaAumento
    {
        public decimal Calcular(decimal salario, float aumento)
        {
            /*
            return salario + (salario * (decimal)aumento) / 100;
            */
            return salario * ((decimal)aumento / 100);
        }
    }
}
