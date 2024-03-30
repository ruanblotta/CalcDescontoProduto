using System;
using System.Collections.Generic;
using System.Text;

namespace CalcDescontoProduto
{
    public class AplicaDesconto
    {
        public string NomeProduto;
        public double ValorProduto;
        public int QtdProduto;

        public void CalcDesconto()
        {

            if (QtdProduto <= 10)
            {
                double valorTotal = ValorProduto * QtdProduto;
                Console.WriteLine("O valor a vista da compra é de R$ " + valorTotal);
            }
            else if (QtdProduto >= 11 && QtdProduto <= 20)
            {
                double desc10 = ValorProduto * QtdProduto * 0.90;
                Console.WriteLine("O valor total da compra com desconto de 10% é de R$ " + desc10.ToString("F2"));
            }
            else if (QtdProduto >= 21 && QtdProduto <= 50)
            {
                double desc20 = ValorProduto * QtdProduto * 0.80;
                Console.WriteLine("O valor total da compra com desconto de 20% é de R$ " + desc20.ToString("F2"));
            }
            else if (QtdProduto > 50)
            {
                double desc25 = ValorProduto * QtdProduto * 0.75;
                Console.WriteLine("O valor total da com´ra com desconto de 25% é de R$ " + desc25.ToString("F2"));
            }
        }
    }
}
