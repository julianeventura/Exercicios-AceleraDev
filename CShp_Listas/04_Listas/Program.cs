using System;
using System.Collections.Generic;

namespace _04_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("04!");

            //Criar uma nova instancia de sorted list
            SortedList<string, string> openWith = new SortedList<string, string>();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            //exception para itens duplicados
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("\nUm elemento com a chave = \"txt\" já existe.");
            }

            Console.WriteLine("\nChave = \"rtf\", valor = {0}.", openWith["rtf"]);

            openWith["rtf"] = "winword.exe";
            Console.WriteLine("\nChave = \"rtf\", valor = {0}.", openWith["rtf"]);

            //se a chave não existir, a configuração do indexador para essa chave add um novo par de chave/valor
            openWith["doc"] = "winword.exe";

            try
            {
                Console.WriteLine("\nChave = \"tif\", valor = {0}", openWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("\nChave = \"tif\" não encontrada.");
            }

            string value = "";

            //o método TryGetValue pode ser uma maneira eficiente de recuperar valores
            //sintaxe: tenta achar a chave escolhida
            //caso não encontre, retorna o valor que pode ser utilizado em seguida dentro do if

            if(openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("\nChave = \"tif\", valor = {0}", value);
            }
            else
            {
                Console.WriteLine("\nChave = \"tif\" não encontrada");
            }

            if(!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("\nValor adicionada para chave = \"ht\", {0}", openWith["ht"]);
            }

            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Chave = {0}, Valor = {1}", kvp.Key, kvp.Value);
            }

            //Para recuperar valores isolados
            IList<string> iListValues = openWith.Values;

            Console.WriteLine();
            foreach (string s in iListValues)
            {
                Console.WriteLine("Valor = {0}", s);
            }

            //A propriedade Values é uma forma eficiente de recuperar valores pelo index
            Console.WriteLine("\nRecuperando valores usando Values");
            Console.WriteLine("Propriedade: Values[2] = {0}", openWith.Values[2]);

            //Para recuperar chaves isoladas, utiliza-se a propriedade Keys
            IList<string> iListKeys = openWith.Keys;

            Console.WriteLine();
            foreach (string s in iListKeys)
            {
                Console.WriteLine("Chave = {0}", s);
            }

            Console.WriteLine("\nRecuperando chaves usando Keys" + 
                " propriedade: Keys[2] = {0}", openWith.Keys[2]);

            Console.WriteLine("\nRemove \"doc\"");
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Chave \"doc\" não encontrada.");
            }

            Console.ReadKey();
        }
    }
}
