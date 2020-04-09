using System;

namespace _01_BBExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01!");

            ContaCorrente conta = new ContaCorrente(867, 86712540);

            //conta.Agencia = 982; não é possível fazer isso pq a propriedade é somente leitura 

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            try
            {
                ContaCorrente conta2 = new ContaCorrente(0, 0);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Argumento com problema: " + e.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
