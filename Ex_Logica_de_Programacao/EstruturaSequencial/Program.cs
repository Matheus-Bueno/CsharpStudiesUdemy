using System.Globalization;

namespace EstruturaSequencial
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
            ExercicioNum6();
        }

        public static void ExercicioNum1()
        {
            //Exercício 01
            //Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa.

            Console.WriteLine("Informe um numero inteiro");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe outro numero inteiro");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A soma dos numeros é: {n1 + n2}");
        }

        public static void ExercicioNum2()
        {
            //Exercício 02
            //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais.
            //Fórmula da área: area = π . raio2. Considere o valor de π = 3.14159

            Console.WriteLine("Informe o valor do raio do circulo ");
            double raio = Convert.ToDouble(Console.ReadLine());

            double result = (raio * raio) * 3.14159;

            Console.WriteLine($"A={result:f4}");
        }

        public static void ExercicioNum3()
        {
            //Exercício 03
            //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            Console.WriteLine("Digite um numero Inteiro");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um numero Inteiro");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um numero Inteiro");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um numero Inteiro");
            int d = Convert.ToInt32(Console.ReadLine());

            int diferenca = ((a * b) - (c * d));
            Console.WriteLine(diferenca);
        }

        public static void ExercicioNum4()
        {
            //Exercício 04
            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casasdecimais.

            Console.WriteLine("Informe o Numero do Funcionario");
            int numFunc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o Numero de horas Trabalhadas");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o Valor da hora");
            double valorHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Numero = {numFunc}");
            Console.WriteLine($"Salário = R$ {horas * valorHora:F2}");
        }

        public static void ExercicioNum5()
        {
            //Exercício 05
            //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

            //Peça1
            string[] vetPeca1 = Console.ReadLine().Split(" ");
            int codPeca1 = int.Parse(vetPeca1[0]);
            int numPeca1 = int.Parse(vetPeca1[1]);
            double valPeca1 = double.Parse(vetPeca1[2], CultureInfo.InvariantCulture);

            //Peça2
            string[] vetPeca2 = Console.ReadLine().Split(" ");
            int codPeca2 = int.Parse(vetPeca2[0]);
            int numPeca2 = int.Parse(vetPeca2[1]);
            double valPeca2 = double.Parse(vetPeca2[2], CultureInfo.InvariantCulture);

            double total = (numPeca1 * valPeca1) + (numPeca2 * valPeca2);

            Console.WriteLine($"Valor a Pagar: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");

        }

        public static void ExercicioNum6()
        {
            //Exercício 06
            /*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.*/

            string[] vetValores = Console.ReadLine().Split(" ");
            double a = double.Parse(vetValores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vetValores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vetValores[2], CultureInfo.InvariantCulture);

            double areaTriangulo = a * c / 2;
            Console.WriteLine($"TRIANGULO : {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");

            double areaCirculo = 3.14159 * Math.Pow(c, 2);
            Console.WriteLine($"CIRCULO : {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");

            double areaTrapezio = (a + b) * c / 2;
            Console.WriteLine($"TRAPEZIO : {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");

            double areaQuadrado = b * b;
            Console.WriteLine($"QUADRADO : {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");

            double areaRetangulo = a * b;
            Console.WriteLine($"RETANGULO : {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }

    }
}
