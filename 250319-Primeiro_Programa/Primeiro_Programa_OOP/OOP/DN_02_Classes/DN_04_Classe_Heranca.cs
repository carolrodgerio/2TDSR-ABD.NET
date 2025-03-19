namespace Primeiro_Programa_OOP.OOP.DN_02_Classes
{

    // Herança com encapsulamento

    //Classe abstrata: Não pode ser instanciada
    //Classe selada: Não pode ser herdada

    internal abstract class DN_04_Classe_Heranca_Veiculo
    {
        //Atributos (Propriedades)
        protected string Marca { get; set; }
        public string Modelo { get; set; }


        public DN_04_Classe_Heranca_Veiculo()
        {

        }

        public DN_04_Classe_Heranca_Veiculo(string marca, string modelo)
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

    internal sealed class DN_04_Classe_Heranca_Carro : DN_04_Classe_Heranca_Veiculo
    {
        //Atributos (Propriedades)
        public string Placa { get; set; }


        public DN_04_Classe_Heranca_Carro()
        {
            
        }

        public DN_04_Classe_Heranca_Carro(string marca, string modelo) : base( marca, modelo )
        {
            
        }


        //Comportamento (Metodos)
        public void ExibirInformacoesCarro()
        {
            //Marca = "Fiat";  
            Console.WriteLine($"Placa {Placa}");
        }
    }


    internal class DN_04_Classe_Heranca
    {
        public DN_04_Classe_Heranca()
        {

            //var veiculo = new DN_04_Classe_Heranca_Veiculo();

            var carro = new DN_04_Classe_Heranca_Carro("Honda", "Civic");

            //carro.Modelo = "City";

            carro.Placa = "DDD-0000";


            carro.ExibirInformacoes();
            carro.ExibirInformacoesCarro();
        }
    }
}
