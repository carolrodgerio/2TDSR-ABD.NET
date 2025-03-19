namespace Primeiro_Programa_OOP.Introducao_dotNet
{
    internal class DN_11_Colecao
    {
        public DN_11_Colecao()
        {
            int[] num = { 1, 2, 3, 4, 5 };

            //num[6] = 7;

            List<int> listaNumeros = new List<int>();

            listaNumeros.Add(1);
            listaNumeros.Add(2);
            listaNumeros.Add(5);

            listaNumeros.AddRange(new List<int> { 1, 2, 3, 4, 5 });

            listaNumeros.ForEach(item =>
            {
                Console.WriteLine(item);
            });

            Console.WriteLine();

            var numeroCinco = listaNumeros.Where(item => item == 5).ToList();

            foreach (int numero in numeroCinco)
            {
                Console.WriteLine(numero);
            }

            listaNumeros.Clear();

            Console.WriteLine();

            //Dictionary
            Dictionary<string, int> idadePessoas = new Dictionary<string, int>();

            idadePessoas.Add("joao", 30);
            idadePessoas.Add("Aline", 20);
            idadePessoas.Add("guilherme", 15);
            idadePessoas.Add("matheus", 30);

            Console.WriteLine($"A pessoa tem {idadePessoas["Aline"]} anos e se chama {idadePessoas.Keys.First(x => x == "Aline")}");
            Console.WriteLine();

            foreach (var item in idadePessoas)
            {
                Console.WriteLine($"{item.Key} tem {item.Value} anos");
            }

            Console.WriteLine();

            //Hashset

            HashSet<int> hashsetNumeros = new HashSet<int>() { 0, 1, 2 };

            hashsetNumeros.Add(3);
            hashsetNumeros.Add(5);
            hashsetNumeros.Add(6);
            hashsetNumeros.Add(7);
            hashsetNumeros.Add(8);
            hashsetNumeros.Add(7);

            foreach (var item in hashsetNumeros.ToList())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Coleções com objetos complexos

            var lista = new List<DN_11_Colecao_Cliente>();


            lista.Add(new DN_11_Colecao_Cliente { Nome = "Aluno 1" });
            lista.Add(new DN_11_Colecao_Cliente { Nome = "Aluno 2" });
            lista.Add(new DN_11_Colecao_Cliente { Nome = "Aluno 3" });
            lista.Add(new DN_11_Colecao_Cliente { Nome = "Aluno 4" });
            lista.Add(new DN_11_Colecao_Cliente { Nome = "Aluno 5" });

            //var aluno = new DN_11_Colecao_Cliente();
            //aluno.Nome = "Aluno";

            //lista.Add(aluno);


            foreach (var item in lista)
            {
                Console.WriteLine(item.Nome);
            }

            Console.WriteLine();


            //Queue

            Queue<int> ints = new Queue<int>();

            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);

            foreach (var item in ints)
            {
                Console.Write(item.ToString());
            }

        }

    }
    internal class DN_11_Colecao_Cliente
    {
        public string Nome { get; set; }
    }
}
