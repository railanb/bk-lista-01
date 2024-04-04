namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Converter a temperatura de graus Fahrenheit para graus Celsius
                - Fórmula: Celsius = (Fahrenheit - 32) * 5/9
                - Exemplo de saída: A temperatura em Celsius é 20 °C.
             */
            decimal celsius;
            decimal fahrenheit;

            Console.WriteLine("## Conversor Fahrenheit para Celsius ##");
            Console.WriteLine("Quantos graus em Fahrenheit?");
            fahrenheit = Convert.ToDecimal(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"A temperatura em Celsius é {(celsius).ToString("F2")}°C");

            Console.ReadKey();
        }
    }
}
