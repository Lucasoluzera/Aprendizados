using System;
using System.Linq;

namespace ex28
{
    class Program
    {
        static void Main(string[] args)
        {       
            Console.WriteLine("Digite a quantidade de notas a serem computadas");
            int qtdNotas = Convert.ToInt32(Console.ReadLine()); 
            double[] notas = new double[qtdNotas];
            double mediaNotas = 0, total = 0;
            int notasComputadas = qtdNotas, maioresMedia = 0, menoresMedia = 0;


           for(int i = 0; i < qtdNotas;) {

                notas[i] = Convert.ToDouble(Console.ReadLine());
                total += notas[i];
                if(notas[i] >= 7)
                {
                    maioresMedia++;
                }
                if (notas[i] < 7)
                {
                    menoresMedia++;
                }
                i++;

            } 

            Console.WriteLine("Valores na ordem em que foram inseridos");
            for (int i = 0; i < qtdNotas; i++)
            {
                Console.Write(Convert.ToString(notas[i]) + " ");
          
            }
            Console.WriteLine();

            Console.WriteLine("Valores computados: " + notasComputadas);
            Console.WriteLine("Soma de todos os valores é igual a: " + total);
            Console.WriteLine("A media dos valores é: " + total/mediaNotas);
            Console.WriteLine("Houveram " + maioresMedia + " notas acima da media");
            Console.WriteLine("Houveram " + menoresMedia + " notas abaixo da media");
            

        }
    }
}
