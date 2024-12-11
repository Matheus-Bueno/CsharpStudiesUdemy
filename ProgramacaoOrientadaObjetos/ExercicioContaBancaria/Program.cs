using System.Globalization;

namespace ExercicioContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o Numero da Conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o Titular da Conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n) ? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial : ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\nDados da Conta:");
            Console.Write(conta);


            Console.Write("\nEntre um valor para Depósito: ");
            double deposito  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine("\nDados da Conta Atualizados:");
            Console.Write(conta);

            Console.Write("\nEntre um valor para Saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine("\nDados da Conta Atualizados:");
            Console.Write(conta);
        }
    }
}
