using System;
using _06_ByteBankRH.Funcionarios;

namespace _06_ByteBankRH.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine($"\nBem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("\nSenha incorreta!");
                return false;
            }
        }
    }
}
