using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao_16
{
    class Program
    {
        private static object cons;

        static void Main(string[] args)
        {
            Double numero, calculo;

            numero = 1.99;



            for (int i = 1; i <= 50;)
            {
                calculo = i * numero;
                Console.WriteLine(i +  " = " + calculo);
                i++;
            }
        }
    }
}
