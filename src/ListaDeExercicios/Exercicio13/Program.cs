namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //**Imprimir a sequência de Fibonacci até um número informado.**
            //- Exemplo de entrada: Número = 50
            //- Exemplo de saída: Sequência de Fibonacci até 50: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34.

            int numero;
            int antes = 0;
            int atual = 1;
            int proximo;

            Console.WriteLine("## Digite o valor para imprimirmos a sequencia: ##");
            numero = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\n=> 0");

            for (int i = 1; i < numero; i++)
            {
                proximo = antes + atual;
                if (proximo <= numero)
                {
                    Console.WriteLine($"=> {proximo}");
                    antes = atual;
                    atual = proximo;
                }
            }
        }
    }
}
