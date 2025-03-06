using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Introducao_dotNet
{
    internal class DN_01_Variaveis
    {
        public DN_01_Variaveis()
        {
            //camelCase


            byte idade = 25;
            sbyte temperatura = -25;

            short populacao = 1000;
            ushort identificador = 10;

            int quantidade = -10;
            uint quantidade2 = 2;

            long distancia = 100000000000000;
            ulong distancia2 = 100000000000000;

            float altura = 1.80f;
            double peso = 80.5;
            decimal preco = 18.54684m;

            char letra = 'A';

            bool estaChovendo = true;

            Console.WriteLine("Hello, World!");
        }
    }
}
