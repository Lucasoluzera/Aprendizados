using System;
public class MainClass
{
    public static void Main()
    {
        long fibonnaci = 1;
        long num1 = 0;
        long num2 = 1;


        for (int i = 0; i <= 12; i++)
        {
            fibonnaci = num1 + num2;
            num1 = num2;
            num2 = fibonnaci;
            Console.Write(", " + fibonnaci);

        }
    }
}