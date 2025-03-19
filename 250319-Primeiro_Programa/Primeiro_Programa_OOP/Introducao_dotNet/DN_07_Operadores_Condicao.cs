namespace Primeiro_Programa_OOP.Introducao_dotNet
{
    internal class DN_07_Operadores_Condicao
    {
        public DN_07_Operadores_Condicao()
        {
            // Operadores de condição
            int numero1 = 10;
            int numero2 = 5;


            // >, >=, <, <=, ==, !=

            bool resultado = (numero1 > numero2);
            Console.WriteLine("Valor da operação " + resultado);

            bool resultado2 = numero1 < numero2;
            Console.WriteLine("Valor da operação " + resultado2);

            bool resultado3 = numero1 >= numero2;
            Console.WriteLine("Valor da operação " + resultado3);

            bool resultado4 = numero1 <= numero2;
            Console.WriteLine("Valor da operação " + resultado4);

            bool resultado5 = numero1 == numero2;
            Console.WriteLine("Valor da operação " + resultado5);

            bool resultado6 = numero1 != numero2;
            Console.WriteLine("Valor da operação " + resultado6);
        }
    }
}
