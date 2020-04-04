using System;
using System.Collections.Generic;
using System.Text;
using _05_ByteBankRH.Sistemas;

namespace _05_ByteBankRH.Funcionarios
{
    public class Desenvolvedor : Autenticavel
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
