using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado = 4, area = 0, dobroArea = 0;
            Console.WriteLine("Um quadrado de lado " + lado);
            area = lado * lado;
            Console.WriteLine("Possui uma área de: " + area + " (lado * lado)");
            dobroArea = area * area;
            Console.WriteLine("E o dobro dela dessa área é: " + dobroArea);
        }
    }
}
