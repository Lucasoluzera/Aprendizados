using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0, raio = 0;
            Console.WriteLine("Por favor informe o raio do circulo");
            try
            {
                raio = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor informado incorreto!");
                return;
            }
            area = (raio * raio) * 3.14;
            Console.WriteLine("Area total do circulo é: " + area);
        }
    }
}
