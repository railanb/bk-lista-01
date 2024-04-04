using System.Numerics;
using System.Runtime.Intrinsics.X86;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // **Realizar uma operação com base em dois valores inteiros A e B.* *
            //- Exemplo de entrada: A = 3, B = 3
            //- Exemplo de saída: A + B = 6.

            int a;
            int b;
            int c;

            Console.WriteLine("## Calculadora de soma dois valores inteiros ##");

            Console.Write("A = ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("B = ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;

            Console.WriteLine($"A + B = {c}");

        }
    }
}
