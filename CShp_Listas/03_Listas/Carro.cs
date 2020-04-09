using System;

namespace _03_Listas
{
    public class Carro : IComparable<Carro>
    {
        public string Name { get; set; }
        public int Velocidade { get; set; }
        public string Cor { get; set; }

        public int CompareTo(Carro other)
        {
            int compare = string.Compare(this.Cor, other.Cor, true);

            if(compare == 0)
            {
                compare = this.Velocidade.CompareTo(other.Velocidade);

                compare = -compare;
            }

            return compare;
        }
    }
}
