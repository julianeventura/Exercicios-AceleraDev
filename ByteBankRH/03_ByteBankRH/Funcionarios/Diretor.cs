using System;
using System.Collections.Generic;
using System.Text;
using _05_ByteBankRH.Funcionarios;

namespace _05_ByteBankRH.Funcionarios
{
    public class Diretor : Funcionario
    {
        //CLASSES HERDADAS

        //public string Nome { get; set; }
        //public string CPF { get; set; }
        //public double Salario { get; set; }

        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando Diretor");
        }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
