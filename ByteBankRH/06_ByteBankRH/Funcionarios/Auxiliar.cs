using System;
using System.Collections.Generic;
using System.Text;
using _06_ByteBankRH.Sistemas;

namespace _06_ByteBankRH.Funcionarios
{
    public class Auxiliar : FuncionarioAutenticavel
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Criando Auxiliar");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }

}

