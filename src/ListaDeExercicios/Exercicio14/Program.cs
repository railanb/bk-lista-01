namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //** Calcular o fatorial de um número e exibir o resultado.* *
            //- Exemplo de entrada: Número = 5
            //- Exemplo de saída: 5! = 120.

            int numero;
            int fat = 1;

            Console.WriteLine("## Digite um numero inteiro a ser calculado fatorial: ##");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine($"=> Segue o fatorial do número {numero}: {fat}");
        }
    }
}
