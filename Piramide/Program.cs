using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração de variaveis
            string nLinhas;
            int n;
            

            // pedir numero de linhas ao utilizador
            Console.WriteLine("Quantas Linhas");
            nLinhas = Console.ReadLine();
            n = Convert.ToInt32(nLinhas);

            // ciclo
            for (int i = 0; i < n; ++i)
            {
                int esp, ast;
                esp = n - i - 1;
                ast = i * 2 + 1;

                // determinar quantos espaços
                for (int j = 0; j < esp; j++)
                {
                    Console.Write(" ");
                }
                //imprimir asteriscos
                for (int j = 0; j < ast; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
