using System;
using System.IO;

namespace _04_ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("04!");

            CarregarContas();

            Console.ReadKey();
        }

        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = null;
            try
            {
                leitor = new LeitorDeArquivo("contas.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
            catch (IOException)
            {

                Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            }
            finally
            {
                if(leitor != null)
                {
                    leitor.Fechar();
                }
            }
        }
    }
}
