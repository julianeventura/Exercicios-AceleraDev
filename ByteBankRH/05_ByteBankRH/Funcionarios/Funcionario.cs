using System;
using System.Collections.Generic;
using System.Text;

namespace _05_ByteBankRH.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;
            Console.WriteLine("Criando Funcionario");

            CPF = cpf;
            Salario = salario;
        }

        public abstract double GetBonificacao();
        //{
        //    return 0.1 * Salario;
        //}lo

        public abstract void AumentarSalario();
        //{
        //    Salario *= 1.1;
        //}
    }
}
