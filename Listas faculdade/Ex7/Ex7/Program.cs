using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0, total = 0, ir = 0, inss = 0, sindicato = 0, liquido = 0;
            int horas = 0;
            Console.WriteLine("Informe o quanto você ganha por hora!");
            try
            {
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
            total = valor * horas;
            ir = total * 0.11;
            inss = total * 0.08;
            sindicato = total * 0.05;
            Console.WriteLine("O seu salário bruto é: R$" + total);
            Console.WriteLine("O valor pago para o Imposto de Renda R$" + ir);
            Console.WriteLine("O valor pago para o INSS R$" + inss);
            Console.WriteLine("O valor pago para o Sindicato R$" + sindicato);

            liquido = total - ir - inss - sindicato;


            Console.WriteLine("O seu salário líquido é: R$" + liquido);
        }
    }
}
