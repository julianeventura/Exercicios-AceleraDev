using System;

namespace _01_ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01!");

            var retorno = Metodo();

            if(retorno == -2)
            {
                Console.WriteLine("Ocorreu um erro!");
            }
            Console.ReadKey();
        }

        private static int Metodo()
        {
            return TestaDivisao(12);
        }

        private static int TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            if(resultado == -2)
            {
                return -2;
            }

            if (resultado == -1)
            {
                Console.WriteLine("Não é possível fazer divisão por zero");
            }
            else
            {
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }

            return 0;
        }

        private static int Dividir(int numero, int divisor)
        {
            if(divisor == 0)
            {
                return -1;
            }

            if (divisor > numero)
            {
                return -2;
            }

            return numero / divisor;
        }
    }
}
