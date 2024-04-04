namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // **Calcular o Índice de Massa Corporal(IMC) e determinar a condição de peso de um adulto.* *
            // -Exemplo de entrada: Peso = 70 kg, Altura = 1.75 m
            // - Fórmula: IMC = Peso / (Altura ^ 2)
            // - Exemplo de saída: IMC = 22.86(Peso normal)

            double peso;
            double altura;
            double imc;

            Console.WriteLine("## Calcular Índice de Massa Corporal(IMC) ## \n");

            Console.Write("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 16.9 )
            {
                Console.WriteLine($"O seu IMC é {imc.ToString("F2")}, sua classificação é Muito abaixo do peso");
            } else if (imc > 17 && imc < 18.4)
            {
                Console.WriteLine($"O seu IMC é {imc.ToString("F2")}, sua classificação é Abaixo do peso");
            }
            else if (imc > 18.5 && imc < 24.9)
            {
                Console.WriteLine($"O seu IMC é {imc.ToString("F2")}, sua classificação é Peso normal");
            }
            else if (imc > 25 && imc < 29.9)
            {
                Console.WriteLine($"O seu IMC é {imc.ToString("F2")}, sua classificação é Acima do peso");
            }
            else if (imc > 30 && imc < 34.9)
            {
                Console.WriteLine($"O seu IMC é {imc.ToString("F2")}, sua classificação é Obesidade grau I");
            }
            else if (imc > 35 && imc < 40)
            {
                Console.WriteLine($"O seu IMC é {imc.ToString("F2")}, sua classificação é Obesidade grau II");
            }
            else
            {
                Console.WriteLine($"O seu IMC é {imc.ToString("F2")}, sua classificação é Obesidade grau III");
            }
        }
    }
}
