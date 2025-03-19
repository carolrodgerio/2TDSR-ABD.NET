namespace Primeiro_Programa_OOP.Introducao_dotNet
{
    internal class DN_06_Entrada_Dados
    {
        public DN_06_Entrada_Dados()
        {
            Console.WriteLine("Digite seu nome");
            string? nome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Digite seu sobrenome");
            string? sobrenome = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"Nome completo é: {nome} {sobrenome}");
        }
    }
}
