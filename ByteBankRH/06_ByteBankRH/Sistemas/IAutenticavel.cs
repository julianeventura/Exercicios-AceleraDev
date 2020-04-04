using System;
using System.Collections.Generic;
using System.Text;

namespace _06_ByteBankRH.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
