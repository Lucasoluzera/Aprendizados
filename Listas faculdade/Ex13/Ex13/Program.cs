using System;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0 , c = 0, delta = 0;
            Console.WriteLine("Informe o quanto você ganha por hora!");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor informado incorreto!");
                return;
            }
            if(a == 0)
            {
                Console.WriteLine("Valor informado igual a 0!");
                return;
            }

            try
            {
                b = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor informado incorreto!");
                return;
            }
            try
            {
                c = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor informado incorreto!");
                return;
            }
            delta = (b * b) - (4 * a * c);
            if (delta < 0)
            {
                Console.WriteLine("Delta negativo não possui raizes reais!");
                return;
            }
            if (delta == 0)
            {
                Console.WriteLine("Delta igual a 0 possui apenas uma raiz real!");
                return;
            }
            if (delta > 0)
            {
                Console.WriteLine("Delta positivo possui duas raiz real!");
                return;
            }
        }
    }
}
