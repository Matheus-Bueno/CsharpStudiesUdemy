using System.Globalization;

namespace EstruturaRepetitivaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExercicioNum1();
            //ExercicioNum2();
            //ExercicioNum3();
            //ExercicioNum4();
            //ExercicioNum5();
            //ExercicioNum6();
            ExercicioNum7();
        }

        private static void ExercicioNum1()
        {
            //Exercício 01
            /*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
             * X, se for o caso.*/

            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {

                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static void ExercicioNum2()
        {
            //Exercício 02
            /*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
             * Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
             * essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/

            int n = int.Parse(Console.ReadLine());

            int countIn = 0;
            int countOut = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    countIn++;
                }
                else { countOut++; }
            }

            Console.WriteLine($"{countIn} In");
            Console.WriteLine($"{countOut} Out");
        }

        private static void ExercicioNum3()
        {
            //Exercício 03
            /*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
             * de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
             * conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.*/

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double y = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double z = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (x * 2.0 + y * 3.0 + z * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        private static void ExercicioNum4()
        {
            //Exercício 04
            /*Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
             * segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".*/

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double n1 = double.Parse(valores[0]);
                double n2 = double.Parse(valores[1]);

                if (n2 == 0)
                {
                    Console.WriteLine("Divisão Impossivel");
                }
                else
                {
                    double resultado = n1 / n2;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }

        private static void ExercicioNum5()
        {
            //Exercício 05
            /*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
             * Lembrando que, por definição, fatorial de 0 é 1.*/

            int n = int.Parse(Console.ReadLine());

            int resultado = n;

            if (n == 0) { resultado = 1; }
            else if (n == 1) { resultado = 1; }
            else
            {
                for (int i = n - 1; i != 1; i--)
                {
                    resultado *= i;
                }
            }
            Console.WriteLine(resultado);
        }

        private static void ExercicioNum6()
        {
            //Exercício 06
            //Ler um número inteiro N e calcular todos os seus divisores.

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static void ExercicioNum7()
        {

            //Exercício 07
            /*Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
             * começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.*/

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int quadrado = i * i;
                int cubo = i * i * i;

                Console.WriteLine($"{i} {quadrado} {cubo}");
            }

        }
    }
}
