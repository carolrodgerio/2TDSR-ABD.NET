namespace Primeiro_Programa_OOP.OOP.DN_02_Classes
{
    internal class DN_03_Classe_Encapsulamento_Carro
    {
        //Atributos (Propriedades)
        private string Marca { get; set; }
        public string Modelo { get; private set; }


        public DN_03_Classe_Encapsulamento_Carro()
        {

        }

        public DN_03_Classe_Encapsulamento_Carro(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }


        //Comportamento (Metodos)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} e modelo: {Modelo}");
        }
    }

    internal class DN_03_Classe_Encapsulamento
    {
        public DN_03_Classe_Encapsulamento()
        {
            var carro = new DN_03_Classe_Encapsulamento_Carro("Honda", "Civic");

            //carro.Marca

            //carro.Modelo = "City";

            Console.WriteLine(carro.Modelo);

            carro.ExibirInformacoes();      
        }
    }
}
