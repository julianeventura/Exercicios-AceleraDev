using System;
using System.Collections.Generic;
using System.Text;
using _06_ByteBankRH.Sistemas;

namespace _06_ByteBankRH.Funcionarios
{
    public class Desenvolvedor : FuncionarioAutenticavel
    {
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Criando Desenvolvedor");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.15;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.1;
        }
    }
}
