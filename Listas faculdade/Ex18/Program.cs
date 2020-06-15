using System;
public class MainClass
{
    public static void Main()
    {
        long fibonnaci = 1;
        long cont;
        long num1 = 0;
        long num2 = 1;
        long valor;

        Console.WriteLine("Digite um numero ");
        valor = long.Parse(Console.ReadLine());

        for (int i = 0; i <= cont; i++)
        {
            fibonnaci = num1 + num2; 
            num1 = num2;
            num2 = fibonnaci;
            Console.Write(", " + fibonnaci);

        }
    }
}