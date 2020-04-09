using System;

namespace _03_ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("03!");

            //o erro se propaga pela pilha até algum metodo conseguir tratar, caso contrário o erro estoura
            try
            {
                Metodo();
            }
            //NullReferenceException é uma classe
            // e: boa prática
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine(e.Message);
            //    //Rastro de pilha
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine("Aconteceu um erro.");
            //}


            //pegar
            //DivideByZeroException é uma classe
            // e: boa prática
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                //Rastro de pilha
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Não é possível fazer uma divisão por zero.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //Rastro de pilha
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Aconteceu um erro.");
            }

            //todos os bloco apõs o catch "Exception" não serão executados, uma vez que todas as classes derivam desta classe


            Console.ReadKey();
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {

            int resultado = Dividir(10, divisor);

            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);

        }

        private static int Dividir(int numero, int divisor)
        {
            //referencia de objeto apontando para lugar nenhum
            //ContaCorrente conta = null;

            //if (conta != null)
            //    Console.WriteLine(conta.Saldo);

            try
            {
                return numero / divisor;
            }
            catch (Exception)
            {
                Console.WriteLine("Exceção com números = " + numero + " e divisor = " + divisor);
                throw;
            }

        }
    }
}
