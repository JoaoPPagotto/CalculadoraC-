using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraC_.Model.dto;

namespace CalculadoraC_.View
{
    public class Menu
    {
        private void showMenu()
        {
            Console.WriteLine("---->Olá<----");
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Vá embora ...");
        }

        private void showMenuReflection(List<string> listaOperacoes)
        {
            Console.WriteLine("---->Olá<----");
            Console.WriteLine("Escolha uma das opções:");

            foreach (var item in listaOperacoes)
            {
                Console.WriteLine("- " + item);
            }

            Console.WriteLine("- Sair");
        }

        private RequestDTO captureValues(List<string> listaOperacoes)
        {
            String opcao = this.FormataString(Console.ReadLine());

            if (listaOperacoes.Contains(opcao))
            {
                Console.WriteLine("Informe o primeiro valor:");
                int valor1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o segundo valor:");
                int valor2 = Convert.ToInt32(Console.ReadLine());
                return new RequestDTO(opcao, valor1, valor2);
            }
            else
            {
                throw new Exception("Operação Invalida");
            }
        }

        public void ShowResult(ResponseDTO responseDTO)
        {
            Console.WriteLine("Esse é o resultado: "+Convert.ToString(responseDTO.getResult()));
        }

        public RequestDTO Show(List<string> listaOperacoes) 
        { 
            this.showMenuReflection(listaOperacoes);
            return this.captureValues(listaOperacoes);
        }

        private string FormataString(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }

        private bool ValidaEntrada(RequestDTO requestDTO, List<string> listaOperacoes)
        {
            if (!listaOperacoes.Contains(requestDTO.getOpcao()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
