namespace Primeiro_Programa_OOP.OOP.DN_02_Classes
{

    internal class DN_01_Classe_Basica_Carro
    {
        //Atributos (Variavel)
        public string cor;

        //Atributos (Propriedades)

        public string Marca { get; set; }
        public string Modelo { get; set; }

        //Comportamento (Metodos)

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} e modelo: {Modelo}");
        }
    }

    internal class DN_01_Classe_Basica
    {
        public DN_01_Classe_Basica()
        {
            var carro = new DN_01_Classe_Basica_Carro();

            carro.cor = "";

            carro.Marca = "Honda";
            carro.Modelo = "Civic";

            carro.ExibirInformacoes();
     
           
        }

    }
}
