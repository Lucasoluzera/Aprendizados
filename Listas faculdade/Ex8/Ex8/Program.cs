using System;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaPintada = 0, somenteGalao = 0, somenteLata = 0, misturadaGalao = 1, misturadaLata = 0, areaGalao = 0, areaLata = 0;
            Console.WriteLine("Por favor informe a área a ser pintada!");

            try
            {
                areaPintada = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Valor incorreto!");
                return;
            }


            somenteLata = areaPintada / 108;
            somenteGalao = areaPintada / 21.6;

            //Caso nao tenha pintado tudo adicionar um a mais para pintar TODO o espaco
            if ((areaPintada / 108) == 0)
                somenteLata++;
            
            if ((areaPintada / 21.6) == 0)
                somenteGalao++;


            //lata 108 galao 21,6
            //Faz um for para adicionar quantas latas ou galões necessários
            areaPintada = areaPintada + areaPintada * 0.10;

            for (int i= 0 ; i < 1;)
            {
                areaGalao = areaGalao + 21.6;
                areaLata = areaLata + 108;
                if(areaPintada > areaGalao || areaPintada != 0)
                {
                    misturadaGalao++;
                    areaPintada = areaPintada - (areaGalao * misturadaGalao);

                }
                if (areaPintada > areaLata)
                {
                    misturadaLata++;
                    areaPintada =  areaPintada - areaLata * misturadaLata;

                }
                if(areaPintada <= 0)
                {
                    i = 2;
                }
            }

            Console.WriteLine("Comprar apenas " + Convert.ToInt32(somenteLata) + " Lata(s) de 18L");
            Console.WriteLine("Comprar apenas " + Convert.ToInt32(somenteGalao) + " Galão(ões) de 3,6L");
            Console.WriteLine("Combinacões de latas e galões ");
            Console.WriteLine("Galões " + misturadaGalao);
            Console.WriteLine("Latas " + misturadaLata);
        }
    }
}
