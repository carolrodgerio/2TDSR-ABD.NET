namespace Primeiro_Programa_OOP.Introducao_dotNet
{
    internal class DN_05_String
    {
        public DN_05_String()
        {
            char valor = 'a';

            string nome = "Humberto";
            string sobrenome = "Oliveira";

            //Contatenaçao
            Console.WriteLine(nome + sobrenome);
            Console.WriteLine(nome + " " + sobrenome);

            //Interpolação
            Console.WriteLine($"Nome é: {nome} {sobrenome}");

            Console.WriteLine($@"O Texto é longo 
                

                com quebra de linha

                Nome é: {nome} {sobrenome}
            ");

            // Manipulacoes
            Console.WriteLine($"Numero de caracteres é: " + sobrenome.Length);
            Console.WriteLine($"Nome em Maiusculo: " + sobrenome.ToUpper());
            Console.WriteLine($"Nome em Minusculo: " + sobrenome.ToLower());
            Console.WriteLine($"Mudar Sobrenome para Melo: " + sobrenome.Replace("Oliveira", "Melo"));

            //coalescencia nula

            nome = null;
            Console.WriteLine($"O Nome é: {nome ?? "<Vazio>"}");
        }
    }
}
