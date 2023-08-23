namespace TiposDeValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis de numeros inteiros positivos/negativos

            Console.WriteLine("Tipo inteiro: ");
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine("-------------");

            Console.WriteLine("Tipo short: ");
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine("-------------");

            Console.WriteLine("Tipo long: ");
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine("-------------");

            #endregion Variaveis de numeros inteiros positivos/negativos

            #region Variaveis de numeros inteiros positivos

            Console.WriteLine("Tipo uint: ");
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine("-------------");

            Console.WriteLine("Tipo ushort: ");
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine("-------------");

            Console.WriteLine("Tipo ulong: ");
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine("-------------");

            #endregion Variaveis de numeros inteiros positivos

            #region Variaveis de numeros ponto flutuante

            Console.WriteLine("Tipo float");
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine("---------------");

            Console.WriteLine("Tipo double");
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine("---------------");

            Console.WriteLine("Tipo decimal");
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine("---------------");

            Console.WriteLine("Teste com tipo float:");

            float minhaVariavelUm = 10.10f;
            float minhaVariavelDois = 20.20f;

            Console
                .WriteLine(minhaVariavelUm + minhaVariavelDois == 30.30f);

            Console
                .WriteLine(minhaVariavelUm + minhaVariavelDois);

            Console.WriteLine("---------------");

            Console.WriteLine("Teste com tipo decimal: ");

            decimal minhaVariavelTres = 10.10m;
            decimal minhaVariavelQuatro = 20.20m;

            Console
                .WriteLine(minhaVariavelTres + minhaVariavelQuatro == 30.30m);

            Console
                .WriteLine(minhaVariavelTres + minhaVariavelQuatro);

            Console.WriteLine("---------------");

            #endregion Variaveis de numeros ponto flutuante

            #region Variaveis boolean

            Console.WriteLine("Tipo boolean");

            bool minhaVariavelCinco = false;
            bool minhaVariavelSeis = true;

            // apenas um sinal de igual (=) significa atribuição de valor para
            // uma variavel
            // dois sinais de igual em seguida (==) significa uma comparação
            // entre variaveis
            bool minhaVariavelSete = minhaVariavelTres == minhaVariavelQuatro;
            bool minhaVariavelOito = minhaVariavelTres > minhaVariavelTres;
            bool minhaVariavelNove = minhaVariavelTres >= minhaVariavelTres;
            bool minhaVariavelDez = minhaVariavelTres < minhaVariavelTres;
            bool minhaVariavelOnze = minhaVariavelTres <= minhaVariavelTres;

            Console.WriteLine("minhaVariavelSete: " + minhaVariavelSete);
            Console.WriteLine("minhaVariavelOito: " + minhaVariavelOito);
            Console.WriteLine("minhaVariavelNove: " + minhaVariavelNove);
            Console.WriteLine("minhaVariavelDez: " + minhaVariavelDez);
            Console.WriteLine("minhaVariavelOnze: " + minhaVariavelOnze);

            Console.WriteLine("---------------");

            #endregion Variaveis boolean

            Console.ReadLine();
        }
    }
}