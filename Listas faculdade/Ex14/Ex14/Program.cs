using System;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int numMenorQueMil = 0, cen = 0, dez = 0 , uni = 0;
            Console.WriteLine("Informe um valor maior que mil!");
            try
            {
                numMenorQueMil = Convert.ToInt32(Console.ReadLine());
                if (numMenorQueMil >= 1000)
                {
                    Console.WriteLine("Valor informado maior que mil!");
                    return;
                }
            }
            catch
            {
                Console.WriteLine("Valor informado incorreto!");
                return;
            }
            cen = numMenorQueMil / 100;
            dez = (numMenorQueMil%100) / 10;
            uni = (numMenorQueMil % 100) % 10;

            Console.WriteLine(cen + " centenas");
            Console.WriteLine(dez + " dezenas");
            Console.WriteLine(uni + " unidades");
        }
    }
}
