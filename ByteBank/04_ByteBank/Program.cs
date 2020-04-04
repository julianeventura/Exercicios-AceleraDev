using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            contaDoBruno.titular = "Bruno";

            Console.WriteLine($"Saldo do Bruno: {contaDoBruno.saldo}");

            bool resultadoSaque = contaDoBruno.Sacar(500);

            Console.WriteLine($"Saque de R$500,00 é possível? {resultadoSaque}");
            Console.WriteLine($"Saldo do Bruno: {contaDoBruno.saldo}");

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine($"\nSaldo do Bruno: {contaDoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela: {contaDaGabriela.saldo}");

            bool resultadoTransferencia = contaDoBruno.Transferir(2000, contaDaGabriela);

            Console.WriteLine($"\nResultado da transferência de R$2000,00: {resultadoTransferencia}");
            Console.WriteLine($"Saldo do Bruno após transferência: {contaDoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela após transferência: {contaDaGabriela.saldo}");

            resultadoTransferencia = contaDaGabriela.Transferir(100, contaDoBruno);

            Console.WriteLine($"\nResultado da transferência de R$100,00: {resultadoTransferencia}");
            Console.WriteLine($"Saldo do Bruno: {contaDoBruno.saldo}");
            Console.WriteLine($"Saldo da Gabriela: {contaDaGabriela.saldo}");

            Console.ReadKey();
        }
    }
}
