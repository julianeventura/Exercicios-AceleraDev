using System;
using System.IO;

namespace _04_ExceptionExample
{
    public class LeitorDeArquivo
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

            //simulação de arquivo não encontrado
            //throw new FileNotFoundException();

            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");

            //simulação de exceção de leitura de arquivo
            throw new IOException();

            return "Linha do arquivo";
        }

        public void Fechar()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
