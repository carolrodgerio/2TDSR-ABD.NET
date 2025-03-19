namespace Primeiro_Programa_OOP.Introducao_dotNet
{
    internal class DN_09_Array_Laco
    {
        public DN_09_Array_Laco()
        {
            //array inicia na posição zero

            string[] nomes = { "Ana", "Luiz", "Bruno", "Diogo", "Humberto", "Aline" };

            Console.WriteLine($"Primerio item do array {nomes[0]}");

            // indice; Decisão; incremento (Soma do valor)
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(nomes[i]);
            }

            Console.WriteLine();

            foreach (var item in nomes)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var index = 0;
            while (index < nomes.Length)
            {
                Console.WriteLine($"While - {nomes[index]}");
                index++;
            }

            do
            {

            }
            while (index < nomes.Length);

        }
    }
}
