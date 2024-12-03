using System.Globalization;

namespace EstruturaRepetitivaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ExercicioNum1();
            //ExercicioNum2();
            ExercicioNum3();
        }

        private static void ExercicioNum1()
        {
            //Exercício 01
            /*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha 
            incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser 
            impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/

            string senha = Console.ReadLine() ?? string.Empty;
            while (senha != "2002")
            {
                Console.WriteLine("Senha Invalida");
                senha = Console.ReadLine() ?? string.Empty;
            }
            Console.WriteLine("Acesso Permitido");
        }

        private static void ExercicioNum2()
        {
            //Exercício 02
            /*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
              cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
              menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/

            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            while (x != 0 && y != 0)
            {

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }

                valores = Console.ReadLine().Split(' ');
                x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                y = double.Parse(valores[1], CultureInfo.InvariantCulture);
            }
        }

        private static void ExercicioNum3()
        {
            //Exercício 03
            /*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
            um algoritmo para ler o tipo de combustível abastecido(codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
            4.Fim).Caso o usuário informe um código inválido(fora da faixa de 1 a 4) deve ser solicitado um novo código(até
            que seja válido). O programa será encerrado quando o código informado for o número 4.Deve ser escrito a
            mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
            exemplo.*/

            int opcao = int.Parse(Console.ReadLine());

            int contAlcool = 0;
            int contGaso = 0;
            int contDiesel = 0;

            while (opcao != 4)
            {
                if (opcao == 1)
                {
                    contAlcool += 1;

                }
                else if (opcao == 2)
                {
                    contGaso += 1;
                }
                else if (opcao == 3)
                {
                    contDiesel += 1;
                }
                else { Console.WriteLine("Opcao Invalida"); }

                opcao = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool:" + contAlcool);
            Console.WriteLine("Gasolina:" + contGaso);
            Console.WriteLine("Diesel:" + contDiesel);
        }
    }
}
