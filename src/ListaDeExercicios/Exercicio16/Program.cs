﻿namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //* Exibir a tabuada de multiplicação do 1 ao 10.* *
           //- Exemplo de saída:

           //  ```
           //  1 x 1 = 1   2 x 1 = 2   3 x 1 = 3...   10 x 1 = 10
           //  1 x 2 = 2   2 x 2 = 4   3 x 2 = 6...   10 x 2 = 20...
           //  1 x 10 = 10  2 x 10 = 20  3 x 10 = 30...   10 x 10 = 100
           //  ```

            for (int i = 1; i <= 10;  i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }

                Console.WriteLine();
            }
        }
    }
}
