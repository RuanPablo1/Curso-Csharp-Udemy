using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace nome_projeto {
    internal class Program {

        static void Main(string[] args) {

            int escolha, quantidade = 0;
            float total = 0;

            Console.WriteLine("Código | Especificação | Preço");
            Console.WriteLine("1 | Cachorro quente | R$4,00");
            Console.WriteLine("2 | X-Salada        | R$4,50");
            Console.WriteLine("3 | X-Bacon         | R$5,00");
            Console.WriteLine("4 | Torrada Simples | R$2,00");
            Console.WriteLine("5 | Refrigerante    | R$1,50");

            Console.WriteLine("\nEscolha seu produto:");
            escolha = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEscolha a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            switch (escolha) {

                case 1:
                    total = quantidade * 4f;
                    break;

                case 2:
                    total = quantidade * 4.50f;
                    break;

                case 3:
                    total = quantidade * 5f;
                    break;

                case 4:
                    total = quantidade * 2f;
                    break;

                case 5:
                    total = quantidade * 1.50f;
                    break;

                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }

            Console.WriteLine("\nTOTAL A PAGAR: R$" + total.ToString("F"));

        }
    }
}

/* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a pagar. */