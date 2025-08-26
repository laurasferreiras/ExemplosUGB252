using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos.uteis
{
    public class CalculaDesconto
    {
        public decimal Descontar(decimal valor, float desconto)
        {
            return valor * ((decimal)desconto / 100);
        }
    }
}
