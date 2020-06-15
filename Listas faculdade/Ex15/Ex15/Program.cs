using System;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome, senha;

            for(int i = 0; i < 1;) {
                Console.WriteLine("Informe um nome!");
                nome = Console.ReadLine();
                Console.WriteLine("Informe uma senha!");
                senha = Console.ReadLine();
                if (nome.Equals(senha)){
                    Console.WriteLine("Senha é igual ao nome!");
                    continue;
                }
                else
                {
                    Console.WriteLine("Cadastro efetuado com sucesso!");
                    i = 2;
                }
            }
        }
    }
}
