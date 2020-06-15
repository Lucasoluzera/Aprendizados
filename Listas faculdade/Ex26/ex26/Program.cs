using System;

namespace ex26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            Console.WriteLine("Escreva 10 números");
            for (int i = 0; i <= 9;)
            {

                vetor[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }

            Console.WriteLine("Vetor na ordem correta:");

            for (int i = 0;i <= 9;) {
                Console.WriteLine(vetor[i]);
                i++;
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Vetor na ordem inversa:");

            for (int i = 9; i >= 0;)
            {
                Console.WriteLine(vetor[i]);
                i--;
            }
        }
    }
}
