namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Calcular o volume de uma caixa retangular.
                - Exemplo de entrada: Altura = 5, Largura = 3, Comprimento = 2
                - Fórmula: Volume = Altura * Largura * Comprimento
                - Exemplo de saída: O volume da caixa é 30 unidades cúbicas.*/

            decimal altura;
            decimal largura;
            decimal comprimento;
            decimal volume;

            Console.WriteLine("## Calcular o volume ##\n");

            Console.WriteLine("Digite a altura: ");
            altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a largura: ");
            largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a comprimentro: ");
            comprimento = Convert.ToDecimal(Console.ReadLine());

            volume = altura * largura * comprimento;

            Console.WriteLine($"O volume da caixa é {volume} unidades cúbicas");

            Console.ReadKey();
        }
    }
}
