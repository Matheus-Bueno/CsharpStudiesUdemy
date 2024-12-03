using Introducao.ClassesIntroducao;
using System.Globalization;

namespace IntroducaoDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                //Exercicio1();
                //Exercicio2();
                //Retangulos();
                //FuncionariosSalario();
                //MediaAluno();
                Cotacao();
            }

            static void Exercicio1()
            {
                Pessoas primeira, segunda;
                primeira = new Pessoas();
                segunda = new Pessoas();

                Console.WriteLine("Informe o nome da Primeira Pessoa");
                primeira.Nome = Console.ReadLine();
                Console.WriteLine("Informe a idade da Primeira Pessoa");
                primeira.Idade = int.Parse(Console.ReadLine());


                Console.WriteLine("Informe o nome da segunda Pessoa");
                segunda.Nome = Console.ReadLine();
                Console.WriteLine("Informe a idade da segunda Pessoa");
                segunda.Idade = int.Parse(Console.ReadLine());


                Console.WriteLine("Dados da primeira pessoa:");
                Console.WriteLine($"Nome : {primeira.Nome}");
                Console.WriteLine($"Idade : {primeira.Idade}");

                Console.WriteLine("Dados da segunda pessoa:");
                Console.WriteLine($"Nome : {segunda.Nome}");
                Console.WriteLine($"Idade : {segunda.Idade}");

                if (primeira.Idade >= segunda.Idade)
                {
                    Console.WriteLine($"Pessoa mais velha: {primeira.Nome}");
                }
                else { Console.WriteLine($"Pessoa mais velha: {segunda.Nome}"); }
            }

            static void Exercicio2()
            {
                Funcionarios x, y;
                x = new Funcionarios();
                y = new Funcionarios();

                Console.WriteLine("Informe o nome do Primeiro Funcionarios");
                x.Nome = Console.ReadLine();
                Console.WriteLine("Informe a salario da Primeira Funcionarios");
                x.Salario = double.Parse(Console.ReadLine());


                Console.WriteLine("Informe o nome do segundo Funcionarios");
                y.Nome = Console.ReadLine();
                Console.WriteLine("Informe a salario do segundo Funcionarios");
                y.Salario = double.Parse(Console.ReadLine());


                Console.WriteLine("Dados do primeiro Funcionarios:");
                Console.WriteLine($"Nome : {x.Nome}");
                Console.WriteLine($"Idade : {x.Salario}");

                Console.WriteLine("Dados do segundo Funcionarios:");
                Console.WriteLine($"Nome : {y.Nome}");
                Console.WriteLine($"Idade : {y.Salario}");

                double media = (x.Salario + y.Salario) / 2;

                Console.WriteLine($"Salário Médio = {media}");
            }

            static void Retangulos()
            {
                Retangulo ret = new Retangulo();

                Console.WriteLine("Entre a largura e altura do retângulo:");
                ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Area =" + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Perimetro =" + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Area =" + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            }

             static void FuncionariosSalario()
            {
                FuncionarioSalario funcionario = new FuncionarioSalario();

                Console.Write("Nome: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("Salario bruto: ");
                funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Imposto: ");
                funcionario.Impostos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine(funcionario);

                Console.Write("Digite a porcentagem para aumentar o salário:");
                funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

                Console.WriteLine(funcionario);
            }

             static void MediaAluno()
            {
                Aluno aluno = new Aluno();

                Console.Write("Nome Do Aluno: ");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("Digite as 3 notas do aluno: ");
                aluno.PrimeiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aluno.SegundaNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aluno.TerceiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Nota Final = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

                if (aluno.Aprovado())
                {
                    Console.WriteLine("APROVADO");
                }
                else
                {
                    Console.WriteLine("REPROVADO");
                    Console.WriteLine($"FALTOU {aluno.FaltouQuantosPontos().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
                }

            }

             static void Cotacao()
            {
                Console.WriteLine("Qual a cotção do Dólar? ");
                double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Quantos dolares voce vai comprar? ");
                double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Valor a Ser Pago em reais é = R$ " + ConversorDeMoeda.ValorASerPago(cotacao, dolares).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
