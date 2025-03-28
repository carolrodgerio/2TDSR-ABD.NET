namespace OOP_Console_APP;

public class Questao_01
{
    public Questao_01()
    {

        Console.Write("Qual o seu nome? ");
        string nome = Console.ReadLine();

        Console.Write("Qual a sua idade? ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Você possui CNH? (sim/não): ");
        string cnh = Console.ReadLine().ToLower();

        if (idade >= 18 && cnh == "sim")
        {
            Console.WriteLine($"Olá {nome}, você pode dirigir legalmente!");
        }

        else if (idade >= 18 && cnh == "não")
        {
            Console.WriteLine($"Olá {nome}, você tem idade para dirigir, mas precisa tirar a CNH.");
        }

        else if (idade < 18 && cnh == "sim")
        {
            Console.WriteLine($"Olá {nome}, você tem CNH, mas ainda não tem idade legal para dirigir!");
        }

        else
        {
            Console.WriteLine($"Olá {nome}, você não pode dirigir ainda.");
        }
    }
}