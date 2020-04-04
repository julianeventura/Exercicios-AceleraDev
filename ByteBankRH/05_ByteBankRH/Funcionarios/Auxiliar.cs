using System;
using System.Collections.Generic;
using System.Text;
using _05_ByteBankRH.Sistemas;

namespace _05_ByteBankRH.Funcionarios
{
    public class Auxiliar : Autenticavel
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

