﻿using System.Globalization;

namespace Ex_Logica_de_Programacao
{
    internal class FormatacaoStrings
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            //interpolação
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é ${preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é ${preco2:F2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine("");
            //Placeholders
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", media);
            Console.WriteLine("Arredondamento (três casas decimais): {0:F3}", media);
            Console.WriteLine("Separador decimal invariant culture: {0}", media.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}