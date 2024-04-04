namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            6. * *Calcular a área de um terreno retangular.**
                - Exemplo de entrada: Comprimento do terreno = 10 metros, Largura do terreno = 5 metros
                - Fórmula: Área = Comprimento * Largura
                - Exemplo de saída: A área do terreno é 50 metros quadrados.
            */

            decimal comprimento;
            decimal largura;
            decimal area;

            Console.WriteLine("Calculando área do terreno: ");

            Console.WriteLine("Digite o comprimento do terreno: ");
            comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a largura do terreno: ");
            largura = Convert.ToDecimal(Console.ReadLine());

            area = comprimento * largura;

            Console.WriteLine($"A área do terreno é {area} metros quadrados");

        }
    }
}
