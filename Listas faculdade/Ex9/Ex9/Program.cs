using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            String sexo;
            
            Console.WriteLine("Informe seu sexo. Feminino: F ou Masculino: M!");

            sexo = Console.ReadLine();

            if (sexo.ToLower().Equals("f"))
            {
                Console.WriteLine("Sexo Feminino");
                return;
            }
            else if (sexo.ToLower().Equals("m"))
            {
                Console.WriteLine("Sexo Masculino");
                return;
            }
            else
            {
                Console.WriteLine("Sexo Indefinido.");
                return;
            }
        }
    }
}
