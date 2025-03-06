using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Introducao_dotNet
{
    internal class DN_03_Increment_Decremento
    {
        public DN_03_Increment_Decremento()
        {
            int contador = 5;

            // soma valores

            contador = contador + 10;

            //incremento ++

            //variavel ++

            //decremento --

            //variavel --


            //pos Incremento
            Console.WriteLine("valor do Contador ",contador++);
            Console.WriteLine("valor do Contador ",contador);

            int contadorPre = 5;
            //pre Incremento

            Console.WriteLine($"valor do Contador , { ++contadorPre}");
            Console.WriteLine("valor do Contador ", contadorPre);

            Console.WriteLine(contador);
        }
    }
}
