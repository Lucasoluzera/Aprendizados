using System;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1 = 0, lado2 = 0, lado3 = 0;
            Console.WriteLine("Informe o primeiro lado!");
            Boolean triangulo = false;
            try
            {
                lado1 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor informado incorreto!");
                return;
            }
            Console.WriteLine("Informe o segundo lado!");
            try
            {
                lado2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor informado incorreto!");
                return;
            }
            Console.WriteLine("Informe o terceiro lado!");
            try
            {
                lado3 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor informado incorreto!");
                return;
            }

            if (lado1 + lado2 > lado3)
                triangulo = true;

            if (triangulo)
            {
               if(lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("Triângulo Equilátero");
                }
                if(lado1 == lado2 || lado1 == lado3)
                {
                    Console.WriteLine("Triângulo Isósceles");
                }
                if(lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                {
                    Console.WriteLine("Triângulo Escaleno");
                }
            }


        }
    }
}
