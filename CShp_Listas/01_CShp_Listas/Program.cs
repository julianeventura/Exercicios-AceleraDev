using System;

namespace _01_CShp_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("01!");

            //repetição da mesma variável
            int idade_1 = 15;
            int idade_2 = 28;
            int idade_3 = 35;
            int idade_4 = 50;

            int media = (idade_1 + idade_2 + idade_3 + idade_4) / 4;

            Console.WriteLine($"Média: {media}");

            //Array (conjunto de elementos de um mesmo tipo de dados)
            int[] idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            int indice = 4;
            int idadeNoIndice4 = idades[indice];

            Console.WriteLine($"\nValor da variável idades na posição {indice}: {idades[4]}");
            Console.WriteLine($"Valor da variável idadeNoIndice4: {idadeNoIndice4}");

            //valor padrão em um array
            Console.WriteLine($"\nValor padrão (idades[5]): {idades[5]}");

            //Length = número total de elemenos que o array possui
            Console.WriteLine($"\nQuantidade de elementos no array: {idades.Length}");

            //calculo automática da média
            int acumulador = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];
                Console.WriteLine($"\nAcessando o array idades no índice {i}");
                Console.WriteLine($"Valor de idades[{i}] = {idade}");

                acumulador += idade;
            }

            int media2 = acumulador / idades.Length;

            Console.WriteLine($"\nMédia: {media2}");

            int[] idadesArray = new int[]
            {
                15,
                28,
                35,
                50,
                28
            };

            Console.WriteLine($"\nValor da variável idadesArray na posição 4: {idadesArray[4]}");

            //array multidimensional
            int[,] array2 =
            {
                {1, 2, 3},
                {4, 5, 6}
            };

            //número total de elementos
            Console.WriteLine("\nLength: " + array2.Length);

            //número total de linhas
            Console.WriteLine("GetLength(0): " + array2.GetLength(0));

            //número total de colunas
            Console.WriteLine("GetLength(1): " + array2.GetLength(1));
            Console.ReadKey();
        }
    }
}
