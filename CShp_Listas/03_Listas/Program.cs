using System;
using System.Collections.Generic;

namespace _03_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("03!");

            var carros = new List<Carro>
            {
                {new Carro(){Name = "Carro1", Cor = "blue", Velocidade = 20} },
                {new Carro(){Name = "Carro2", Cor = "red", Velocidade = 50} },
                {new Carro(){Name = "Carro3", Cor = "green", Velocidade = 10} },
                {new Carro(){Name = "Carro4", Cor = "blue", Velocidade = 50} },
                {new Carro(){Name = "Carro5", Cor = "blue", Velocidade = 30} },
                {new Carro(){Name = "Carro6", Cor = "red", Velocidade = 60} },
                {new Carro(){Name = "Carro7", Cor = "green", Velocidade = 50} },
            };

            //Sort -> vai ordenar os carros pela cor depois pela velocidade

            carros.Sort();

            foreach (Carro carro in carros)
            {
                Console.Write(carro.Cor.PadRight(5) + " ");
                Console.Write(carro.Velocidade.ToString() + " ");
                Console.Write(carro.Name + "\n");
            }

            Console.ReadKey();
        }
    }
}
