using CalculadoraC_.Model.dto;
using CalculadoraC_.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraC_.Controller;

namespace CalculadoraC_.Aplication
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Menu menu = new Menu();
            CalculadoraController calculadoraController = new CalculadoraController();

            try
            {
                List<string> listaOperacoes = calculadoraController.GetListaOperacoes();

                RequestDTO requestDTO = menu.Show(listaOperacoes);

                ResponseDTO responseDTO = calculadoraController.Calcular(requestDTO);
                menu.ShowResult(responseDTO);

            }
            catch(Exception ex)  
            { 
                throw ex;
            }
        }

        
    }
}
