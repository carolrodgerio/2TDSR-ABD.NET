namespace OOP_Console_APP;

public class Questao_02
{
    public Questao_02()
    {
        int entradasValidas = 0;

        while (entradasValidas < 10)
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite uma idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine($"Nome: {nome}, Idade: {idade}");
                entradasValidas++;
            }
            else
            {
                Console.WriteLine("Idade inválida. A idade deve ser maior ou igual a 18 anos.");
            }
        }

        Console.WriteLine("10 entradas válidas foram coletadas!");
    }
}