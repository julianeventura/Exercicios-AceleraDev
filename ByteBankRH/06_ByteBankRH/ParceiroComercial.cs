using System;
using System.Collections.Generic;
using System.Text;
using _06_ByteBankRH.Sistemas;

namespace _06_ByteBankRH
{
    public class ParceiroComercial:IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
