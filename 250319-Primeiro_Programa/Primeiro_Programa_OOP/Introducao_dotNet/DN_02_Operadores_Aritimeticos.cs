namespace Primeiro_Programa_OOP.Introducao_dotNet
{
    internal class DN_02_Operadores_Aritimeticos
    {
        public DN_02_Operadores_Aritimeticos()
        {

            int numero1 = 10;
            int numero2 = 5;

            // +, -, *, /

            int soma = numero1 + numero2;
            Console.WriteLine("Valor da operação " + soma);

            int subtracao = numero1 - numero2;
            Console.WriteLine("Valor da operação " + subtracao);

            int multiplicacao = numero1 * numero2;
            Console.WriteLine("Valor da operação " + multiplicacao);

            int divisao = numero1 / numero2;
            Console.WriteLine("Valor da operação " + divisao);

            float conta = numero1 / 5.2f;

            //var resposta = numero1 * 5.5m; //Recebe o tipo do objeto depois do igual 

            decimal resposta = numero1 * 5.5m;
        }
    }
}
