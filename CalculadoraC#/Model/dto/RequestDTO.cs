using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraC_.Model.dto
{
    public class RequestDTO
    {
        private string opcao { get; set; }
        private int valor1 { get; set; }
        private int valor2 { get; set; }

        public RequestDTO(string opcao, int valor1, int valor2)
        {
            this.opcao = opcao;
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public string getOpcao()
        {
            return this.opcao;
        }

        public int getValor1()
        { 
            return this.valor1;
        }

        public int getValor2()
        {
            return this.valor2;
        }
    }
}
