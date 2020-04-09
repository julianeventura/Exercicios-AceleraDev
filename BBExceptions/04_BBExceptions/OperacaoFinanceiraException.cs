using System;

namespace _04_BBExceptions
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {
        }

        public OperacaoFinanceiraException(string message):base(message)
        {
        }

        public OperacaoFinanceiraException(string mensagem, Exception innerException)
            : base(mensagem, innerException)
        {
        }
    }
}
