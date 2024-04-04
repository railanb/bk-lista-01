namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5. **Calcular a média ponderada de duas provas realizadas por um aluno.**
                - Exemplo de entrada: Nota da primeira prova = 7, Peso da primeira prova = 0.4, Nota da segunda prova = 8, Peso da segunda prova = 0.6
                - Fórmula: Média ponderada = (Nota da primeira prova * Peso da primeira prova) + (Nota da segunda prova * Peso da segunda prova)
                - Exemplo de saída: A média ponderada do aluno é 7.6.
             */

            decimal prova1;
            decimal prova2;
            decimal pesoProva1;
            decimal pesoProva2;
            decimal media;
                        
            Console.WriteLine("## Calculadora média ponderada ##");

            Console.WriteLine("Digite a nota da primeira prova: ");
            prova1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o peso da primeira prova: ");
            pesoProva1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda prova: ");
            prova2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o peso da segunda prova: ");
            pesoProva2 = Convert.ToDecimal(Console.ReadLine());

            media = (prova1 * pesoProva1) + (prova2 * pesoProva2);

            Console.WriteLine($"A média ponderada do aluno é {media}");

        }
    }
}
