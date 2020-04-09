using System;
using System.Collections.Generic;

namespace _02_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("02!");

            Console.WriteLine("\nCriar Lista");
            CriarLista();

            Console.WriteLine("\nRemover elemento 'coho' da Lista ");
            RemoverElemento();

            Console.WriteLine("\nNúmeros pares: ");
            GetNumerosPares();

            Console.WriteLine("\nLista de Objeto Galaxy:");
            GetNumerosPares();

            Console.ReadKey();
        }

        public static void CriarLista()
        {
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
        }

        public static void CriarListaDeNovo()
        {
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
        }

        public static void RemoverElemento()
        {
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            salmons.Remove("coho");

            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
        }

        public static void GetNumerosPares()
        {
            var numeros = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int index = numeros.Count; index >= 0; index--)
            {
                if (numeros[index] % 2 == 1)
                {
                    //remove o item da lisa baseado no indice
                    numeros.RemoveAt(index);
                }
            }

            numeros.ForEach(numero => Console.WriteLine(numero + " "));
        }

        public static void GetGalaxiaLista()
        {
            var theGalaxies = new List<Galaxy>
            {
                new Galaxy() {Name = "Tadpole", MegaLightYears = 400},
                new Galaxy() {Name = "Pinwheel", MegaLightYears = 25},
                new Galaxy() {Name = "Milky Way", MegaLightYears = 0},
                new Galaxy() {Name = "Andromeda", MegaLightYears = 3},
            };

            
            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + " " + theGalaxy.MegaLightYears);
            }
        }
    }

}
