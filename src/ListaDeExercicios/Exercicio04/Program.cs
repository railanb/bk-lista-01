namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 4. ** Calcular o salário total de um vendedor.**
                - Exemplo de entrada: Salário base = R$ 1500, Total de vendas = R$ 5000, Comissão(5 % sobre as vendas)
                - Fórmula: Salário total = Salário base + (Total de vendas *Comissão)
                - Exemplo de saída: O salário total do vendedor é R$ 2750.
           */

            decimal salarioBase;
            decimal totalVendas;
            decimal comissao;
            decimal salario;

            Console.WriteLine("## Calcular comissão vendedor ##");

            Console.WriteLine("Qual o salario base? ");
            salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Qual o total de vendas: ");
            totalVendas = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Qual a porcentagem de comissão? ");
            comissao = Convert.ToDecimal(Console.ReadLine());

            salario = salarioBase + (totalVendas * (comissao / 100));

            Console.WriteLine($"O salario total do vendedor é de R$ {salario}");



        }
    }
}
