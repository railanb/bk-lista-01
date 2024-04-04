using System;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**Identificar se um número é par ou ímpar.* *
            //- Exemplo de entrada: Número = 7
            //- Exemplo de saída: O número é ímpar.

            int numero;
            int num = 0;

            Console.WriteLine("## Identificador de número (par ou impar");

            Console.Write("Digite o numero que deseja verificar: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    num =+ 1;
                    
                }
            }

            if (num == 2)
            {
                Console.WriteLine($"O numero {numero} é primo");
            }
            else
            {
                Console.WriteLine($"O numero {numero} não é primo");
            }

        }
    }
    
}
