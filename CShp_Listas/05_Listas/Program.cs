using System;
using System.Collections.Generic;

namespace _05_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("05!");

            //queue - fifo (first in, first out)

            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            //uma fila pode ser enumerada sem deturbar o conteúdo existente
            Console.WriteLine();
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            Console.WriteLine("Pegar o próximo item no dequeue: {0}",
                numbers.Peek());
            Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            //criar uma cópia da fila
            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            Console.WriteLine("\nConteúdo da primeira cópia: ");

            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }

            //crie uma matriz com o dobro do tamanho da fila
            //copie os elementos da fila começando no meio da matriz

            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            //crie uma segunda fula (queue), usando o construor que aceita um IEnumerable

            Queue<string> queueCopy2 = new Queue<string>(array2);

            Console.WriteLine("\nConteúdo da segunda cópia, com duplicatas e nulos:");
            foreach (string number in queueCopy2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
                queueCopy.Contains("four"));

            Console.WriteLine("\nqueueCopy.Clear()");

            queueCopy.Clear();

            Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);

            Console.ReadKey();
        }
    }
}
