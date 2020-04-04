﻿using System;
using System.Collections.Generic;
using System.Text;
using _05_ByteBankRH.Sistemas;

namespace _05_ByteBankRH.Funcionarios
{
    public class GerenteDeConta : Autenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando Gerente de Conta");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }
    }
}
