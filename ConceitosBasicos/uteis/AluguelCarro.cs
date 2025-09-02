using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosBasicos.uteis

{
    public class AluguelCarro
    {
        public decimal Aluguel(int total_dias, decimal quilometro_inicio, decimal quilometro_fim)
        {
            return total_dias * 95m + (quilometro_fim - quilometro_inicio) * 0.35m;
        }

    }
}
