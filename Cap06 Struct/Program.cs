using System;
using System.Globalization;

namespace Cap06_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de produtos.");
            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Digite o nome do produto");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Produto(nome, valor);

            }
            double soma = 0.0;

            for (int i = 0; i < n; i++)
            {

                soma += vect[i].Valor;

            }
            double media = soma / n;

            Console.WriteLine("Preço médio R$ {0}", media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
