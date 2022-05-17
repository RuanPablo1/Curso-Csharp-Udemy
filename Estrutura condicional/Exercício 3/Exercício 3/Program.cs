using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace nome_projeto {
    internal class Program {

        static void Main(string[] args) {

            Console.WriteLine("Digite 2 números inteiros: ");

            string[] vetor = Console.ReadLine().Split(' ');
            int numero1 = int.Parse(vetor[0]);
            int numero2 = int.Parse(vetor[1]);

            if (numero1 % numero2 == 0 && numero2 % numero1 == 0) {
                Console.WriteLine("Os números são múltiplos entre si!");
            }
            else {
                Console.WriteLine("Os números não são múltiplos!");
            }
        }
    }
}

/* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente. */