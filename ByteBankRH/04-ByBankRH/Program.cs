using System;
using _04_ByBankRH.Funcionarios;
using _05_ByteBankRH.Funcionarios;

namespace _05_ByteBankRH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("04!");

            CalcularBonificacao();

            Console.ReadKey();

        }

        public static void CalcularBonificacao()
        { 
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario patricia = new Designer("123.456.789-10");
            patricia.Nome = "Patricia";

            Funcionario roberta = new Diretor("123.456.789-10");
            roberta.Nome = "Roberta";

            Funcionario daniela = new Auxiliar("123.456.789-10");
            daniela.Nome = "Daniela";

            Funcionario camila = new GerenteDeConta("123.456.789-10");
            camila.Nome = "Camila";

            gerenciador.Registrar(patricia);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(daniela);
            gerenciador.Registrar(camila);

            Console.WriteLine($"\nTotal de bonificações do mês: {gerenciador.GetTotalBonificacao()}");

        }
    }
}
