namespace Primeiro_Programa_OOP.Introducao_dotNet
{
    internal class DN_01_Variaveis
    {
        public DN_01_Variaveis()
        {
            //camelCase

            byte idade = 25;
            sbyte temperatura = -25;

            short populacao = -1000;
            ushort identificador = 10;

            int quantidade = -10;
            uint quantidade2 = 2;

            long distancia = -10000000000;
            ulong distancia2 = 10000000000;

            float altura = 1.71f;
            double peso = 60.5;
            decimal preco = 18.5555m;

            char letra = 'A';

            bool estaChovendo = true; //0 ou 1

            Console.WriteLine(idade);
        }
    }
}
