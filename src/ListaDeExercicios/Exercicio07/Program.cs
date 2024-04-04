namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            **Verificar se a soma de A + B é menor que C.**
            - Exemplo de entrada: A = 5, B = 3, C = 10
            - Exemplo de saída: A + B é menor que C.''
            */

            int a;
            int b;
            int c;

            Console.WriteLine("## Verificação de soma ##");

            Console.WriteLine("Digite o valor inteiro de A: ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o valor inteiro de B: ");
            b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o valor inteiro de C: ");
            c = Convert.ToInt16(Console.ReadLine());
            
            if ( ( a + b ) < c)
            {
                Console.WriteLine("A + B é menor que C");
            } else if (( a + b ) == c)
            {
                Console.WriteLine("A + B é igual a C");
            }
            else
            {
                Console.WriteLine("A + B não é menor que C");
            }
        }
    }
}
