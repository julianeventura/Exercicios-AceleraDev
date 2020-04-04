using System;
using _06_ByteBankRH.Sistemas;
using _06_ByteBankRH.Funcionarios;

namespace _06_ByteBankRH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("06!");

            UsarSistema();

            Console.ReadKey();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Designer patricia = new Designer("123.456.789-10");
            patricia.Nome = "Patricia";
            patricia.Senha = "123";

            Diretor roberta = new Diretor("123.456.789-10");
            roberta.Nome = "Roberta";
            roberta.Senha = "abc";

            Auxiliar daniela = new Auxiliar("123.456.789-10");
            daniela.Nome = "Daniela";
            daniela.Senha = "xyz";

            GerenteDeConta camila = new GerenteDeConta("123.456.789-10");
            camila.Nome = "Camila";
            camila.Senha = "987";

            ParceiroComercial juliane = new ParceiroComercial();
            juliane.Senha = "123456";

            sistemaInterno.Logar(roberta, "abc");
            sistemaInterno.Logar(patricia, "123");
            sistemaInterno.Logar(daniela, "xyz");
            sistemaInterno.Logar(camila, "987");
            sistemaInterno.Logar(juliane, "123456");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario patricia = new Designer("123.456.789-10");
            patricia.Nome = "Patricia";

            Funcionario roberta = new Diretor("123.456.789-10");
            roberta.Nome = "Roberta";

            Funcionario daniela = new Auxiliar("123.456.789-10");
            daniela.Nome = "Daniela";

            Funcionario camila = new GerenteDeConta("123.456.789-10");
            camila.Nome = "Camila";

            gerenciador.Registrar(patricia);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(daniela);
            gerenciador.Registrar(camila);

            Console.WriteLine($"\nTotal de bonificações do mês: {gerenciador.GetTotalBonificacao()}");

        }
    }
}
