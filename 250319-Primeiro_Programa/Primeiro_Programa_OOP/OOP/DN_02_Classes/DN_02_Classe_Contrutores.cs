namespace Primeiro_Programa_OOP.OOP.DN_02_Classes
{

    internal class DN_02_Classe_Contrutores_Carro
    {
        //Atributos (Propriedades)
        public string Marca { get; set; }
        public string Modelo { get; set; }


        public DN_02_Classe_Contrutores_Carro()
        {

        }

        public DN_02_Classe_Contrutores_Carro(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public DN_02_Classe_Contrutores_Carro(string marca, string modelo, string ano)
        {
            
        }


        //Comportamento (Metodos)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} e modelo: {Modelo}");
        }
    }

    internal class DN_02_Classe_Contrutores
    {
        public DN_02_Classe_Contrutores()
        {
            var carro = new DN_02_Classe_Contrutores_Carro();

            carro.Modelo = "Honda";
            carro.Modelo = "City";

            carro.ExibirInformacoes();
        }
    }
}
