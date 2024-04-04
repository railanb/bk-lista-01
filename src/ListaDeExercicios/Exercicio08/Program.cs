namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * **Ordenar três valores inteiros e diferentes em ordem decrescente.**
                - Exemplo de entrada: 5, 10, 3
                - Exemplo de saída: Os números em ordem decrescente são 10, 5, 3.
             */

            Console.WriteLine("## Ordenar numeros em ordem decrescente ## \n");

            int[] nums = new int[3];

            Console.Write("Digite o primeiro valor interiro: ");
            nums[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor inteiro: ");
            nums[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor inteiro: ");
            nums[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nOs valores inteiros digitados em ordem decrescente: ");

            Array.Sort(nums);
            Array.Reverse(nums);

            foreach (int i in nums)
            {
                Console.WriteLine($"##  {i}");
            }
        }
    }
}
