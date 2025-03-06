using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroPrograma.Introducao_dotNet
{
    internal class DN_05_Sting
    {
        public DN_05_Sting()
        {
            char letra = 'A';

            String nome = "João Pedro";
            String sobrenome = "Almeida";

            //CONTAENAÇÃO

            Console.WriteLine(nome + sobrenome);
            Console.WriteLine(nome + " " + sobrenome);

            //Interpolação
            Console.WriteLine($"Nome é: {nome} {sobrenome}");

            //Console.WriteLine("o texto é longo" +
            //  "com quebra de linha ");

            Console.WriteLine(@"o tecto é longo
                com quebra de linha ");
        }
    }
}
