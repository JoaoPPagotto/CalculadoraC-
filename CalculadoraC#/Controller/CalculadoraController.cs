using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraC_.Model.dto;
using CalculadoraC_.Model.Calculadora;
using CalculadoraC_.Model.BuildMenu;

namespace CalculadoraC_.Controller
{
    public class CalculadoraController
    {
        public ResponseDTO Calcular(RequestDTO requestDTO)
        {
            ICalculadora calculadora = new Calculadora();
            return calculadora.Calcular(requestDTO);
        }

        public List<string> GetListaOperacoes()
        {
            IBuildMenu buildMenu = new BuildMenu();
            return buildMenu.GetOperacoes();
        }
    }
}
