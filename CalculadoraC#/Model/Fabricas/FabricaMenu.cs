using CalculadoraC_.Model.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraC_.Model.Fabricas
{
    internal class FabricaMenu : IFabricaGeral
    {
        public dynamic criar(string opcao = null)
        {
            List<string> listaOperacoes = new List<string>();
            listaOperacoes = this.ObterOperacoes(typeof(IOperacao));
            return listaOperacoes;
        }

        public List<string> ObterOperacoes(Type interfaceType)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            List<string> Operacoes = assembly.GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && interfaceType.IsAssignableFrom(t))
                .Select(t => t.FullName).ToList();

            return Operacoes;
        }
    }
}
