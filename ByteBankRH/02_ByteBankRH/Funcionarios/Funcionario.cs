using System;
using System.Collections.Generic;
using System.Text;

namespace _05_ByteBankRH.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        {
            return 0.1 * Salario;
        }
    }
}
