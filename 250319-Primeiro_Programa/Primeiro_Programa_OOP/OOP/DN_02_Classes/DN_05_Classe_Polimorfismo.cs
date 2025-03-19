namespace Primeiro_Programa_OOP.OOP.DN_02_Classes
{


    internal abstract class DN_05_Classe_Polimorfismo_Veiculo
    {
        //Atributos (Propriedades)
        protected string Marca { get; set; }
        public string Modelo { get; set; }


        public DN_05_Classe_Polimorfismo_Veiculo()
        {

        }

        public DN_05_Classe_Polimorfismo_Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }


        //Comportamento (Metodos)

        public abstract void Detalhes();

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} e modelo: {Modelo}");
        }
    }

    internal sealed class DN_05_Classe_Polimorfismo_Carro : DN_05_Classe_Polimorfismo_Veiculo
    {
        //Atributos (Propriedades)
        public string Placa { get; set; }


        public DN_05_Classe_Polimorfismo_Carro()
        {

        }

        public DN_05_Classe_Polimorfismo_Carro(string marca, string modelo) : base(marca, modelo)
        {
            
        }


        //Comportamento (Metodos)
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();

            Console.WriteLine($"Placa {Placa}");
        }

        public override void Detalhes()
        {
            throw new NotImplementedException();
        }
    }

    internal class DN_05_Classe_Polimorfismo
    {
        public DN_05_Classe_Polimorfismo()
        {
            var carro = new DN_05_Classe_Polimorfismo_Carro("Honda", "Civic");

            carro.Placa = "DDD-0000";

            carro.ExibirInformacoes();
        }
    }
}
