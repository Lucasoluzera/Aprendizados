using System;

namespace ex27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[10];
            double soma = 0;
            for (int i = 0; i <= 9;)
            {
                numero[i] = Convert.ToInt32(Console.ReadLine());
                soma += Math.Pow(numero[i], 2);
                i++;
            }
            Console.WriteLine("\nO valor da somatoria de potências é: " + soma);
        }
    }
}
