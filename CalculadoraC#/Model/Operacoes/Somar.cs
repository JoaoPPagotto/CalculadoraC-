using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraC_.Model.Operacoes
{
    internal class Somar : IOperacao
    {
        public int calc(int a, int b)
        {
            return a + b;
        }
    }
}
