using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraC_.Model.Operacoes;

namespace CalculadoraC_.Model.Fabricas
{
    internal class FabricaOperation : IFabricaGeral
    {
        private static string namespaceOperacoes = "CalculadoraC_.Model.Operacoes";

        public dynamic criar(string opcao)
        {

            string path = $"{namespaceOperacoes}.{opcao}";
            Type tipoClasse = Type.GetType(path, false, true);

            if (tipoClasse != null && typeof(IOperacao).IsAssignableFrom(tipoClasse))
            {
                // Cria uma instância da classe usando Reflection
                return (IOperacao)Activator.CreateInstance(tipoClasse);
            }

            return null;
        }
    }
}
