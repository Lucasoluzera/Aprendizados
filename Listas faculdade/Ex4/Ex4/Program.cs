using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double metros = 0, centimetros = 0;
            Console.WriteLine("Informe o valor em metros!");
            try
            {
                metros = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor inválido!");
            }
            centimetros = metros * 100;
            Console.WriteLine("Seu valor em centimetros é: " + centimetros);
        }
    }
}
