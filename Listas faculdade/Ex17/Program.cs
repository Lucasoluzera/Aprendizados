using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_16
{
    class Program
    {

        static void Main(string[] args)
        {
            int expoente, base, cont, pot;

            Console.WriteLine("Escreva qual sera a base ");
            base = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Escreva qual sera o expoente: ");
            expoente = Int32.Parse(Console.ReadLine());

            cont = 0;
            pot = 1;

            while (cont <= expoente) {
                pot = expoente * base;
                cont = cont + 1;
            }
            Console.WriteLine("O resultado é : " + pont);

        }
    }
}
