using System;
using System.Collections.Generic;
using System.Text;
using _06_ByteBankRH.Sistemas;

namespace _06_ByteBankRH.Funcionarios
{
    public class Designer : FuncionarioAutenticavel
    {
        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando Designer");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}
