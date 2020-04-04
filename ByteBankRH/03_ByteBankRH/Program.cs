using System;
using _05_ByteBankRH.Funcionarios;

namespace _05_ByteBankRH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("03!");

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carolina = new Funcionario(2000, "123.456.789-10");
            carolina.Nome = "carolina";
            //carolina.CPF = "123.456.789-10";
            //carolina.Salario = 2000;

            Console.WriteLine($"Nome completo: {carolina.Nome}");
            Console.WriteLine($"Bonificação: {carolina.GetBonificacao()}");

            Console.WriteLine($"Total de funcionários: {Funcionario.TotalDeFuncionarios}");

            gerenciador.Registrar(carolina);

            Diretor roberta = new Diretor("098.765.432-11");
            roberta.Nome = "roberta";
            //roberta.CPF = "098.765.432-11";
            //roberta.Salario = 5000;

            Console.WriteLine($"\nNome completo: {roberta.Nome}");
            Console.WriteLine($"Bonificação: {roberta.GetBonificacao()}");

            gerenciador.Registrar(roberta);
            Console.WriteLine($"Total de funcionários: {Funcionario.TotalDeFuncionarios}");

            Console.WriteLine($"\nTotal de bonificações: {gerenciador.GetTotalBonificacao()}");

            carolina.AumentarSalario();
            Console.WriteLine($"\nNovo salário de Carolina: {carolina.Salario}");
            Console.WriteLine($"\nNovo salário de Roberta: {roberta.Salario}");

            Console.ReadKey();
        }
    }
}
