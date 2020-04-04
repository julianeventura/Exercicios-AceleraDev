using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Total de contas criadas: {ContaCorrente.TotalDeContasCriadas}");

            ContaCorrente conta = new ContaCorrente(867, 86712540);
            Console.WriteLine($"\nTotal de contas criadas: {ContaCorrente.TotalDeContasCriadas}");

            Console.WriteLine($"Agência: {conta.Agencia}");
            Console.WriteLine($"Número: {conta.Numero}");

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            Console.WriteLine($"\nTotal de contas criadas: {ContaCorrente.TotalDeContasCriadas}");

            Console.ReadKey();
        }
    }
}
