using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0, total = 0, ir = 0, inss = 0, sindicato = 0, liquido = 0;
            int horas = 0, irPorcento = 0;
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
            
            if(total > 900 && total < 1500) { 
                ir = total * 0.05;
                irPorcento = 5;
            }
            if (total > 1500 && total < 2500) { 
                ir = total * 0.10;
                irPorcento = 10;
            }
            if (total > 2500) { 
                ir = total * 0.20;
                irPorcento = 20;
            }

            inss = total * 0.10;
            sindicato = total * 0.11;
            Console.WriteLine("Slário Bruto: (" + horas + " * " + valor + ")   : R$" + total);
            Console.WriteLine("(-) IR ("+ irPorcento + "%)               : R$" + ir);
            Console.WriteLine("(-) INSS (10%)            : R$" + inss);
            Console.WriteLine("FGTS (11%)                : R$" + sindicato);
            Console.WriteLine("Total de descontos        : R$" + (ir + inss));
            Console.WriteLine("FGTS                      : R$" + sindicato);
            liquido = total - ir - inss;
            Console.WriteLine("Salário Liquido           : R$" + liquido);
        }
    }
}
