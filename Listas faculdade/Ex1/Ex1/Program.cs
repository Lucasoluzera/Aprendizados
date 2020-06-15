using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0;
            int horas = 0;
            Console.WriteLine("Informe o quanto você ganha por hora!");
            try { 
            valor = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor informado incorreto!");
                return;
            }
            Console.WriteLine("Informe quantas horas trabalha no mês!");
            try
            {
                horas = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor informado incorreto!");
                return;
            }
            Console.WriteLine("O seu salário total é: R$" + (valor * horas));
        }
    }
}
