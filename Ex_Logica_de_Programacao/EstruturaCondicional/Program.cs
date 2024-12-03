using System.Globalization;

namespace EstruturaCondicional
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
            //ExercicioNum7();
            ExercicioNum8();
        }

        private static void ExercicioNum1()
        {
            //Exercício 01
            //Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não

            int valor = int.Parse(Console.ReadLine());

            if (valor >= 0)
            {
                Console.WriteLine("Não Negativo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }

        private static void ExercicioNum2()
        {
            //Exercício 02
            //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }

        private static void ExercicioNum3()
        {
            //Exercício 03
            //Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.

            string[] valores = Console.ReadLine().Split(' ');
            int num1 = int.Parse(valores[0]);
            int num2 = int.Parse(valores[1]);

            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }

        private static void ExercicioNum4()
        {
            //Exercício 04
            //Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }

        private static void ExercicioNum5()
        {
            //Exercício 05
            //Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.
            /*  1  - Cachorro Quente  R$ 4.00
                2  - X-salada         R$ 4.50
                3  - X-Bacon          R$ 5.00
                4  - Torrada Simples  R$ 2.00
                5  - Refrigerante     R$ 1.50*/

            string[] valores = Console.ReadLine().Split(' ');
            int cod = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);

            double valor = 0;
            if (cod == 1)
            {
                valor = qtd * 4.00;

            }
            else if (cod == 2)
            {
                valor = qtd * 4.50;
            }
            else if (cod == 3)
            {
                valor = qtd * 5.00;
            }
            else if (cod == 4)
            {
                valor = qtd * 2.00;
            }
            else if (cod == 5)
            {
                valor = qtd * 1.50;
            }
            else { Console.WriteLine("Codigo não cadastrado"); }

            Console.WriteLine($"TOTAL: R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        private static void ExercicioNum6()
        {
            //Exercício 06
            //Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            if (valor >= 0 && valor < 25)
            {
                Console.WriteLine("INTERVALO {0,25}");
            }
            else if (valor >= 25 && valor < 50)
            {
                Console.WriteLine("INTERVALO {25,50}");
            }
            else if (valor >= 50 && valor < 75)
            {
                Console.WriteLine("INTERVALO {50,75}");
            }
            else if (valor >= 75 && valor < 100)
            {
                Console.WriteLine("INTERVALO {75,100}");
            }
            else
            {
                Console.WriteLine("Fora Do Intervalo");
            }

        }

        private static void ExercicioNum7()
        {
            //Exercício 07
            //Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0). Se o ponto estiver na origem, escreva a mensagem “Origem”. Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

            /*              |
                Q2          |         Q1
                            |           
            ----------------|----------------------
                            |
                 Q3         |         Q4
                            |
                            |
            */

            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
        private static void ExercicioNum8()
        {
            //Exercício 08
            /*Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$. Leia um valor com duas casas decimais,equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.*/

            /*
                Renda                          |Imposto de Renda
                de R$ 0.00 a R$ 2000.00        |    Isento
                de R$ 2000.01 até R$ 3000.00   |    8%
                de R$ 3000.01 até R$ 4500.00   |    18%
                acima de R$ 4500.00            |    28%
            */

            /*Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
            salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
            de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
            duas casas decimais.*/


            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;

            if (salario >= 0.0 && salario <= 2000.00)
            {
                imposto = 0.0;
            }

            else if (salario >= 2000.01 && salario <= 3000.00)
            {
                imposto = (salario - 2000.0) * 0.08;

            }
            else if (salario >= 3000.01 && salario <= 4500.00)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }

            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }


            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
