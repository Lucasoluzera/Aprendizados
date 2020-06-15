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
            int calc, num = 0;


            Console.Write("Digite um numero para ser feito a taboada do 1 ao 10\n");
            try { 
            num = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Valor inválido");
            }
            for (int i = 1; i <= 10; )
            { 
                calc = i * num;
                Console.WriteLine(num + " X " + i + " = " + calc);
                i++;
            }

            Console.ReadKey();
        }
    }
}
