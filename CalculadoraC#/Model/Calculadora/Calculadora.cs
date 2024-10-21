using CalculadoraC_.Model.dto;
using CalculadoraC_.Model.Fabricas;
using CalculadoraC_.Model.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraC_.Model.Calculadora
{
    internal class Calculadora:ICalculadora
    {
        public ResponseDTO Calcular(RequestDTO request)
        {
            IFabricaGeral fabricaGeral = new FabricaOperation();

            try
            {
                IOperacao operacao = fabricaGeral.criar(request.getOpcao());

                if (operacao != null)
                {
                    int resultado = operacao.calc(request.getValor1(), request.getValor2());
                    return new ResponseDTO(resultado);
                }
                else 
                {
                    return null;
                }

                
            }
            catch (Exception ex) 
            {
                throw new Exception("");
            }
        }
    }
}
