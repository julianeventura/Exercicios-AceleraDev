using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Juliane Ventura";
            cliente.CPF = "422.158.748-21";
            cliente.Profissao = "Desempregada";

            conta.Saldo = 30;
            conta.Titular = cliente;

            Console.WriteLine($"Nome completo do Titular: {conta.Titular.Nome}");
            Console.WriteLine($"CPF do Titular: {conta.Titular.CPF}");
            Console.WriteLine($"Saldo: {conta.Saldo}");

            Console.ReadKey();
        }
    }
}
