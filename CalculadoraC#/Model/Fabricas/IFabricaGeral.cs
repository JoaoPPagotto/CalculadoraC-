using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraC_.Model.Operacoes;

namespace CalculadoraC_.Model.Fabricas
{
    internal interface IFabricaGeral
    {
        public dynamic criar(String opcao = null);
    }
}
