using System;
using _05_ByteBankRH.Funcionarios;

namespace _05_ByteBankRH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("02!");

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carolina = new Funcionario();
            carolina.Nome = "carolina";
            carolina.CPF = "123.456.789-10";
            carolina.Salario = 2000;

            Console.WriteLine($"Nome completo: {carolina.Nome}");
            Console.WriteLine($"Bonificação: {carolina.GetBonificacao()}");

            gerenciador.Registrar(carolina);

            Diretor roberta = new Diretor();
            roberta.Nome = "roberta";
            roberta.CPF = "098.765.432-11";
            roberta.Salario = 5000;

            Console.WriteLine($"\nNome completo: {roberta.Nome}");
            Console.WriteLine($"Bonificação: {roberta.GetBonificacao()}");

            gerenciador.Registrar(roberta);

            Console.WriteLine($"\nTotal de bonificações: {gerenciador.GetTotalBonificacao()}");

            Funcionario robertaFuncionario = roberta;

            Console.WriteLine($"\nRoberta - referencia de Diretor: {roberta.GetBonificacao()}");
            Console.WriteLine($"\nRoberta - referencia de Funcionario: {robertaFuncionario.GetBonificacao()}");

            Console.ReadKey();
        }
    }
}
