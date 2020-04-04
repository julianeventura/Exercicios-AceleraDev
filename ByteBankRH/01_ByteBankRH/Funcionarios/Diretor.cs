using System;
using System.Collections.Generic;
using System.Text;

namespace _01_ByteBankRH.Funcionarios
{
    public class Diretor
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        {
            return Salario;
        }
    }
}
