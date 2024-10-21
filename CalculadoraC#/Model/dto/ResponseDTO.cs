using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraC_.Model.dto
{
    public class ResponseDTO
    {
        private int result {  get; set; }

        public ResponseDTO(int result)
        {
            this.result = result;
        }

        public int getResult()
        {
            return this.result;
        }
    }
}
