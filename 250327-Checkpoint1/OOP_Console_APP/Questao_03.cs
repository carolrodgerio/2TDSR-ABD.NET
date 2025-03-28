namespace OOP_Console_APP;

public abstract class Funcionario
{
    private string nome;
    private double salarioBase;

    public Funcionario(string nome, double salarioBase)
    {
        this.nome = nome;
        this.salarioBase = salarioBase;
    }

    public string Nome { get => nome; }
    public double SalarioBase { get => salarioBase; }

    public abstract double CalcularSalario();
}

public class FuncionarioCLT : Funcionario
{
    public FuncionarioCLT(string nome, double salarioBase) : base(nome, salarioBase) { }

    public override double CalcularSalario()
    {
        return SalarioBase * 1.1; // faz um reajuste de 10% ao salário
    }
}

public class FuncionarioPJ : Funcionario
{
    public FuncionarioPJ(string nome, double salarioBase) : base(nome, salarioBase) { }

    public override double CalcularSalario()
    {
        return SalarioBase * 1.05; // faz um reajuste de 5% ao salário
    }
}

public class Questao_03
{
    public Questao_03()
    {
        Funcionario funcionarioCLT = new FuncionarioCLT("João", 2500);
        Funcionario funcionarioPJ = new FuncionarioPJ("Maria", 5000);

        Console.WriteLine($"Salário CLT: {funcionarioCLT.CalcularSalario()}");
        Console.WriteLine($"Salário PJ: {funcionarioPJ.CalcularSalario()}");
    }
}