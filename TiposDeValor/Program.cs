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

            Console.ReadLine();
        }
    }
}