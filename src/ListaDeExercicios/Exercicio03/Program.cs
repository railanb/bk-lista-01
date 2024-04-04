namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. **Calcular o consumo de combustível por quilômetro.**
                - Exemplo de entrada: Quilometragem inicial = 100 km, Quilometragem final = 200 km, Consumo de combustível = 20 litros
                - Fórmula: Consumo por km = Consumo de combustível / (Quilometragem final - Quilometragem inicial)
                - Exemplo de saída: O consumo de combustível por quilômetro é de 0.1 litros/km.
            */

            decimal kminicial;
            decimal kmfinal;
            decimal consumo;
            decimal consumokm;

            Console.WriteLine("## Consumo de combustivel por km ##");
            Console.WriteLine("Digite a quilometragem inicial:");
            kminicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final:");
            kmfinal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite agora o consumo em litros:");
            consumo = Convert.ToDecimal(Console.ReadLine());

            consumokm = consumo / (kmfinal - kminicial);

            Console.WriteLine($"O consumo de combustível por quilômetro é de {consumokm} litros/km");

            
        }
    }
}
