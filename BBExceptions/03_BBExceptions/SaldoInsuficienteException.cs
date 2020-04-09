using System;

namespace _03_BBExceptions
{
    //todas as exceptions herdam da classe Exception
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        
        //boa prática: fazer um construtor vazio com o nome da Exception
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            :this("Tentativa de saque do valor de " + valorSaque 
                 + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
    }
}
