using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraC_.Model.dto;

namespace CalculadoraC_.View
{
    internal class Menu
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

        private RequestDTO captureValues()
        {

            String opcao = Console.ReadLine();
            Console.WriteLine("Informe o primeiro valor:");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            return new RequestDTO(opcao, valor1, valor2);
        }

        public void showResult(ResponseDTO responseDTO)
        {
            Console.WriteLine("Esse é o resultado: "+Convert.ToString(responseDTO.getResult()));
        }

        public RequestDTO Show() 
        { 
            this.showMenu();
            return this.captureValues();
        }

    }
}
