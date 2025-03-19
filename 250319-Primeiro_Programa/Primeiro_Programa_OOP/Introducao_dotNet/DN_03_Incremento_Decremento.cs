namespace Primeiro_Programa_OOP.Introducao_dotNet
{
    internal class DN_03_Incremento_Decremento
    {
        public DN_03_Incremento_Decremento()
        {
            int contador = 5;

            //Soma valores

            //contador = contador + 1;

            //Incremento ++
            // Variavel++

            //Decremento --
            // Variavel--


            // Pos Incremento
            Console.WriteLine($"Valor do Contador {contador++}");
            Console.WriteLine("Valor do Contador {0} ", contador);

            int contadorPre = 5;

            // Pre Incremento 
            Console.WriteLine($"Valor do Contador {++contadorPre}");
            Console.WriteLine("Valor do Contador {0} ", contadorPre);

            Console.WriteLine(contador);
        }
    }
}
