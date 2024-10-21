using CalculadoraC_.Model.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraC_.Model.Calculadora
{
    public interface ICalculadora
    {
        public ResponseDTO Calcular(RequestDTO request);
    }
}
