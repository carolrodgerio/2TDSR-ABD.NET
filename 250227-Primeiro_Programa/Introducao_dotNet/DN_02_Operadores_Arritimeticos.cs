using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Introducao_dotNet
{
    internal class DN_02_Operadores_Arritimeticos
    {
        public DN_02_Operadores_Arritimeticos()
        {
            int numero1 = 10;
            int numero2 = 5;
            //+, -, *, /

            int soma = numero1 + numero2;
            Console.WriteLine("valor da operação" + soma);

            int subtracao = numero1 - numero2;
            Console.WriteLine("valor da operação" + subtracao);

            int multiplicacao = numero1 * numero2;
            Console.WriteLine("valor da operação" + multiplicacao);

            int divisao = numero1 / numero2;
            Console.WriteLine("valor da operação" + divisao);
        }
    }
}
