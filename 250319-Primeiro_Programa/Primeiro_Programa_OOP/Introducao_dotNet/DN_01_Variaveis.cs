namespace Primeiro_Programa_OOP.Introducao_dotNet
{
    internal class DN_01_Variaveis
    {
        public DN_01_Variaveis()
        {
            //camelCase

            byte idade = 25; // armazena caracteres (8 bits)
            sbyte temperatura = -25; // números inteiros entre -128 e 127

            short populacao = -1000; // números inteiros entre -32.768 e 32.767 
            ushort identificador = 10; // números inteiros até 65.535 (apenas positivos)

            int quantidade = -10; // números inteiros entre -2.147.483.648 e 2.147.483.647 
            uint quantidade2 = 2; // números inteiros até 4.294.967.295 (apenas positivos)

            long distancia = -10000000000; // números inteiros entre -9.223.372.036.854.775.808 e 9.223.372.036.854.775.807 
            ulong distancia2 = 10000000000; // números inteiros até 18.446.744.073.709.551.615 (apenas positivos)

            float altura = 1.71f;
            double peso = 60.5;
            decimal preco = 18.5555m;

            char letra = 'A';

            bool estaChovendo = true; // 0 ou 1

            Console.WriteLine(idade);
        }
    }
}
