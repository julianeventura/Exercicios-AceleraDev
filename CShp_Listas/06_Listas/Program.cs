using System;
using System.Collections.Generic;

namespace _06_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("06!");

            //stack - lifo (last in, first out)

            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");

            //uma fila pode ser enumerada sem deturbar o conteúdo existente
            Console.WriteLine();
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nPopping '{0}'", numbers.Pop());
            Console.WriteLine("Pegar o próximo item no destack: {0}",
                numbers.Peek());
            Console.WriteLine("Popping '{0}'", numbers.Pop());

            //criar uma cópia da fila
            Stack<string> stackCopy = new Stack<string>(numbers.ToArray());

            Console.WriteLine("\nConteúdo da primeira cópia: ");

            foreach (string number in stackCopy)
            {
                Console.WriteLine(number);
            }

            //crie uma matriz com o dobro do tamanho da fila
            //copie os elementos da fila começando no meio da matriz

            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            //crie uma segunda fula (queue), usando o construor que aceita um IEnumerable

            Stack<string> stackCopy2 = new Stack<string>(array2);

            Console.WriteLine("\nConteúdo da segunda cópia, com duplicatas e nulos:");
            foreach (string number in stackCopy2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
                stackCopy.Contains("four"));

            Console.WriteLine("\nqueueCopy.Clear()");

            stackCopy.Clear();

            Console.WriteLine("\nqueueCopy.Count = {0}", stackCopy.Count);

            Console.ReadKey();
        }
    }
}
