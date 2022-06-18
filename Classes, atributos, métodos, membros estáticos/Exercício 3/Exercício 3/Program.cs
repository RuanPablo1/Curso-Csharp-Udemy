using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercício_3 {
    internal class Program {

        static void Main(string[] args) {

            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto: " + produto);

            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque:");
            int quantidade = int.Parse(Console.ReadLine());

            produto.AdicionarProdutos(quantidade);

            Console.WriteLine("\nDados do produto: " + produto);

            Console.Write("\nDigite o número de produtos a ser removido do estoque:");
            quantidade = int.Parse(Console.ReadLine());

            produto.RemoverProdutos(quantidade);

            Console.WriteLine("\nDados do produto: " + produto);
        }
    }
}

/* Fazer um programa para ler os dados de um produto em estoque (nome, preço e
quantidade no estoque). Em seguida:

• Mostrar os dados do produto (nome, preço, quantidade no estoque, valor total no
estoque)
• Realizar uma entrada no estoque e mostrar novamente os dados do produto
• Realizar uma saída no estoque e mostrar novamente os dados do produto */