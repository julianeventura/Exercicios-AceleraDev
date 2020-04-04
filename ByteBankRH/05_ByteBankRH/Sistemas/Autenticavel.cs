using System;
using System.Collections.Generic;
using System.Text;
using _05_ByteBankRH.Funcionarios;

namespace _05_ByteBankRH.Sistemas
{
    public abstract class Autenticavel:Funcionario
    {
        public Autenticavel (double salario, string cpf):base(salario, cpf)
        {
        }

        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
