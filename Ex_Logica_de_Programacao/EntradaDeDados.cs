
using System.Globalization;

namespace Ex_Logica_de_Programacao
{
    class EntradaDeDados
    {
        static void Main(string[] args)
        {
            //Exercicio de entrada de Dados
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("");

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Entre com o preço de um produto:");
            double valorProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("");

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(" ");
            string lastName = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);
            Console.WriteLine("");

            Console.WriteLine(nome);
            Console.WriteLine(numQuartos);
            Console.WriteLine(valorProd.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
