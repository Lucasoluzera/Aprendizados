using System;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura = 0, pesoIdeal = 0;
            String sexo;
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
            Console.WriteLine("Informe seu sexo. Mulher: M ou Homem: H!");

            sexo = Console.ReadLine();

            if (sexo.ToLower().Equals("h"))
            {
                pesoIdeal = (72.7 * altura) - 58;
            }else if (sexo.ToLower().Equals("m"))
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else
            {
                Console.WriteLine("Informe corretamente seu sexo, sexos alternativos ainda não cadastrados.");
                return;
            }

            Console.WriteLine("Seu peso ideal é: " + pesoIdeal);

        }
    }
}
