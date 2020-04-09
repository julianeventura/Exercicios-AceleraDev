using System;
using System.IO;

namespace _05_ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("05!");

            try
            {
                CarregarContas();
            }
            catch (IOException)
            {
                Console.WriteLine("Catch no método main!");
            }

            Console.ReadKey();
        }

        private static void CarregarContas()
        {
            //using verifica se a variável é nula
            //caso for nula, não entrará no bloco de código
            //a construção using chama o método Dispose ao finalizar o bloco (finally)

            using(LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                leitor.LerProximaLinha();
            }
        }
    }
}
