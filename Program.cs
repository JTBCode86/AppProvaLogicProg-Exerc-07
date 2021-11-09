using System;
using System.Globalization;

namespace AppProvaLogicProg_Exerc_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com variáveis - C#.
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idate = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo o preço é: {1} R$", produto1, preco1);
            Console.WriteLine("{0}, cujo o preço é: {1} R$", produto2, preco2);
            Console.WriteLine("Registro: {0} anos de idade, codigo {1} e gênero: {2}", idate,codigo,genero);
            Console.WriteLine("Média com oito casas decimais: {0}", media.ToString("F8"));
            Console.WriteLine("Média com três casas decimais: {0}", media.ToString("F3"));
            Console.WriteLine("Separador decimal invariant cuture: {0}", media.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
