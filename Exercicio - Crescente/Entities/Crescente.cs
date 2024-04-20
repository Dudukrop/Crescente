using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Crescente.Entities
{
    class Crescente
    {
        public int N1 { get; set; }
        public int N2 { get; set; }

        public Crescente(int n1, int n2)
        {
            N1 = n1;
            N2 = n2;
        }

        public string Decrescente(int n1, int n2)
        {
            if (n1 > n2)
                return "Decrescente";

            return "Crescente";
        }

        public override string ToString()
        {
            return Decrescente(N1, N2);
        }
    }
}
