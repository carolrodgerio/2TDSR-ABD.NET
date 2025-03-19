namespace Primeiro_Programa_OOP.Introducao_dotNet
{
    internal class DN_08_Operadores_Decisao
    {
        public DN_08_Operadores_Decisao()
        {
            int valorCodigo = 2;


            //IF
            if (valorCodigo == 2)
            {
                Console.WriteLine("Condicao verdadeira = 2");
            }
            else if (valorCodigo == 4)
            {
                Console.WriteLine("Condicao verdadeira = 4");
            }
            else
            {
                Console.WriteLine("Condicao negação");
            }


            //switch
            switch(valorCodigo)
            {
                case 2: //if (valorCodigo == 2 || valorCodigo == 4)
                case 4:
                    Console.WriteLine($"Condicao = {valorCodigo}");
                    break;
                default:
                    Console.WriteLine($"Condicao = {valorCodigo} - default");
                    break;
            }

            //Ternario
            var suaIdade = 18;
            
            // Condição ? Verdade : Falso
            Console.WriteLine(suaIdade >= 18 ? "Maior de idade" : "Menor de idade");

        }
    }
}
