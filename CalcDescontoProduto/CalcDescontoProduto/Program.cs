using System;

namespace CalcDescontoProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto: ");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto: ");
            double valorProduto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade que deseja comprar: ");
            int qtdProduto = int.Parse(Console.ReadLine());



            if (qtdProduto <= 10)
            {
                double valorTotal = valorProduto * qtdProduto;
                Console.WriteLine("O valor a vista da compra é de R$ " + valorTotal);
            }
            else if (qtdProduto >= 11 && qtdProduto <=  20)
            {
                double desc10 = valorProduto * qtdProduto * 0.90; 
                Console.WriteLine("O valor total da compra com desconto de 10% é de R$ " + desc10);
            }
            else if (qtdProduto >= 21 && qtdProduto <= 50)
            {
                double desc20 = valorProduto * qtdProduto * 0.80;
                Console.WriteLine("O valor total da compra com desconto de 20% é de R$ " + desc20);
            }
            else if (qtdProduto > 50)
            {
                double desc25 = valorProduto * qtdProduto * 0.75;
                Console.WriteLine("O valor total da com´ra com desconto de 25% é de R$ " + desc25);
            }
        }
    }
}
