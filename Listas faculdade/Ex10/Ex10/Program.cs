using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            String turno;

            Console.WriteLine("Informe em que turno você estuda.  Matutino: M, Vespertino: V ou Noturno: N");

            turno = Console.ReadLine();

            if (turno.ToLower().Equals("m"))
            {
                Console.WriteLine("Bom dia! :)");
                return;
            }
            else if (turno.ToLower().Equals("v"))
            {
                Console.WriteLine("Boa tarde! :)");
                return;
            }
            else if(turno.ToLower().Equals("n"))
            {
                Console.WriteLine("Boa noite! :)");
                return;
            }
            else
            {
                Console.WriteLine("Valor inválido! :(");
                return;
            }
        }
    }
}
