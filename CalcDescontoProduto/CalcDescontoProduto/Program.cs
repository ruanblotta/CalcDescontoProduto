using System;

namespace CalcDescontoProduto
{
    class Program
    {
        static void Main(string[] args)
        {

            AplicaDesconto desconto = new AplicaDesconto();

            Console.WriteLine("Digite o nome do produto: ");
            desconto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto: ");
            desconto.ValorProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade que deseja comprar: ");
            desconto.QtdProduto = int.Parse(Console.ReadLine());

            desconto.CalcDesconto();
          
        }
    }
}
