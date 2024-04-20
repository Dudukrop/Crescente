using System;
using Exercicio___Crescente.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());


            while (n1 != n2)
            {
                Crescente crescente = new Crescente(n1, n2);
                Console.WriteLine(crescente);

                Console.WriteLine("Digite outros dois numeros:");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
            }
        }
    }
}
