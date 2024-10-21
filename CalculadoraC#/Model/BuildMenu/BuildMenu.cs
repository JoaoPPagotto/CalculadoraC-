using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraC_.Model.Fabricas;

namespace CalculadoraC_.Model.BuildMenu
{
    internal class BuildMenu : IBuildMenu
    {
        public List<string> GetOperacoes()
        {
            IFabricaGeral fabrica = new FabricaMenu();

            
            return MontaLista(fabrica.criar());

            //string nomeClasse = nomeCompleto.Split('.').Last();
        }

        private List<string> MontaLista(List<string> lista) 
        {
            List<string> result = new List<string>();
            string tempOperacao = null;

            foreach (var item in lista)
            {
                tempOperacao = item.Split('.').Last();
                result.Add(tempOperacao);
            }
            return result;
        }

    }
}
