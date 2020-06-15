using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura = 0 , pesoIdeal = 0;
            Console.WriteLine("Por favor informe sua altura!");
            try
            {
                altura = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
            Console.WriteLine("Valor incorreto!");
                return;
            }
            pesoIdeal = (72.7 * altura) - 58;

            Console.WriteLine("Seu peso ideal é: " + pesoIdeal);

        }
    }
}
