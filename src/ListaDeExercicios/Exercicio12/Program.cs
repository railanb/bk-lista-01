using System;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // **Gerar e escrever os números ímpares entre 100 e 200.* *
            //-Exemplo de saída: 101, 103, 105, ..., 199.

            int i;           
            for (i = 100; i <= 200; i++)
            {
                if (i % 2 == 1) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
