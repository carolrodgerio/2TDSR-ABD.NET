namespace Primeiro_Programa_OOP.Introducao_dotNet
{
    internal class DN_10_Conversao
    {
        public DN_10_Conversao()
        {
            //Conversão de Dados

            // Cast, Parse, TryParse, Convert


            //Cast
            int valorDecimal = (int)2.5m;
            long valor = (long)2;

            Console.WriteLine(valorDecimal);
            Console.WriteLine(valor);

            //Parse
            int valorParse = int.Parse("0");
            //int valorParseErro = int.Parse("zero");

            Console.WriteLine(valorParse);

            //TryParse
            int valorParse2 = int.TryParse("99", out valorParse) ? valorParse : 0;

            if (int.TryParse("kjhafjkshjkfd", out valorParse))
            {
                valorParse2 = valorParse;
            }
            else
            {
                valorParse2 = -99;
            }

            Console.WriteLine(valorParse2);

            //Convert
            int valorFalse = Convert.ToInt32(2.5m);
            int valorConvert = Convert.ToInt32("2");
            bool textoToBool = Convert.ToBoolean("true");
        }
    }
}
